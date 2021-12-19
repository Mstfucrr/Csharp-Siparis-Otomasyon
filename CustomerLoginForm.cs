using System;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (customer.CustomerLogin(TxtEmail.Text, TxtPass.Text))
            {
                MessageBox.Show("Başarıyla giriş Yaptınız");
                this.Close();
                // Müşteri için Ürünler formu 
                OrderForm orderForm = new OrderForm(customer.CustomerId);
                orderForm.Show();
            }
            else
            {
                MessageBox.Show("Eposta veya parola hatalı.");
            }
        }
    }
}
