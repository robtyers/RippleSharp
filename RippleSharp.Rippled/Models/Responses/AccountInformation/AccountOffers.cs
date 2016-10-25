using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class AccountOffers
    {
        public int Flags { get; set; }
        public int Seq { get; set; }
        public IAmount TakerGets { get; set; }
        public IAmount TakerPays { get; set; }
        public float Quality { get; set; }
        public int Expiration { get; set; }
    }
}
