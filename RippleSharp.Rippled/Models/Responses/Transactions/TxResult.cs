using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses.Transactions
{
    public class TxResult : RippledResult
    {
        public string LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public object Metadata { get; set; } // ToDo: what is this?
        public ITransaction TxJson { get; set; }
    }
}
