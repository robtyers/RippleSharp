namespace RippleSharp.Rippled.Models.Requests.Ledger
{
    public class LedgerEntryRequestParams
    {
        public string AccountRoot { get; set; }
        public string LedgerIndex { get; set; }
        public string Type { get; set; }
    }
}
