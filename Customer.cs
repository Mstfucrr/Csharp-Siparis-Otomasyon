using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Parola { get; set; }
        public string Eposta { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        private DB db = new DB();


        public DataTable GetCustomers()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select id,Ad,Soyad,Adres,Eposta,Created_date From Customers",db.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.baglanti().Close();
            return dt;
        }

        public bool CustomerRegister()
        {
            string register = "insert into Customers(Eposta,Parola,Ad,Soyad,Adres,Created_date) values (@Eposta,@Parola,@Ad,@Soyad,@Adres,@Created_date)";
            

            SqlCommand cmd = new SqlCommand(register, db.baglanti());

            cmd.Parameters.AddWithValue("@Eposta", this.Eposta);
            cmd.Parameters.AddWithValue("@Parola", this.Parola);
            cmd.Parameters.AddWithValue("@Ad", this.Ad);
            cmd.Parameters.AddWithValue("@Soyad", this.Soyad);
            cmd.Parameters.AddWithValue("@Adres", this.Adres);
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
            if (dr.Read())
            {
                this.CustomerId = Convert.ToInt32(dr[0]);
                this.Ad = dr[1].ToString();
                this.Soyad = dr[2].ToString();
                this.Adres = dr[3].ToString();
                this.Eposta = dr[4].ToString();
                return true;
            }

            return false;
        }

    }
}
