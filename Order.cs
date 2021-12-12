using System;
using System.Collections.Generic;
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

        
        public Order(int CustomerID)
        {
            OrderDetails = new List<OrderDetail>();
            this.CustomerId = CustomerID;
            // custemerid Order db'ye kayıt edilecek
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
