using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SubmitMultisignedRequest : RpcJsonRequest<SubmitMultisignedRequestParams>
    {
        public override string Method => ApiCommands.SubmitMultisigned;
    }
}
