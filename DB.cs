using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PROJECT
{
    public class DB
    {
        public SqlConnection baglanti()
        {
            string conString = @"Data Source=LAPTOP-DM5KL2SF\SQLEXPRESS;Initial Catalog=OrderDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            //Data Source=LAPTOP-DM5KL2SF\SQLEXPRESS;Initial Catalog=OrderDatabase;Integrated Security=True
            return con;
        }
          
         


        

    }
}
