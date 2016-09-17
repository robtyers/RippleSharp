namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class AccountOffers
    {
        public int Flags { get; set; }
        public int Seq { get; set; }
        public object TakerGets { get; set; } // ToDo: What is this?
        public object TakerPays { get; set; } // ToDo: What is this?
        public decimal Quality { get; set; }
        public int Expiration { get; set; }
    }
}
