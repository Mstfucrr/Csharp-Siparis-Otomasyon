using System;
using System.Data.SqlClient;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustomerId;
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // seçilen satır
                CustomerId = Convert.ToInt32(row.Cells[0].Value);// seçilen Customer'ın id'si
                CustomerOrderShowForm showForm = new CustomerOrderShowForm(CustomerId);
                showForm.Show();
            }
            catch (Exception)
            { }


        }
    }
}
