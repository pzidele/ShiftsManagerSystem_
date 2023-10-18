using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftsManagerSystem
{
    public partial class ClockInOut : Form
    {

        public ClockInOut()
        {
            InitializeComponent();
        }

        private void clockInBtn_Click(object sender, EventArgs e)
        {
            // when press this button it adds a new row to shifts table
            // which user is signed in, clockin time and date
            // and message box should come up clock in successful

            // get user that's selected
            if (listView1.SelectedItems.Count != 0)
            {
                int userID = Convert.ToInt32(listView1.SelectedItems[0].Text);


                using (var db = new DataClasses1DataContext())
                {
                    // add new row to shifts table with date now

                    // need to check if this user is clocked in    
                    var user = db.Users.FirstOrDefault(u => u.userID == userID);


                    if (user.isClockedIn == false)
                    {
                        // then this user can clock in
                        var newShift = new Shift
                        {
                            shiftClockIn = DateTime.Now,
                            userID = userID
                        };
                        db.Shifts.InsertOnSubmit(newShift);
                        resultLbl.Text = "Successfully clocked in!";
                        timer1.Start();
                        user.isClockedIn = true;

                    }
                    else
                    {
                        resultLbl.Text = "Error clocking in - user did not clock out.";
                        timer1.Start();
                    }
 
                    
                    db.SubmitChanges();
                }

                listView1.SelectedItems.Clear();

            }
            else
            {
                resultLbl.Text = "Select a user to clock in!";
                timer1.Start();
            }

        }

       

        private void ClockInOut_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            using (var db = new DataClasses1DataContext())
            {

                var users = db.Users;
                listView1.Columns.Add("ID");
                listView1.Columns.Add("Name");
                foreach (var user in users)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { user.userID.ToString(),
                        user.userName}));
                }

                listView1.Columns[0].Width = 0;
                listView1.Columns[1].Width = -1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Clear the label's text after the specified duration
            resultLbl.Text = string.Empty;

            // Stop the timer
            timer1.Stop();
        }

        private void clockOutBtn_Click(object sender, EventArgs e)
        {
            // check if user is clocked out

            // if not add to last row with user a clock out date of now


            if (listView1.SelectedItems.Count != 0)
            {
                int userID = Convert.ToInt32(listView1.SelectedItems[0].Text);

                using (var db = new DataClasses1DataContext())
                {

                    // need to check if this user is clocked out   
                    var user = db.Users.FirstOrDefault(u => u.userID == userID);


                    if (user.isClockedIn == true) // user is clocked in
                    {
                        // then this user can clock out
                        // have to update the last time this user clocked in

                        // get the last row with this user

                        // get the shift id of the most recent entry with this user
                        Shift shift = db.Shifts.Where(s=>s.userID == userID).OrderByDescending(s=>s.shiftID).First();

                        shift.shiftClockOut = DateTime.Now;
                        db.SubmitChanges();

                        resultLbl.Text = "Successfully clocked out!";
                        timer1.Start();
                        user.isClockedIn = false;

                    }
                    else
                    {
                        resultLbl.Text = "Error clocking out - user did not clock in.";
                        timer1.Start();
                    }


                    db.SubmitChanges();
                }

                listView1.SelectedItems.Clear();

            }
            else
            {
                resultLbl.Text = "Select a user to clock out!";
                timer1.Start();
            }
        }
    }
}
