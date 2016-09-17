using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses.Ledger
{
    public class LedgerEntryResult : RippledResult
    {
        public string Index { get; set; }
        public string LedgerIndex { get; set; }
        public ILedgerNode Node { get; set; }
        public string NodeBinary { get; set; }
    }
}
