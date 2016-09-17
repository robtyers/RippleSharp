namespace RippleSharp.Rippled.Models.Requests.AccountInformation
{
    public class AccountObjectsRequestParams
    {
        public string Account { get; set; }
        public string Type { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
        public int? Limit { get; set; }
        public string Marker { get; set; }
    }
}
