using System;
using System.Windows.Forms;

namespace ShiftsManagerSystem
{
    public partial class ViewShifts : Form
    {
        public ViewShifts()
        {
            InitializeComponent();

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            listView1.View = View.Details;

            using (var db = new DataClasses1DataContext())
            {
                var shifts = db.Shifts;
                    //.OrderByDescending(i => i.shiftClockIn);

                showColumns();
                foreach (var s in shifts)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        s.User.userName,
                        s.shiftClockIn.ToShortDateString(),
                        s.shiftClockIn.ToShortTimeString(),
                        s.shiftClockOut?.ToShortDateString(),
                        s.shiftClockOut?.ToShortTimeString(),
                         // add this column to show total time. if clock out is null then this is null
                        s.shiftClockOut != null ? Math.Round((double)(s?.shiftClockOut?.Subtract(s.shiftClockIn).TotalMinutes)).ToString() : null,

                })); 
                    
                }
                setWidth();

            }
        }

        private void showColumns()
        {
            listView1.Columns.Add("User Name");
            listView1.Columns.Add("Clock In Date");
            listView1.Columns.Add("Clock In Time");
            listView1.Columns.Add("Clock Out Date");
            listView1.Columns.Add("Clock Out Time");
            listView1.Columns.Add("Total Time in Minutes");
        }

        private void setWidth()
        {
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = -2;
            }
        }

        private void ViewShifts_Load(object sender, EventArgs e)
        {
            viewBtn_Click(sender, e);
        }
    }
}
