using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Ledger;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerRequest : RpcJsonRequest<LedgerRequestParams>
    {
        public override string Method => ApiMethod.Ledger;
    }
}
