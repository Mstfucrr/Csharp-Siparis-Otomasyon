using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class CustomerOrderShowForm : Form
    {
        private int CustomerId { get; set; }
        public CustomerOrderShowForm(int customerId)
        {
            InitializeComponent();
            this.CustomerId = customerId;

        }

        private DB db = new DB();
        private void CustomerOrderShowForm_Load(object sender, System.EventArgs e)
        {
            string sorgu = "select Orders.id , Orders.TotalAmount , Orders.TotalWeight , Orders.Payment " +
            "from OrderDetails " +
            "inner join Orders on OrderDetails.OrderId = Orders.id "+
            "inner join Products on OrderDetails.ProductId = Products.id "+
            "inner join Customers on Orders.CustomerId = Customers.id where Customers.id = "+this.CustomerId;

            SqlDataAdapter da = new SqlDataAdapter(sorgu, db.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.baglanti().Close();

            dataGridView1.DataSource = dt;
        }
    }
}
