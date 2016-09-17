using RippleSharp.Rippled.Models.Shared.Server;

namespace RippleSharp.Rippled.Models.Responses.Server
{
    public class ConsensusInfoResult : RippledResult
    {
        public ConsensusInfo Info { get; set; } 
    }
}
