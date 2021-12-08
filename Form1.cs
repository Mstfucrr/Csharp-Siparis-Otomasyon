using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            CustomerRegisterForm registerForm = new CustomerRegisterForm();
            registerForm.Show();

        }

       

        private void BtnCustomerLogin_Click(object sender, EventArgs e)
        {
            CustomerLoginForm customerLoginForm = new CustomerLoginForm();
            customerLoginForm.Show();

        }

        private void BtnControl_Panel_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
