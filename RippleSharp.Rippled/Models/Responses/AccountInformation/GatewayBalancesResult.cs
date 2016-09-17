using System.Collections.Generic;
using RippleSharp.Rippled.Models.Shared;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class GatewayBalancesResult : RippledResult
    {
        public string Account { get; set; }
        public IDictionary<string, decimal> Obligations { get; set; }
        public IDictionary<string, IEnumerable<CurrencyValue>> Balances { get; set; }
        public IDictionary<string, IEnumerable<CurrencyValue>> Assets { get; set; }
        public string LedgerHash { get; set; }
        public int? LedgerIndex { get; set; }
        public int? LedgerCurrentIndex { get; set; }
    }
}
