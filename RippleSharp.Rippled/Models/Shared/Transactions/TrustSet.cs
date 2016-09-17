using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Transactions
{
    public class TrustSet : TransactionBase
    {
        public IAmount LimitAmount { get; set; }
        public int? QualityIn { get; set; }
        public int? QualityOut { get; set; }
    }
}
