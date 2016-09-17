using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class Position : IPosition
    {
        public int CloseTime { get; set; }
        public string PreviousLedger { get; set; }
        public int ProposeSeq { get; set; }
        public string TransactionHash { get; set; }
    }
}
