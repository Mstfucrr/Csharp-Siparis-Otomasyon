using System;
using System.Data.SqlClient;

namespace PROJECT
{
    class Product
    {
        public string Ad { get; set; }
        public string Tanim { get; set; }
        public float Agirlik { get; set; }
        public float BirimFiyat { get; set; }


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

            return i != 0;
        }

        public bool UpdateProduct(int id,string Ad, float BirimFiyat,string Tanim,float Agirlik)
        {
            DB db = new DB();

            string UpdateString = "update Products set Ad=@Ad,BirimFiyat=@BirimFiyat,Tanim=@Tanim,Agirlik=@Agirlik where id=@id";
            SqlCommand cmd = new SqlCommand(UpdateString,db.baglanti());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Ad", Ad);
            cmd.Parameters.AddWithValue("@BirimFiyat",BirimFiyat);
            cmd.Parameters.AddWithValue("@Tanim",Tanim);
            cmd.Parameters.AddWithValue("@Agirlik",Agirlik);
            int i = cmd.ExecuteNonQuery();
            
            return i != 0;
        }

        public bool DeleteProduct(int id)
        {
            DB db = new DB();
            string DeleteString = "Delete from Products where id=@id";
            SqlCommand cmd = new SqlCommand(DeleteString,db.baglanti());
            cmd.Parameters.AddWithValue("@id", id);
            int i = cmd.ExecuteNonQuery();

            return i != 0;
        }
    }
}
