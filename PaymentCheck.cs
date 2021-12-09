namespace PROJECT
{
    class PaymentCheck:Payment
    {
        public string checkOwner { get; set; }
        public ulong bankId { get; set; }

        public override string Authorized()
        {
            return "Çek Bilgileri" +
                   "\n\tsahibi : " + this.checkOwner +
                   "\n\tBanka numarası : " + this.bankId;

        }

    }
}
