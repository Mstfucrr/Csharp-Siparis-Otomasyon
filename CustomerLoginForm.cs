using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MessageBox.Show(customer.CustomerLogin(TxtEmail.Text, TxtPass.Text)
                ? "Başarıyla Giriş Yaptınız"
                : "Eposta veya parola Hatalı");
        }
    }
}
