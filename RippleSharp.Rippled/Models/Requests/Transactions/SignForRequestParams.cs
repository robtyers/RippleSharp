using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Requests.Transactions
{
    public class SignForRequestParams
    {
        public string Account { get; set; }
        public ITransaction TxJson { get; set; }
        public string Secret { get; set; }
        public string Passphrase { get; set; }
        public string Seed { get; set; }
        public string SeedHex { get; set; }
        public string KeyType { get; set; }
    }
}
