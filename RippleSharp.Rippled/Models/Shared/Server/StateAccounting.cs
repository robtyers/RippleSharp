namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class StateAccounting
    {
        public ServerTime Connected { get; set; }
        public ServerTime Disconnected { get; set; }
        public ServerTime Full { get; set; }
        public ServerTime Syncing { get; set; }
        public ServerTime Tracking { get; set; }
    }
}
