using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Convenience;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Convenience
{
    public class PingRequest : RpcJsonRequest<PingRequestParams>
    {
        public override string Method => ApiMethod.Ping;
    }
}
