using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class ServerStateRequest : RpcJsonRequest<ServerStateRequestParams>
    {
        public override string Method => ApiCommands.ServerState;
    }
}
