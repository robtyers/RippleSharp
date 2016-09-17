using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class ServerInfoRequest : RpcJsonRequest<ServerInfoRequestParams>
    {
        public override string Method => ApiCommands.ServerInfo;
    }
}
