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

            LoadForm(new CustomerRegisterForm());
            
        }

        private void LoadForm(Form f)
        {
            if (PanelForm.Controls.Count > 0)
                PanelForm.Controls.RemoveAt(0);
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            PanelForm.Controls.Add(f);
            f.Show();
        }
       

        private void BtnCustomerLogin_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerLoginForm());

        }

        private void BtnControl_Panel_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminLoginForm());
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
