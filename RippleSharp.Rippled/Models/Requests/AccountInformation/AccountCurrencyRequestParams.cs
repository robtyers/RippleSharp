namespace RippleSharp.Rippled.Models.Requests.AccountInformation
{
    public class AccountCurrencyRequestParams 
    {
        public string Account { get; set; }
        public bool Strict { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
    }
}
