using System.Collections.Generic;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class AccountCurrencyResult : RippledResult
    {
        public string LedgerHash { get; set; }
        public int LedgerIndex { get; set; }
        public IEnumerable<string> ReceiveCurrencies { get; set; }
        public IEnumerable<string> SendCurrencies { get; set; }
        public bool Validated { get; set; }
    }
}
