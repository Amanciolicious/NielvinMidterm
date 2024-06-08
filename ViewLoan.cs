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
    public partial class refbtn : Form
    {
        AmancioCoopEntities _context = new AmancioCoopEntities();
        private BindingSource _BindingSource;
        
        private int id;


        public refbtn()
        {
            InitializeComponent();
        }

        public refbtn(int id, BindingSource bindingSource) : this() {
            this.id = id;
            _BindingSource = bindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLoan addLoan = new AddLoan(loanBindingSource);
            addLoan.ShowDialog();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amancioCoopDataSet3.Loan' table. You can move, or remove it, as needed.
          
            var clientinfo = _context.Clients.Where(q => q.Id == id).FirstOrDefault();
            label3.Text = clientinfo.FirstName + clientinfo.LastName;
            loanbox.Text = clientinfo.Id.ToString();
            resbox.Text = clientinfo.Residency.ToString();
            agebox.Text = clientinfo.Age.ToString();

            int specificclientid = clientinfo.Id;
            var loansForSpecificClient = _context.Loans.Where(loan => loan.ClientId == specificclientid).ToList();
            loanBindingSource.DataSource = loansForSpecificClient;

        }

        public void refresh()
        {
            var clientinfo = _context.Clients.Where(q => q.Id == id).FirstOrDefault();
            label3.Text = clientinfo.FirstName + clientinfo.LastName;
            loanbox.Text = clientinfo.Id.ToString();
            resbox.Text = clientinfo.Residency.ToString();
            agebox.Text = clientinfo.Age.ToString();
            int specificclientid = clientinfo.Id;
            var loansForSpecificClient = _context.Loans.Where(loan => loan.ClientId == specificclientid).ToList();
            loanBindingSource.DataSource = loansForSpecificClient;
        }

        private void labelbox_Click(object sender, EventArgs e)
        {
           

        }

        private void paidunpaid_Click(object sender, EventArgs e)
        {
            Loan selectedLoan = dataGridView1.SelectedRows[0].DataBoundItem as Loan;

            if (selectedLoan != null)
            {
                if (selectedLoan.Status_Paid == "paid")
                {
                    selectedLoan.Status_Paid = "unpaid";
                }
                else
                {
                    selectedLoan.Status_Paid = "paid";
                }
                _context.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            var searchText = textBox1.Text;
            loanBindingSource.DataSource = _context.Loans.Where(q => (q.LoanID + q.Status_Paid + q.Due_Date + q.Term).Contains(searchText)).ToList();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
