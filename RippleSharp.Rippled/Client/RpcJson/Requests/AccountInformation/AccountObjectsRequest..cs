using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountObjectsRequest : RpcJsonRequest<AccountObjectsRequestParams>
    {
        public override string Method => ApiMethod.AccountObjects;
    }
}
