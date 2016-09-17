using System.Collections.Generic;

namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class FetchInfo
    {
        public string Hash { get; set; }
        public bool HaveHeader { get; set; }
        public bool HaveTransactions { get; set; }
        public List<string> NeededStateHashes { get; set; }
        public int Peers { get; set; }
        public int Timeouts { get; set; }
    }
}
