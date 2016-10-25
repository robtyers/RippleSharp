using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Convenience;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Convenience
{
    public class ConnectRequest : RpcJsonRequest<ConnectRequestParams>
    {
        public override string Method => ApiMethod.Connect;
    }
}
