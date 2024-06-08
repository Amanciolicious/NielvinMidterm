using NielvinMidterm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NielvinMidterm
{
    public partial class AddLoan : Form
    {
        private BindingSource _BindingSource;
        private readonly AmancioCoopEntities _context = new AmancioCoopEntities();
        public AddLoan()
        {
            InitializeComponent();
        }




        public AddLoan(BindingSource loanBindingSource) : this()
        {
            _BindingSource = loanBindingSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Loan loan = new Loan();
                loan.ClientId = Int32.Parse(clientidbox.Text.Trim());
                loan.Loan_AMT = Int32.Parse(loanamountbox.Text.Trim());
                loan.Interest = Int32.Parse(interestbox.Text.Trim());
                loan.Term = termbox.Text.Trim();
                loan.No_of_Payment = Int32.Parse(noofpaymentbox.Text.Trim());
                loan.Deduction = Int32.Parse(deductionbox.Text.Trim());
                loan.Interested_AMT = float.Parse(interestedamountbox.Text.Trim());
                loan.Receivable_AMT = float.Parse(receivableamountbox.Text.Trim());
                loan.Total_Payable = float.Parse(totalpayablebox.Text.Trim());
                loan.Status_Paid = statusbox.Text.Trim();
                loan.Due_Date = Convert.ToDateTime(datebox.Text.Trim());

                _context.Loans.Add(loan);
                _context.SaveChanges();

                _BindingSource.DataSource = _context.Loans.ToList();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void interestbox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(loanamountbox.Text.Trim(), out double loanAmt) &&
                double.TryParse(interestbox.Text.Trim(), out double interestRate))
            {
                double interestedAmt = loanAmt * (interestRate / 100);
                interestedamountbox.Text = interestedAmt.ToString();
            }

            interest2.Text = interestbox.Text + "%" ;

        }

        private void deductionbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
          
                if (!float.TryParse(loanamountbox.Text.Trim(), out float loanAmount))
                {
                    receivableamountbox.Text = "Invalid loan amount";
                    return;
                }

                if (!float.TryParse(interestbox.Text.Trim(), out float interestRate))
                {
                    receivableamountbox.Text = "Invalid interest rate";
                    return;
                }
     
                float deduction = 0;
                
                if (!string.IsNullOrEmpty(deductionbox.Text))
                {
                    if (!float.TryParse(deductionbox.Text.Trim(), out deduction))
                    {
                        receivableamountbox.Text = "Invalid deduction amount";
                        return;
                    }
                }

              
                float interestAmount = loanAmount * (interestRate / 100);
                float totalPayable = loanAmount + interestAmount;            
                float totalAfterDeduction = totalPayable - deduction;

                if (totalAfterDeduction < 0)
                {
                    receivableamountbox.Text = "Total after deduction cannot be negative";
                    return;
                }

                receivableamountbox.Text = totalAfterDeduction.ToString("F2"); // Format to 2 decimal places for better readability
            }
            catch (Exception ex)
            {
                receivableamountbox.Text = "An error occurred: " + ex.Message;
            }

            deduction2.Text = deductionbox.Text;
        }

        private void receivableamountbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loanamountbox.Text) && termbox.SelectedItem != null &&
                !string.IsNullOrEmpty(noofpaymentbox.Text) && !string.IsNullOrEmpty(interestbox.Text))
            {
                decimal loanAmount = decimal.Parse(loanamountbox.Text);
                string term = termbox.SelectedItem.ToString();
                int numberOfPayments = int.Parse(noofpaymentbox.Text);
                decimal interestRate = decimal.Parse(interestbox.Text);

                decimal interestAmount = loanAmount * interestRate / 100 * numberOfPayments;
                decimal receivableAmount = loanAmount + interestAmount;
                totalpayablebox.Text = receivableAmount.ToString();
            }
        }

        private void noofpaymentbox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(noofpaymentbox.Text))
            {

                string term = termbox.Text.Trim();
                int payment = Convert.ToInt32(noofpaymentbox.Text.Trim());
                DateTime currentdate = DateTime.Now;

                if (term == "Daily")
                {
                    datebox.Text = currentdate.AddDays(payment).ToString("MM/dd/yyyy");
                }
                else if (term == "Weekly")
                {
                    datebox.Text = currentdate.AddDays(payment * 7).ToString("MM/dd/yyyy");
                }
                else if (term == "Monthly")
                {
                    datebox.Text = currentdate.AddMonths(payment).ToString("MM/dd/yyyy");
                }
                else if (term == "Bi-monthly")
                {
                    datebox.Text = currentdate.AddDays(payment * 15).ToString("MM/dd/yyyy");
                }
            }
            noofpayment2.Text = noofpaymentbox.Text;
        }

        private void statusbox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(noofpaymentbox.Text))
            {
                string term = termbox.Text.Trim();
                int payment = Convert.ToInt32(noofpaymentbox.Text.Trim());
                DateTime currentdate = DateTime.Now;

                if (term == "Daily")
                {
                    datebox.Text = currentdate.AddDays(payment).ToString("MM/dd/yyyy");
                }
                else if (term == "Weekly")
                {
                    datebox.Text = currentdate.AddDays(payment * 7).ToString("MM/dd/yyyy");
                }
                else if (term == "Monthly")
                {
                    datebox.Text = currentdate.AddMonths(payment).ToString("MM/dd/yyyy");
                }
                else if (term == "Bi-monthly")
                {
                    datebox.Text = currentdate.AddDays(payment * 15).ToString("MM/dd/yyyy");
                }
            }

        }

        private void loanamountbox_TextChanged(object sender, EventArgs e)
        {
            loanamount2.Text = loanamountbox.Text;
        }

        private void termbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            term2.Text = termbox.Text;
        }
    }
}