using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class AccountObjectsResult : RippledResult
    {
        public string Account { get; set; }
        public IEnumerable<ILedgerNode> AccountObjects { get; set; }
        public string LedgerHash { get; set; }
        public int? LedgerIndex { get; set; }
        public int? LedgerCurrentIndex { get; set; }
        public int? Limit { get; set; }
        public object Marker { get; set; }
        public bool Validated { get; set; }
    }
}
