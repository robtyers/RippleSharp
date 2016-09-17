namespace RippleSharp.Rippled.Models.Requests.Server
{
    public class FeatureRequestParams
    {
        public string Feature { get; set; }
        public bool Vetoed { get; set; }
    }
}
