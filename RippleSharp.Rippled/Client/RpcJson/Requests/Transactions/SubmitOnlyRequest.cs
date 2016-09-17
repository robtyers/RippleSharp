using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SubmitOnlyRequest : RpcJsonRequest<SubmitOnlyRequestParams>
    {
        public override string Method => ApiCommands.Submit;
    }
}
