namespace RippleSharp.Rippled.Models.Responses.Server
{
    public class ValidationCreateResult : RippledResult
    {
        public string ValidationKey { get; set; }
        public string ValidationPublicKey { get; set; }
        public string ValidationSeed { get; set; }
    }
}
