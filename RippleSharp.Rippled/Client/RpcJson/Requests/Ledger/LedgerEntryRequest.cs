using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Ledger;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerEntryRequest : RpcJsonRequest<LedgerEntryRequestParams>
    {
        public override string Method => ApiCommands.LedgerEntry;
    }
}
