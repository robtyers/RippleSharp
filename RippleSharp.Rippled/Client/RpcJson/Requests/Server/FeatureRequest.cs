using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class FeatureRequest : RpcJsonRequest<FeatureRequestParams>
    {
        public override string Method => ApiMethod.Feature;
    }
}
