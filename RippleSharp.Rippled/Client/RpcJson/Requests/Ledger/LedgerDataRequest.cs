using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Ledger;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerDataRequest : RpcJsonRequest<LedgerDataRequestParams>
    {
        public override string Method => ApiCommands.LedgerData;
    }
}
