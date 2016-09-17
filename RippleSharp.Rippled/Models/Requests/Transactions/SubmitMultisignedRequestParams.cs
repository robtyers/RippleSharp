using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Requests.Transactions
{
    public class SubmitMultisignedRequestParams
    {
        public ITransaction TxJson { get; set; }
        public bool FailHard { get; set; }
    }
}
