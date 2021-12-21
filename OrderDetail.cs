using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public float TaxStatus = 0.18F;
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        private Product product = new Product();
        private DB db = new DB();

        public OrderDetail(int orderId)
        {
            this.OrderId = orderId;

            SqlDataReader reader = OrderIdCheckFromOrderDetailsDb();
            if (!reader.Read())
            {
                DeleteOrderDetailsFromDb(); //siparişi olmayan sipariş detaylarını siler
            }

        }

        

        public void DeleteOrderDetailsFromDb()
        {
            string delete = "Delete From OrderDetails where OrderId = @OrderId";
            SqlCommand cmd = new SqlCommand(delete,db.baglanti());
            cmd.Parameters.AddWithValue("@OrderId", OrderId);
            cmd.ExecuteNonQuery();
            db.baglanti().Close();
        }

        public void SaveOrderDetailsData()
        {
            string sorgu = "Insert into OrderDetails(ProductId, Quantity, TaxStatus, OrderId)" +
                           "values(@ProductId, @Quantity, @TaxStatus, @OrderId)";
            SqlCommand cmd = new SqlCommand(sorgu, db.baglanti());
            cmd.Parameters.AddWithValue("@OrderId", this.OrderId);
            cmd.Parameters.AddWithValue("@ProductId",this.ProductId);
            cmd.Parameters.AddWithValue("@Quantity", this.Quantity);
            cmd.Parameters.AddWithValue("@TaxStatus", TaxStatus);
            cmd.ExecuteNonQuery();

            db.baglanti().Close();
        }


        private SqlDataReader OrderIdCheckFromOrderDetailsDb()
        {
            string check = "Select * From Orders where id = @id";
            SqlCommand cmd = new SqlCommand(check,db.baglanti());
            cmd.Parameters.AddWithValue("@id",this.OrderId);
            SqlDataReader reader = cmd.ExecuteReader();
            db.baglanti().Close();

            return reader;

        }


        public float CalcSubTotal()
        {
            SqlDataReader reader = product.GetProductWithQueryandID("BirimFiyat", this.ProductId);
            if (reader.Read())
                return (Quantity * Convert.ToSingle(reader[0])) * (TaxStatus + 1);//vergisi + ücreti 
            return 1;
        }

        public float CalcSubTax()
        {
            SqlDataReader reader = product.GetProductWithQueryandID("BirimFiyat", this.ProductId);
            if (reader.Read())
                return Quantity * Convert.ToSingle(reader[0]) * (TaxStatus);//vergisi 
            return 1;

        }

        public float CalcWeight()
        {
            SqlDataReader reader = product.GetProductWithQueryandID("Agirlik", this.ProductId);
            if (reader.Read())
                return Quantity * Convert.ToSingle(reader[0]);//Ağırlığı
            return 1;
        }
    }
}
