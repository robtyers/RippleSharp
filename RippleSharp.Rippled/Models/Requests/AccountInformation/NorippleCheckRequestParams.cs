namespace RippleSharp.Rippled.Models.Requests.AccountInformation
{
    public class NorippleCheckRequestParams
    {
        public string Account { get; set; }
        public string Role { get; set; }
        public bool Transactions { get; set; }
        public int Limit { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
    }
}
