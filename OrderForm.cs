using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class OrderForm : Form
    {
        public Order order;
        public DB db;
        public int OrderId { get; set; }
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
                product.Ad = reader[1].ToString();
                product.BirimFiyat = Convert.ToSingle(reader[2]);
                product.Tanim = reader[3].ToString();
                product.Agirlik = Convert.ToSingle(reader[4]);

                ListName.Items.Add(reader[1].ToString());
                ListPrice.Items.Add(product.getPriceForQuantity() + " x " +quantity.Text);
                ListWeight.Items.Add(product.getWeight()+ " x " +quantity.Text);
            }

            OrderId = order.getOrderId();

            OrderDetail orderDetail = new OrderDetail(OrderId);
            orderDetail.ProductId = Productid;
            orderDetail.Quantity = Convert.ToInt32(quantity.Text);
            
            order.OrderDetails.Add(orderDetail);
            LblTax.Text = order.calcTax().ToString();
            LblAmount.Text = order.calcTotal().ToString();
            LblPrice.Text = (order.calcTotal()-order.calcTax()).ToString();
            LblWeight.Text = order.calcTotalWeight().ToString();


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
                    //ödeme yöntemi seçilip sepet onaylandığında order TotalWeight,TotalAmount,Paymet güncelleniyor   
                    if (comboBox1.SelectedItem.ToString() == "Nakit")
                    {
                        order.Payment = "Nakit";
                        order.Status = true;
                        order.UpdateOrderDb();//ödeme yöntemi seçilip sepet onaylandığında order TotalWeight,TotalAmount,Paymet güncelleniyor   

                        PaymentCash cash = new PaymentCash();
                        cash.Amount = order.calcTotal();
                        MessageBox.Show(cash.PaymentCashConfirm());
                        OrderForm form = new OrderForm(order.CustomerId);
                        form.Show();
                        this.Close();
                        // Sipariş db'ye eklenecek
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Kredi Kartı")
                    {
                        order.Payment = "Kredi Kartı";
                        order.UpdateOrderDb();//ödeme yöntemi seçilip sepet onaylandığında order TotalWeight,TotalAmount,Paymet güncelleniyor   
                        PaymentCreditForm paymentCreditForm = new PaymentCreditForm();
                        paymentCreditForm.Show();
                    }
                    else
                    {
                        order.Payment = "Çek";
                        order.UpdateOrderDb();//ödeme yöntemi seçilip sepet onaylandığında order TotalWeight,TotalAmount,Paymet güncelleniyor   

                        PaymentCheckForm paymentCheckForm = new PaymentCheckForm();
                        paymentCheckForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçin !");
            }
            
            
        }
    }
}
