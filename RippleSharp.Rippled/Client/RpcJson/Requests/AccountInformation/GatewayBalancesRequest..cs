using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class GatewayBalancesRequest : RpcJsonRequest<GatewayBalancesRequestParams>
    {
        public override string Method => ApiCommands.GatewayBalances;
    }
}
