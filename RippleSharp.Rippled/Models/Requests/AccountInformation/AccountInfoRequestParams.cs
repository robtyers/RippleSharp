namespace RippleSharp.Rippled.Models.Requests.AccountInformation
{
    public class AccountInfoRequestParams
    {
        public string Account { get; set; }
        public bool Strict { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
        public bool SignerLists { get; set; }
    }
}