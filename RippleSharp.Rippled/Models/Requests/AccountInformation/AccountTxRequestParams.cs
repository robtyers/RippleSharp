namespace RippleSharp.Rippled.Models.Requests.AccountInformation
{
    public class AccountTxRequestParams
    {
        public string Account { get; set; }
        public int LedgerIndexMin { get; set; }
        public int LedgerIndexMax { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
        public bool Binary { get; set; }
        public bool Forward { get; set; }
        public int? Limit { get; set; }
        public string Marker { get; set; }
    }
}
