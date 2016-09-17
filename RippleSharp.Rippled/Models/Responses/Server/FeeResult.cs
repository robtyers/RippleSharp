using RippleSharp.Rippled.Models.Shared.Server;

namespace RippleSharp.Rippled.Models.Responses.Server
{
    public class FeeResult
    {
        public string CurrentLedgerSize { get; set; }
        public string CurrentQueueSize { get; set; }
        public Drops Drops { get; set; }
        public string ExpectedLedgerSize { get; set; }
        public Levels Levels { get; set; }
        public string MaxQueueSize { get; set; }
    }
}
