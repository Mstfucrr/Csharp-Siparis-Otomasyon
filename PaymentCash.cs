using System.Windows.Forms;

namespace PROJECT
{
    class PaymentCash:Payment
    {
        private float cashTendered { get; set; }
        
        public string PaymentCashConfirm()
        {
            this.cashTendered = base.Amount;
            return ("Kargo yolda\nÖdeme tutarı : " + cashTendered);
        }
    }
}
