using System;
using System.Windows.Forms;


namespace PROJECT
{
    public partial class CustomerRegisterForm : Form
    {
        public CustomerRegisterForm()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
            
        }
        
        private void Button_Register_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            if (TxtBoxAd.Text.Length == 0 || TxtBoxEmail.Text.Length == 0 || TxtBoxSoyad.Text.Length == 0 ||
                TxtBoxPass.Text.Length == 0 || TxtBoxAdres.Text.Length == 0)
            {
                MessageBox.Show("!!! Lütfen Tüm Boşlukları Doldurduğunuzdan Emin Olun !!!");
            }
            else
            {
                customer.Eposta = TxtBoxEmail.Text;
                customer.Parola = TxtBoxPass.Text;
                customer.Ad = TxtBoxAd.Text;
                customer.Soyad = TxtBoxSoyad.Text;
                customer.Adres = TxtBoxAdres.Text;

                if (customer.CustomerRegister())
                    MessageBox.Show("Başaryıla kayıt oldunuz.");
                this.Close();
               

            }




            

        }

    }
}
