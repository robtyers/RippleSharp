using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class ConsensusInfoRequest : RpcJsonRequest<ConsensusInfoRequestParams>
    {
        public override string Method => ApiMethod.ConsensusInfo;
    }
}
