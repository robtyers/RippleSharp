using System.Collections.Generic;
using RippleSharp.Rippled.Models.Shared.AccountInformation;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class AccountTxResult : RippledResult
    {
        public string Account { get; set; }
        public int LedgerIndexMin { get; set; }
        public int LedgerIndexMax { get; set; }
        public int Limit { get; set; }
        public object Marker { get; set; }
        public int Offset { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
        public bool Validated { get; set; }
    }
}
