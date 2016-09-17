namespace RippleSharp.Rippled.Models.Requests.Ledger
{
    public class LedgerDataRequestParams
    {
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
        public bool Binary { get; set; }
        public int? Limit { get; set; }
        public object Marker { get; set; }
    }
}
