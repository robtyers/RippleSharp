using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses.Transactions
{
    public class TransactionEntryResult : RippledResult
    {
        public string LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public object Metadata { get; set; }
        public ITransaction TxJson { get; set; }
    }
}
