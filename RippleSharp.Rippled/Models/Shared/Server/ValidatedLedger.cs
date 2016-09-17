namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class ValidatedLedger
    {
        public int BaseFee { get; set; }
        public int CloseTime { get; set; }
        public string Hash { get; set; }
        public int ReserveBase { get; set; }
        public int ReserveInc { get; set; }
    }
}
