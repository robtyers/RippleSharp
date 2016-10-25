using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class FeeRequest : RpcJsonRequest<FeeRequestParams>
    {
        public override string Method => ApiMethod.Fee;
    }
}
