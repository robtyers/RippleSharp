namespace RippleSharp.Rippled.Models.Requests.AccountInformation
{
    public class AccountLinesRequestParams
    {
        public string Account { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
        public string Peer { get; set; }
        public int? Limit { get; set; }
        public string Marker { get; set; }
    }
}
