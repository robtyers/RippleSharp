using System.Collections.Generic;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class AccountOffersResult : RippledResult
    {
        public string Account { get; set; }
        public IEnumerable<AccountOffers> Offers { get; set; }
        public int? LedgerCurrentIndex { get; set; }
        public int? LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public object Marker { get; set; }
    }
}
