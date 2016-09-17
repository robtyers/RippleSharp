namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class Feature
    {
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public bool Supported { get; set; }
        public bool Vetoed { get; set; }
    }
}
