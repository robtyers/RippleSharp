namespace RippleSharp.Rippled.Models.Responses.Ledger
{
    public class LedgerClosedResult : RippledResult
    {
        public string LedgerHash { get; set; }
        public int LedgerIndex { get; set; }
    }
}
