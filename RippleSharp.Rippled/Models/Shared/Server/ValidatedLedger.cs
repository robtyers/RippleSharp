namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class ValidatedLedger
    {
        public int? BaseFee { get; set; }
        public float? BaseFeeXrp { get; set; }
        public int? CloseTime { get; set; }
        public string Hash { get; set; }
        public int? ReserveBase { get; set; }
        public float? ReserveBaseXrp { get; set; }
        public int? ReserveInc { get; set; }
        public int? Seq { get; set; }
    }
}
