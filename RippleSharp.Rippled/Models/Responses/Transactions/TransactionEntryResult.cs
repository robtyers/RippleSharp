using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Models.Shared.Transactions;

namespace RippleSharp.Rippled.Models.Responses.Transactions
{
    public class TransactionEntryResult : RippledResult
    {
        public string LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public Meta Metadata { get; set; }
        public ITransaction TxJson { get; set; }
    }
}
