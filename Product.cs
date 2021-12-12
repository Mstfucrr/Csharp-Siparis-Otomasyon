using System;
using System.Data;
using System.Data.SqlClient;

namespace PROJECT
{
    public class Product
    {
        public string Ad { get; set; }
        public string Tanim { get; set; }
        public float Agirlik { get; set; }
        public float BirimFiyat { get; set; }

        public float getPriceForQuantity()
        {
            return this.BirimFiyat;
        }

        public float getWeight()
        {
            return this.Agirlik;
        }



        private DB db = new DB();

        public SqlDataReader GetProductWithQueryandID(string query,int productId)
        {

            string get = "Select "+query+" From Products where id=@id";

            SqlCommand cmd = new SqlCommand(get, db.baglanti());
            cmd.Parameters.AddWithValue("@id",productId);
            SqlDataReader reader = cmd.ExecuteReader();

            db.baglanti().Close();
            return reader;
        }

        public DataTable GetProducts(string sorgu)
        {
            string get = "Select "+sorgu+" From Products";
            SqlCommand cmd = new SqlCommand(get,db.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.baglanti().Close();
            return dt;
        }

        public bool AddProduct()
        {
            string AddString = "insert into Products(Ad,BirimFiyat,Tanim,Agirlik,Upload_date) values (@Ad,@BirimFiyat,@Tanim,@Agirlik,@Upload_date)";
            DB db = new DB();
            SqlCommand cmd = new SqlCommand(AddString,db.baglanti());
            cmd.Parameters.AddWithValue("@Ad",this.Ad);
            cmd.Parameters.AddWithValue("@BirimFiyat",this.BirimFiyat);
            cmd.Parameters.AddWithValue("@Agirlik",this.Agirlik);
            cmd.Parameters.AddWithValue("@Tanim",this.Tanim);
            cmd.Parameters.AddWithValue("@Upload_date", DateTime.Now);
            int i = cmd.ExecuteNonQuery();
            db.baglanti().Close();

            return i != 0;
        }

        public bool UpdateProduct(int id,string Ad, float BirimFiyat,string Tanim,float Agirlik)
        {
            DB db = new DB();
            this.Ad = Ad;
            this.Agirlik = Agirlik;
            this.BirimFiyat = BirimFiyat;
            this.Tanim = Tanim;

            string UpdateString = "update Products set Ad=@Ad,BirimFiyat=@BirimFiyat,Tanim=@Tanim,Agirlik=@Agirlik where id=@id";
            SqlCommand cmd = new SqlCommand(UpdateString,db.baglanti());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Ad", Ad);
            cmd.Parameters.AddWithValue("@BirimFiyat",BirimFiyat);
            cmd.Parameters.AddWithValue("@Tanim",Tanim);
            cmd.Parameters.AddWithValue("@Agirlik",Agirlik);
            int i = cmd.ExecuteNonQuery();
            db.baglanti().Close();
            return i != 0;
        }

        public bool DeleteProduct(int id)
        {
            DB db = new DB();
            string DeleteString = "Delete from Products where id=@id";
            SqlCommand cmd = new SqlCommand(DeleteString,db.baglanti());
            cmd.Parameters.AddWithValue("@id", id);
            int i = cmd.ExecuteNonQuery();
            db.baglanti().Close();

            return i != 0;
        }
    }
}
