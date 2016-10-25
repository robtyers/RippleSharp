using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountInfoRequest : RpcJsonRequest<AccountInfoRequestParams>
    {
        public override string Method => ApiMethod.AccountInfo;
    }
}
