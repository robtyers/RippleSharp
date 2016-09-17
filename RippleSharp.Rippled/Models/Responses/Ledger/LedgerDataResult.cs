using System.Collections.Generic;
using RippleSharp.Rippled.Models.Shared.Ledger;

namespace RippleSharp.Rippled.Models.Responses.Ledger
{
    public class LedgerDataResult : RippledResult
    {
        public int LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public IEnumerable<LedgerState> State { get; set; }
        public object Marker { get; set; }
    }
}
