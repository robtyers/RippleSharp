using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Requests.Transactions
{
    public class SignAndSubmitRequestParams
    {
        public ITransaction TxJson { get; set; }
        public string Secret { get; set; }
        public string Seed { get; set; }
        public string SeedHex { get; set; }
        public string Passphrase { get; set; }
        public string KeyType { get; set; }
        public bool FailHard { get; set; }
        public bool Offline { get; set; }
        public bool BuildPath { get; set; }
        public int FeeMultMax { get; set; }
        public int FeeDivMax { get; set; }
    }
}
