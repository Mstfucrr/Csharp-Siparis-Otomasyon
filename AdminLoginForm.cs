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
            Admin admin = new Admin();
            
            if (admin.AdminCheck(TxtUsername.Text, TxtPass.Text))
            {
                 MessageBox.Show("Başarıyla Giriş Yaptınız");
                 this.Close();
                 ControlPanelForm controlPanelForm = new ControlPanelForm();
                 controlPanelForm.Show();
            }
            else
                 MessageBox.Show("Kullanıcı Adı Veya Parola Hatalı");

        }
    }
}
