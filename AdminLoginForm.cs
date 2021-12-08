using System;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(TxtUsername.Text,TxtPass.Text);
        }
    }
}
