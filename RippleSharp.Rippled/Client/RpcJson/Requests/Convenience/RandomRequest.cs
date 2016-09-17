using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Convenience;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Convenience
{
    public class RandomRequest : RpcJsonRequest<RandomRequestParams>
    {
        public override string Method => ApiCommands.Random;
    }
}
