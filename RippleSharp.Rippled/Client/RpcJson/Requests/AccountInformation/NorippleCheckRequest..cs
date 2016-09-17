using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class NorippleCheckRequest : RpcJsonRequest<NorippleCheckRequestParams>
    {
        public override string Method => ApiCommands.NoRippleCheck;
    }
}
