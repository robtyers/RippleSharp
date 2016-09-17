namespace RippleSharp.Rippled.Models.Requests.Ledger
{
    public class LedgerRequestParams
    {
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
        public bool Full { get; set; }
        public bool Accounts { get; set; }
        public bool Transactions { get; set; }
        public bool Expand { get; set; }
        public bool OwnerFunds { get; set; }
        public bool Binary { get; set; }
    }
}
