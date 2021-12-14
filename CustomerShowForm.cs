using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class CustomerShowForm : Form
    {
        public CustomerShowForm()
        {
            InitializeComponent();
        }

        private void CustomerShowForm_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            dataGridView1.DataSource = customer.GetCustomers();
        }
    }
}
