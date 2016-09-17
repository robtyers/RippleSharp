using System.Collections.Generic;
using RippleSharp.Rippled.Models.Shared.Server;

namespace RippleSharp.Rippled.Models.Responses.Server
{
    public class FeatureResult : RippledResult
    {
        public Dictionary<string, Feature> Result { get; set; }
    }
}
