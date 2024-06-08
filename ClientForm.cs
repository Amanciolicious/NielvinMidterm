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
    public partial class ClientForm : Form
    {

        AmancioCoopEntities _context = new AmancioCoopEntities();

       
        private int selectedclientid;


       
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

            clientBindingSource.DataSource = _context.Clients.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientAdd client = new clientAdd(clientBindingSource);
            client.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientUpdate update = new clientUpdate(selectedclientid, clientBindingSource);
            update.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var ClientToDelete = _context.Clients.FirstOrDefault(q => q.Id == selectedclientid);

                _context.Clients.Remove(ClientToDelete);
                _context.SaveChanges();

                clientBindingSource.DataSource = _context.Clients.ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            selectedclientid = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refbtn client = new refbtn(selectedclientid, clientBindingSource);
            client.ShowDialog();
        }
    }
    }

