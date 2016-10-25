namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class Position
    {
        public int CloseTime { get; set; }
        public string PreviousLedger { get; set; }
        public int ProposeSeq { get; set; }
        public string TransactionHash { get; set; }
        public string PeerId { get; set; }
    }
}
