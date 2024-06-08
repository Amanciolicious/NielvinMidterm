using NielvinMidterm.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NielvinMidterm
{
    public partial class clientUpdate : Form
    {

        private int _Id;
        private BindingSource _BindingSource;
        private readonly AmancioCoopEntities _context = new AmancioCoopEntities();


        public clientUpdate()
        {
            InitializeComponent();
        }

        public clientUpdate(int Id, BindingSource bindingSource) : this()
        {
            _Id = Id;
            _BindingSource = bindingSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fname_val.Text) || string.IsNullOrWhiteSpace(lname_val.Text) || string.IsNullOrWhiteSpace(res_val.Text) || string.IsNullOrWhiteSpace(ageval.Text))
            {
                MessageBox.Show("Please fill in all the fields in order to Update.", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ClientIdToBeDeleted = id_val.Text.Trim();

                var ClientToDelete = _context.Clients.FirstOrDefault(q => q.Id.ToString() == ClientIdToBeDeleted);

                ClientToDelete.FirstName = fname_val.Text.Trim();
                ClientToDelete.LastName = lname_val.Text.Trim();
                ClientToDelete.Residency = res_val.Text.Trim();
                ClientToDelete.Age = Int32.Parse(ageval.Text.Trim());

                _context.SaveChanges();

                _BindingSource.DataSource = _context.Clients.ToList();

                this.Close();
            }
        }

            private void clientUpdate_Load(object sender, EventArgs e)
            {
                var clientinfo = _context.Clients.Where(q => q.Id == _Id).FirstOrDefault();
                fname_val.Text = clientinfo.FirstName;
                lname_val.Text = clientinfo.LastName;
                res_val.Text = clientinfo.Residency;
                ageval.Text = clientinfo.Age.ToString();
                id_val.Text = clientinfo.Id.ToString();
            }
        }
    }
   

