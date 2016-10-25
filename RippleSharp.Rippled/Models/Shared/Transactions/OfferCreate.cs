using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Transactions
{
    public class OfferCreate : TransactionBase
    {
        public int? Expiration { get; set; }
        public int? OfferSequence { get; set; }
        public IAmount TakerGets { get; set; }
        public IAmount TakerPays { get; set; }
    }
}
