namespace RippleSharp.Rippled.Models.Shared
{
    public class TrustLine
    {
        public string Account { get; set; }
        public string Balance { get; set; }
        public string Currency { get; set; }
        public string Limit { get; set; }
        public string LimitPeer { get; set; }
        public int? QualityIn { get; set; }
        public int? QualityOut { get; set; }
        public bool? NoRipple { get; set; }
        public bool? NoRipplePeer { get; set; }
        public bool? Freeze { get; set; }
        public bool? FreezePeer { get; set; }
    }
}
