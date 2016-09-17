using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class CanDeleteRequest : RpcJsonRequest<CanDeleteRequestParams>
    {
        public override string Method => ApiCommands.CanDelete;
    }
}
