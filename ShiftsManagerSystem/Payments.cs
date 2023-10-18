using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftsManagerSystem
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {                
            // get amount from textbox
            string input = amountTextBox.Text;

            if (listView1.SelectedItems.Count != 0 && isValidDecimal(input)
                && paymentDateTimePicker.Value != null)
            {
                decimal amount = decimal.Parse(input);
             
                // insert into payments a record of payment
                using (var db = new DataClasses1DataContext())
                {
                    // get the userID
                    int userID = Convert.ToInt32(listView1.SelectedItems[0].Text);

                    // date in the indatetimepicker 
                    DateTime date = paymentDateTimePicker.Value;

                    var newPayment = new Payment
                    {
                        userID = userID,
                        paymentAmount = amount,
                        paymentDate = date
                    };
                    db.Payments.InsertOnSubmit(newPayment);
                    db.SubmitChanges();
                }



                resultLbl.Text = "Success!";
            }
            else
            {
                resultLbl.Text = "Invalid!";
            }
            timer1.Start();

            amountTextBox.Text = string.Empty;
        }

        static bool isValidDecimal(string input)
        {
            // Regex pattern to match decimal numbers
            string pattern = @"^-?\d+(\.\d+)?$";
            return Regex.IsMatch(input, pattern);
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            listView1.Clear();

            listView1.View = View.Details;

            using (var db = new DataClasses1DataContext())
            {
                var users = db.Users;

                listView1.Columns.Add("ID");
                listView1.Columns.Add("User Name");
             //   listView1.Columns.Add("Total Unpaid");

                foreach (var u in users)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        u.userID.ToString(),
                        u.userName//,
                        // (shift hours * rate) - payments

                }));

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
       

        private void changeRateBtn_Click(object sender, EventArgs e)
        {
            // get rate from textbox
            // get chosen user
            // update rate for that user


            // get amount from textbox
            string input = rateTextBox.Text;

            if (listView1.SelectedItems.Count != 0 && isValidDecimal(input))
            {
                decimal amount = decimal.Parse(input);

                // update user's rate
                using (var db = new DataClasses1DataContext())
                {
                    // get the userID
                    int userID = Convert.ToInt32(listView1.SelectedItems[0].Text);
                    User user = db.Users.Where(u => u.userID == userID)
                        .FirstOrDefault();
                    user.userRate = amount;
                    db.SubmitChanges();
                    resultLbl.Text = "Changed rate.";
                }
            }
            else
            {
                resultLbl.Text = "Invalid!";
            }
            timer1.Start();

            rateTextBox.Text = string.Empty;

        }

        private void viewUnpaidBtn_Click(object sender, EventArgs e)
        {
            // clear unpaidAmtLbl
            unpaidAmtLbl.Text = string.Empty;

            // get chosen user
            if (listView1.SelectedItems.Count != 0)
            {
                // get the shift id of whats selected
                int userID = Convert.ToInt32(listView1.SelectedItems[0].Text);

                using (var db = new DataClasses1DataContext())
                {
                    User user = db.Users.Where(u => u.userID == userID)
                        .OrderByDescending(u => u.userID).First();

            
                    var totalMin = 0.0;
                    foreach (var s in db.Shifts)
                    {
                        if (s.userID == userID && s.shiftClockOut != null)
                        {
                            //totalMin += s.shiftClockOut - s.shiftClockIn;
                            TimeSpan timeSpan = (TimeSpan)(s.shiftClockOut - s.shiftClockIn);

                            double tm = timeSpan.TotalMinutes;
                            totalMin += tm;

                        }
                    }

                    // now get the payments total
                    var paymentQuery = db.Payments.Where(u => u.userID == userID)
                               .Select(p => p.paymentAmount);

                    decimal totalPayments = paymentQuery.Any() ? (decimal)paymentQuery.Sum() : 0;



                    decimal totalHours = (decimal)(totalMin / 60);

                    // if user rate is null then say no rate
                    if (user.userRate == null)
                    {
                        unpaidAmtLbl.Text += "No rate";
                    }
                    else
                    {
                        decimal totalUnpaidAmount = Math.Round( (decimal)(((totalHours) * (user?.userRate)) - totalPayments),2);
                        unpaidAmtLbl.Text += totalUnpaidAmount;
                    }

                }
            }
        }
    }
}
