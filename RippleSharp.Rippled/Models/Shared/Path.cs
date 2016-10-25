namespace RippleSharp.Rippled.Models.Shared
{
    public class Path
    {
        public string Account { get; set; }
        public string Currency { get; set; }
        public string Issuer { get; set; }
        public int? Type { get; set; }
        public string TypeHex { get; set; }
    }
}
