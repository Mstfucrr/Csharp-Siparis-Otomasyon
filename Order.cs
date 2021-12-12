using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT
{
    public class Order
    {
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string Payment { get; set; }
        public List<OrderDetail> OrderDetails;
        private DB db = new DB();
        
        public Order(int CustomerID)
        {
            this.CustomerId = CustomerID;
            // custemerid Order db'ye kayıt edilecek

            //Siparişlerin Status'ü = 0 (ödenmemiş) olanları silenecek
            DeleteStatus0FromOrderDb();

            // customer için yeni bir order açılıyor id ve statusu (varsayılan 0) kayıt ediliyor
            // status ödeme işlemi tamamlandığı zaman 1 (true) olacak 
            string sorgu = "insert into Orders(CustomerId,Status) Values(@CustomerId,@Status)";
            SqlCommand cmd = new SqlCommand(sorgu, db.baglanti());
            cmd.Parameters.AddWithValue("@CustomerId", this.CustomerId);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.ExecuteNonQuery();
            db.baglanti().Close();
            OrderDetails = new List<OrderDetail>();

        }

        public void UpdateOrderDb()
        {
            if (Payment != "")
            {
                // Payment değeri girilmiş ise veri tabanında güncelliyor.
                string upload = "Update Orders set Payment = @Payment,TotalWeight = @TotalWeight,TotalAmount = @TotalAmount,Status = @Status where id = @id";
                SqlCommand cmd = new SqlCommand(upload,db.baglanti());
                cmd.Parameters.AddWithValue("@Payment", Payment);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@TotalWeight", calcTotalWeight());
                cmd.Parameters.AddWithValue("@TotalAmount", calcTotal());
                cmd.Parameters.AddWithValue("@id", getOrderId());
                cmd.ExecuteNonQuery();
                db.baglanti().Close();

            }

        }


        public void DeleteStatus0FromOrderDb()
        {
            string delete = "Delete From Orders where Status = 0";
            SqlCommand cmd = new SqlCommand(delete,db.baglanti());
            cmd.ExecuteNonQuery();
            db.baglanti().Close();

        }


        public int getOrderId()
        {
            string sorgu = "Select id From Orders where CustomerId = @CustomerId ORDER BY id DESC";
            // sorgu giriş yapan müşterinin id sine göre son eklenen order (siparişi) getiriyor
            SqlCommand cmd = new SqlCommand(sorgu,db.baglanti());
            cmd.Parameters.AddWithValue("@CustomerId", this.CustomerId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return Convert.ToInt32(reader[0].ToString());

            return 0;
        }


        public float calcTax()
        {
            float TotalTax = 0;
            foreach (var orderDetail in OrderDetails)
            {
                TotalTax += orderDetail.CalcSubTax();
            }
            return TotalTax;
        }

        public float calcTotal()
        {
            float TotalPrice = 0;
            foreach (var orderDetail in OrderDetails)
            {
                TotalPrice += orderDetail.CalcSubTotal();
            }

            return TotalPrice;
            
        }

        public float calcTotalWeight()
        {
            float TotalWeight = 0;
            foreach (var orderDetail in OrderDetails)
            {
                TotalWeight += orderDetail.CalcWeight();
            }
            return TotalWeight;
        }

        
    }
}
