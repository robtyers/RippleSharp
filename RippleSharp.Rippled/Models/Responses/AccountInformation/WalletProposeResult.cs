namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class WalletProposeResult : RippledResult
    {
        public string MasterSeed { get; set; }
        public string MastSeedHex { get; set; }
        public string MasterKey { get; set; }
        public string AccountId { get; set; }
        public string PublicKey { get; set; }
        public string PublicKeyHex { get; set; }
        public string Warning { get; set; }
    }
}
