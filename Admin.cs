using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PROJECT
{
    class Admin
    {
        private string Username { get; set; }

        private string Password { get; set; }

        

        public Admin(string username,string password)
        {

            this.Username = "admin";
            this.Password = "admin";

            MessageBox.Show((this.Username == username && this.Password == password)
                ? "Başarıyla Giriş Yaptınız"
                : "Kullanıcı adınız veya Parolanız Hatalı !");
        }
        
    }
}
