using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    class Customer
    {
        public string Parola { get; set; }
        public string Eposta { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public DB db = new DB();


        public bool CustomerRegister(Customer customer)
        {
            string register = "insert into Customers(Eposta,Parola,Ad,Soyad,Adres,Created_date) values (@Eposta,@Parola,@Ad,@Soyad,@Adres,@Created_date)";
            

            SqlCommand cmd = new SqlCommand(register, db.baglanti());

            cmd.Parameters.AddWithValue("@Eposta", customer.Eposta);
            cmd.Parameters.AddWithValue("@Parola", customer.Parola);
            cmd.Parameters.AddWithValue("@Ad", customer.Ad);
            cmd.Parameters.AddWithValue("@Soyad", customer.Soyad);
            cmd.Parameters.AddWithValue("@Adres", customer.Adres);
            cmd.Parameters.AddWithValue("@Created_date", DateTime.Now);
            int i = cmd.ExecuteNonQuery();
            db.baglanti().Close();
            return i != 0;
        }   

        public bool CustomerLogin(string email,string password)
        {

            string loginQuery = "Select * From Customers where Eposta = @p1 and Parola = @p2";
            SqlCommand cmd = new SqlCommand(loginQuery, db.baglanti());

            cmd.Parameters.AddWithValue("@p1", email);
            cmd.Parameters.AddWithValue("@p2", password);
            SqlDataReader dr = cmd.ExecuteReader();
            db.baglanti().Close();
            return dr.Read();
        }

    }
}
