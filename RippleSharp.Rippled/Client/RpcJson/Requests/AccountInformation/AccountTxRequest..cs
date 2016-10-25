using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountTxRequest : RpcJsonRequest<AccountTxRequestParams>
    {
        public override string Method => ApiMethod.AccountTx;
    }
}
