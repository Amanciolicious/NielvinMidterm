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
    public partial class clientAdd : Form
    {
        private BindingSource _BindingSource;
        private readonly AmancioCoopEntities _context = new AmancioCoopEntities();
        public clientAdd()
        {
            InitializeComponent();
        }


        public clientAdd(BindingSource clientinfobindingsource) : this()
        {
            _BindingSource = clientinfobindingsource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fname_val.Text) || string.IsNullOrWhiteSpace(lname_val.Text) || string.IsNullOrWhiteSpace(res_val.Text) || string.IsNullOrWhiteSpace(age_val.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Client clienti = new Client();
                clienti.FirstName = fname_val.Text.Trim();
                clienti.LastName = lname_val.Text.Trim();
                clienti.Residency = res_val.Text.Trim();
                clienti.Age = Int32.Parse(age_val.Text.Trim());

                _context.Clients.Add(clienti);
                _context.SaveChanges();

                _BindingSource.DataSource = _context.Clients.ToList();
                this.Close();
            }
        }

        private void clientAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

    
