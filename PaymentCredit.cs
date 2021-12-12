using System;
using System.Windows.Forms;

namespace PROJECT
{
    class PaymentCredit: Payment
    {

        public ulong cartNumber { get; set; }
        public string cartType { get; set; }
        public DateTime CartExpDateTime { get; set; }
        public string cartOwner { get; set; }


        public override string Authorized()
        {
            return cartType + " Kart Bilgileri" +
                   "\n\tNumarası : " + this.cartNumber +
                   "\n\tSahibi : " + this.cartOwner +
                   "\n\tSon Ödeme Tarihi : " + this.CartExpDateTime.Month + " / " + this.CartExpDateTime.Year +
                   "\nKart ile ödeme işlemi tamamlandı.";

        }
    }
}
