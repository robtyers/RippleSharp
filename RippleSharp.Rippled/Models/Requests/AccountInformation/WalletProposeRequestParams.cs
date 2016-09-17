namespace RippleSharp.Rippled.Models.Requests.AccountInformation
{
    public class WalletProposeRequestParams
    {
        public string KeyType { get; set; }
        public string PassPhrase { get; set; }
        public string Seed { get; set; }
        public string SeedHex { get; set; }
    }
}
