using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PROJECT
{
    class Admin
    {
        private string Username { get; set; }

        private string Password { get; set; }

        

        public bool AdminCheck(string username,string password)
        {
            // Admin kullanıcı adı ve parolası varsayılan "admin" değeri olacak 
            this.Username = "admin";
            this.Password = "admin";

            return this.Username == username && this.Password == password;
        }
        
        
    }
}
