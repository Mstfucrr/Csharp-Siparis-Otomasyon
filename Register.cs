using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROJECT
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
            
        }
        
        private void Button_Register_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Eposta = TxtBoxEmail.Text;
            customer.Parola = TxtBoxPass.Text;
            customer.Ad = TxtBoxAd.Text;
            customer.Soyad = TxtBoxSoyad.Text;
            customer.Adres = TxtBoxAdres.Text;

            

            customer.CustomerRegister(customer);

        }

    }
}
