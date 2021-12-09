using System.Windows.Forms;

namespace PROJECT
{
    class PaymentCash:Payment
    {
        public float cashTendered { get => base.Amount; }

        public PaymentCash()
        {
            MessageBox.Show("Kargo yolda\nÖdeme tutarı : " + cashTendered);
        }
    }
}
