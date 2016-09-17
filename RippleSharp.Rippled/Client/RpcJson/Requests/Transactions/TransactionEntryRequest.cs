using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class TransactionEntryRequest : RpcJsonRequest<TransactionEntryRequestParams>
    {
        public override string Method => ApiCommands.TransactionEntry;
    }
}
