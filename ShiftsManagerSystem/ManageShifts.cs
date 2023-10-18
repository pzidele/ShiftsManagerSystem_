using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShiftsManagerSystem
{
    public partial class ManageShifts : Form
    {
        public ManageShifts()
        {
            InitializeComponent();
        }

        private void ManageShifts_Load(object sender, EventArgs e)
        {
            // format the date time pickers to show time
            outDateTimePicker.Format = DateTimePickerFormat.Custom;
            outDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            inDateTimePicker.Format = DateTimePickerFormat.Custom;
            inDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            listView1.Clear();
            listView1.View = View.Details;

            using (var db = new DataClasses1DataContext())
            {
                var shifts = db.Shifts
                    .OrderByDescending(i => i.shiftClockIn);

                listView1.Columns.Add("ID");
                listView1.Columns.Add("User Name");
                listView1.Columns.Add("Clock In Date");
                listView1.Columns.Add("Clock In Time");
                listView1.Columns.Add("Clock Out Date");
                listView1.Columns.Add("Clock Out Time");

                foreach (var s in shifts)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        s.shiftID.ToString(),
                        s.User.userName,
                        s.shiftClockIn.ToShortDateString(),
                        s.shiftClockIn.ToShortTimeString(),
                        s.shiftClockOut?.ToShortDateString(),
                        s.shiftClockOut?.ToShortTimeString()
                         }));
                }
                listView1.Columns[0].Width = 0;
                listView1.Columns[1].Width = -1;
                listView1.Columns[2].Width = -1;
            }
        }


        private void updateInBtn_Click(object sender, EventArgs e)
        {
            // first check if soemthing is selected
            if (listView1.SelectedItems.Count != 0)
            {
                // get the shift id of whats selected
                int shiftID = Convert.ToInt32(listView1.SelectedItems[0].Text);

                // take whats in the indatetimepicker 
                DateTime newClockIn = inDateTimePicker.Value;

                // update in the db
                using (var db = new DataClasses1DataContext())
                {
                    Shift shift = db.Shifts.Where(s => s.shiftID == shiftID).OrderByDescending(s => s.shiftID).First();

                    if (shift.shiftClockOut != null)
                    {
                     if (shift.shiftClockOut < newClockIn)
                        {
                            // then can't change to this date
                            inLbl.Text = "Must choose a clock in date/time before clock out.";
                            timer1.Start();
                        }
                        else
                        {
                            shift.shiftClockIn = newClockIn;
                            db.SubmitChanges();
                            inLbl.Text = "Updated clock in";
                            timer1.Start();
                        }

                    }
                    else
                    {
                        // clock out is null so don't have to compare
                        shift.shiftClockIn = newClockIn;
                        db.SubmitChanges();
                        inLbl.Text = "Updated clock in";
                        timer1.Start();
                    }

                }



            }


        }

        private void updateOutBtn_Click(object sender, EventArgs e)
        {
            // first check if soemthing is selected
            if (listView1.SelectedItems.Count != 0)
            {
                // get the shift id of whats selected
                int shiftID = Convert.ToInt32(listView1.SelectedItems[0].Text);

                // take whats in the indatetimepicker 

                DateTime newClockOut = outDateTimePicker.Value;

                // the out is stored as a string in the db 

                // update in the db
                using (var db = new DataClasses1DataContext())
                {
                    Shift shift = db.Shifts.Where(s => s.shiftID == shiftID).OrderByDescending(s => s.shiftID).First();
                    if (shift.shiftClockOut != null)
                    {
                        if (newClockOut < shift.shiftClockIn)
                        {
                            // then can't change to this date
                            outLbl.Text = "Must choose a clock out date/time after clock in.";
                            timer1.Start();
                        }
                        else
                        {
                            shift.shiftClockOut = newClockOut;

                           

                            db.SubmitChanges();
                            outLbl.Text = "Updated clock out";
                            timer1.Start();
                        }

                    }
                    else
                    {
                        // clock out is null so don't have to compare
                        shift.shiftClockOut = newClockOut;                        
                        db.SubmitChanges();
                        outLbl.Text = "Updated clock out";
                        timer1.Start();
                    }


                }
            }
            else
            {
                resultLbl.Text = "Must select a shift to modify.";
                timer1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            // Clear the label's text after the specified duration
            inLbl.Text = string.Empty;
            outLbl.Text = string.Empty;

            // Stop the timer
            timer1.Stop();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // get selected shift
            // delete entry from db
            if (listView1.SelectedItems.Count != 0 )
            {
                int shiftID = Convert.ToInt32(listView1.SelectedItems[0].Text);
                using (var db = new DataClasses1DataContext())
                {
                    Shift shift = db.Shifts.Where(s => s.shiftID == shiftID)
                        .OrderByDescending(s => s.shiftID).First();
                    db.Shifts.DeleteOnSubmit(shift);
                    db.SubmitChanges();
                    resultLbl.Text = "Deleted shift.";
                    timer1.Start();

                }
            }
        }

        private void deleteOutBtn_Click(object sender, EventArgs e)
        {
            // get selected shift
            // set the clock out to null
            if (listView1.SelectedItems.Count != 0)
            {
                // get the shift id of whats selected
                int shiftID = Convert.ToInt32(listView1.SelectedItems[0].Text);

                using (var db = new DataClasses1DataContext())
                {
                    Shift shift = db.Shifts.Where(s => s.shiftID == shiftID)
                        .OrderByDescending(s => s.shiftID).First();
                    if (shift.shiftClockOut == null)
                    {
                        resultLbl.Text = "No clock out to delete.";
                    }
                    else
                    {
                        shift.shiftClockOut = null;
                        // change user clocked in to false
                        // get the user id from shift id
                        var userID = db.Shifts
                            .Where(s => s.shiftID == shiftID)
                            .Select(s => s.userID)
                            .FirstOrDefault();
                        User user = db.Users.Where(s => s.userID == userID).FirstOrDefault();
                        user.isClockedIn = false;


                        db.SubmitChanges();
                        resultLbl.Text = "Deleted clock out";
                    }
                    timer1.Start();
                }
            }
        }
    }
}
