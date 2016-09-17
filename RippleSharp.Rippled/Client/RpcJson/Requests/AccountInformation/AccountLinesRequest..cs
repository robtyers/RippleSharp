using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountLinesRequest : RpcJsonRequest<AccountLinesRequestParams>
    {
        public override string Method => ApiCommands.AccountLines;
    }
}
