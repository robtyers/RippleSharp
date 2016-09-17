using RippleSharp.Rippled.Enums;

namespace RippleSharp.Rippled.Models.Shared.Ledger
{
    public class LedgerState
    {
        public string Data { get; set; }
        public LedgerEntryType LedgerEntryType { get; set; }
        public string Index { get; set; }
    }
}
