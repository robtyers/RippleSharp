using RippleSharp.Rippled.Enums;

namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class State
    {
        public string BuildVersion { get; set; }
        public string CompleteLedgers { get; set; }
        public int IoLatencyMs { get; set; }
        public Load Load { get; set; }
        public int LoadBase { get; set; }
        public int LoadFactor { get; set; }
        public int? LoadFactorFeeEscalation { get; set; }
        public int? LoadFactorFeeQueue { get; set; }
        public int? LoadFactorFeeReference { get; set; }
        public int Peers { get; set; }
        public string PubkeyNode { get; set; }
        public string PubkeyValidator { get; set; }
        public ServerState ServerState { get; set; }
        public StateAccounting StateAccounting { get; set; }
        public int Uptime { get; set; }
        public ValidatedLedger ValidatedLedger { get; set; }
        public int ValidationQuorum { get; set; }
    }
}
