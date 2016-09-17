using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class FetchInfoRequest : RpcJsonRequest<FetchInfoRequestParams>
    {
        public override string Method => ApiCommands.FetchInfo;
    }
}
