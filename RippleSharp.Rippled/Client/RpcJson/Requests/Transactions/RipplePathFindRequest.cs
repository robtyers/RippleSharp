using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class RipplePathFindRequest : RpcJsonRequest<RipplePathFindRequestParams>
    {
        public override string Method => ApiMethod.RipplePathFind;
    }
}
