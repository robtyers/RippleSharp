using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class ConsensusInfo
    {
        public Dictionary<string, string> Acquired { get; set; }
        public int LedgerSeq { get; set; }
        public IPosition OurPosition { get; set; }
        public Dictionary<string, IPosition> PeerPositions { get; set; }
        public int Proposers { get; set; }
        public bool Synched { get; set; }
        public string State { get; set; }
        public string Consensus { get; set; }
        public int? PreviousMseconds { get; set; }
        public int? PreviousProposers { get; set; }
        public bool? Proposing { get; set; }
        public bool Validating { get; set; }
    }
}
