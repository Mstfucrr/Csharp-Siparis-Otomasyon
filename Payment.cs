namespace PROJECT
{
    abstract class Payment
    {
        public float Amount { get; set; }

        public virtual string Authorized()
        {
            return "";
        }

    }
}
