using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class TxRequest : RpcJsonRequest<TxRequestParams>
    {
        public override string Method => ApiCommands.Tx;
    }
}
