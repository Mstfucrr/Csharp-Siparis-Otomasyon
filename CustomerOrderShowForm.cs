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
            string orderQuery = "select Orders.id , Orders.TotalAmount , Orders.TotalWeight , Orders.Payment , Orders.Created_date from Customers inner join Orders " +
                                "on Orders.CustomerId = Customers.id where Customers.id = " + this.CustomerId;
            SqlDataAdapter OrderDa = new SqlDataAdapter(orderQuery, db.baglanti());
            
            DataTable dt = new DataTable();
            
            OrderDa.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].HeaderText = "Ödeme Tutarı";
            dataGridView1.Columns[2].HeaderText = "Kargo Ağırlığı";
            dataGridView1.Columns[3].HeaderText = "Ödeme Yöntemi";
            dataGridView1.Columns[4].HeaderText = "Sipariş Tarihi";

            db.baglanti().Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // seçilen satır

                int OrderId = Convert.ToInt32(row.Cells[0].Value);

                if (OrderId == 58)
                {
                    MessageBox.Show("Test");
                }

                string join = "from OrderDetails inner join Orders " +
                              "on OrderDetails.OrderId = Orders.id inner join Products " +
                              "on OrderDetails.ProductId = Products.id inner join Customers " +
                              "on Orders.CustomerId = Customers.id where OrderDetails.OrderId = " + OrderId;

                string detailQueryAd = "select Products.Ad , OrderDetails.Quantity " + join;

                SqlDataAdapter DetaildDa = new SqlDataAdapter(detailQueryAd, db.baglanti());
                DataTable dt2 = new DataTable();
                DetaildDa.Fill(dt2);

                dataGridView2.DataSource = dt2;

                dataGridView2.Columns[0].HeaderText = "Ürün Adı";
                dataGridView2.Columns[1].HeaderText = "Sipariş Miktarı";
            }
            catch (Exception)
            { }

        }
    }
}
