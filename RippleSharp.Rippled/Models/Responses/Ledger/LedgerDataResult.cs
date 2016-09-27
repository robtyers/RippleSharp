using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses.Ledger
{
    public class LedgerDataResult : RippledResult
    {
        public int LedgerIndex { get; set; }
        public int LedgerCurrentIndex { get; set; }
        public string LedgerHash { get; set; }
        public IEnumerable<ILedgerNode> State { get; set; }
        public string Marker { get; set; }
        public bool Validated { get; set; }
    }
}
