using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class GetCountsRequest : RpcJsonRequest<GetCountsRequestParams>
    {
        public override string Method => ApiCommands.GetCounts;
    }
}
