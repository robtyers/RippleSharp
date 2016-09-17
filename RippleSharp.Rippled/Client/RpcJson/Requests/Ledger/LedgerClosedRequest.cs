using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Ledger;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerClosedRequest : RpcJsonRequest<LedgerClosedRequestParams>
    {
        public override string Method => ApiCommands.LedgerClosed;
    }
}
