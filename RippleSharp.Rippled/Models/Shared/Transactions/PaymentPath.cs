namespace RippleSharp.Rippled.Models.Shared.Transactions
{
    public class PaymentPath
    {
        public string Account { get; set; }
        public string Currency { get; set; }
        public string Issuer { get; set; }
    }
}
