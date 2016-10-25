using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountCurrencyRequest : RpcJsonRequest<AccountCurrencyRequestParams>
    {
        public override string Method => ApiMethod.AccountCurrencies;
    }
}
