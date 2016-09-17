using System.Collections.Generic;

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
        public IEnumerable<object> Transactions { get; set; } // ToDo: This is a tx object
        public bool Validated { get; set; }
    }
}
