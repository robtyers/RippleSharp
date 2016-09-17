using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountOffersRequest : RpcJsonRequest<AccountOffersRequestParams>
    {
        public override string Method => ApiCommands.AccountOffers;
    }
}
