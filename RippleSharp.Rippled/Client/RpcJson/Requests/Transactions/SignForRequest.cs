using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SignForRequest : RpcJsonRequest<SignForRequestParams>
    {
        public override string Method => ApiCommands.SignFor;
    }
}
