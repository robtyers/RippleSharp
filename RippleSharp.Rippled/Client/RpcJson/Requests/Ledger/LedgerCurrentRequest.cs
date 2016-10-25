using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Ledger;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerCurrentRequest : RpcJsonRequest<LedgerCurrentRequestParams>
    {
        public override string Method => ApiMethod.LedgerCurrent;
    }
}
