using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class WalletProposeRequest : RpcJsonRequest<WalletProposeRequestParams>
    {
        public override string Method => ApiCommands.WalletPropose;
    }
}
