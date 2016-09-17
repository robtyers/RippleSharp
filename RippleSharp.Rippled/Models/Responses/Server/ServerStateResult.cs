using RippleSharp.Rippled.Models.Shared.Server;

namespace RippleSharp.Rippled.Models.Responses.Server
{
    public class ServerStateResult : RippledResult
    {
        public State State { get; set; }
    }
}
