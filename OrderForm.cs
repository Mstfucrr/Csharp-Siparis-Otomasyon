using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class OrderForm : Form
    {
        public Order order;
        public DB db;
        Product product = new Product();

        public OrderForm(int customerId)
        {
            InitializeComponent();
            order = new Order(customerId);
            db = new DB();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = product.GetProducts("id,Ad,BirimFiyat");
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 0;
            
            BtnConfirmBasket.Enabled = false;
            comboBox1.Enabled = false;
            BtnAdd_Basket.Enabled = false;

        }

        private int Productid;
        private void SelectShowProductDetail(object sender, DataGridViewCellEventArgs e)
        {
            if (!BtnAdd_Basket.Enabled)
                BtnAdd_Basket.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // seçilen satır

                Productid = Convert.ToInt32(row.Cells[0].Value);// seçilen product'ın id'si
                
                SqlDataReader reader = product.GetProductWithQueryandID("*",Productid);
                if (reader.Read())
                {
                    TxtAd.Text = reader[1].ToString();
                    TxtFiyat.Text = Convert.ToSingle(reader[2]).ToString();
                    TxtTanim.Text = reader[3].ToString();
                    TxtAgirlik.Text = reader[4].ToString();

                }
            }
        }

        private void Btn_RemoveBasket_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm(order.CustomerId);
            form.Show();
            this.Close();
        }

        private void Add_Basket_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = product.GetProductWithQueryandID("*",Productid);
            if (reader.Read())
            {
                ListName.Items.Add(reader[1].ToString());
                ListPrice.Items.Add(reader[2] + " x " +quantity.Text);
                ListWeight.Items.Add(reader[4].ToString());
            }
            
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.ProductId = Productid;
            orderDetail.Quantity = Convert.ToInt32(quantity.Text);
            
            order.OrderDetails.Add(orderDetail);
            LblTax.Text = order.calcTax().ToString();
            LblAmount.Text = order.calcTotal().ToString();
            LblPrice.Text = (order.calcTotal()-order.calcTax()).ToString();


            if (!BtnConfirmBasket.Enabled)
            {
                BtnConfirmBasket.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void BtnConfirmBasket_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show(comboBox1.SelectedItem+" ödeme\nÖdenecek tutar : "+order.calcTotal()+"\nSepeti onaylıyor musunuz ?", "Onay", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && comboBox1.SelectedIndex >= 0)
                {
                    
                    if (comboBox1.SelectedItem.ToString() == "Nakit")
                    {
                        MessageBox.Show("Kargo yolda\nHayırlı olsun.");
                        // Sipariş db'ye eklenecek
                    }
                    //Ödeme yöntemi formu ve Sepete eklenenler Formu gelecek
                    // kredi kartı veya çek ödeme işlemi tamamlandıktan sonra Sipariş db'ye kaydedilecek 
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçin !");
            }
            
            
        }
    }
}
