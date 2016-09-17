using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SignAndSubmitRequest : RpcJsonRequest<SignAndSubmitRequestParams>
    {
        public override string Method => ApiCommands.Submit;
    }
}
