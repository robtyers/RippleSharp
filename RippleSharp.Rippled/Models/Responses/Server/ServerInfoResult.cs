using RippleSharp.Rippled.Models.Shared.Server;

namespace RippleSharp.Rippled.Models.Responses.Server
{
    public class ServerInfoResult : RippledResult
    {
        public ServerInfo Info { get; set; }
    }
}
