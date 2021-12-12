using System;
using System.Data;
using System.Data.SqlClient;

namespace PROJECT
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public float TaxStatus = 0.18F;
        public int ProductId;
        public int OrderId;
        private Product product = new Product();

        public OrderDetail(int orderId)
        {
            this.OrderId = orderId;
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
