using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Convenience;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Convenience
{
    public class StopRequest : RpcJsonRequest<StopRequestParams>
    {
        public override string Method => ApiMethod.Stop;
    }
}
