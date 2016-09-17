using RippleSharp.Rippled.Models.Shared.Ledger;

namespace RippleSharp.Rippled.Models.Responses.Ledger
{
    public class LedgerResult : RippledResult
    {
        public LedgerHeader Ledger { get; set; }
        public string LedgerHash { get; set; }
        public int LedgerIndex { get; set; }
    }
}
