using System.Collections.Generic;
using RippleSharp.Rippled.Models.Shared.Transactions;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses.Transactions
{
    public class TxResult
    {
        public string LedgerIndex { get; set; }
        public string Hash { get; set; }
        public IEnumerable<Meta> Meta { get; set; }
        public ITransaction TxJson { get; set; }
    }
}
