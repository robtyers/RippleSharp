using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Models.Shared;

namespace RippleSharp.Rippled.Models.Requests.Transactions
{
    public class RipplePathFindRequestParams
    {
        public string SourceAccount { get; set; }
        public string DestinationAccount { get; set; }
        public IAmount DestinationAmount { get; set; }
        public IAmount SendMax { get; set; }
        public List<CurrencyIssuer> SourceCurrencies { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
    }
}
