using System.Collections.Generic;
using RippleSharp.Rippled.Models.Shared;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class AccountLinesResult : RippledResult
    {
        public string Account { get; set; }
        public IEnumerable<TrustLine> Lines { get; set; }
        public int? LedgerCurrentIndex { get; set; }
        public int? LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public object Marker { get; set; }
    }
}
