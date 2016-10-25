namespace RippleSharp.Rippled.Constants
{
    public static class JobType
    {
        public const string AcceptLedger = "acceptLedger";
        public const string DiskAccess = "diskAccess";
        public const string UntrustedProposal = "untrustedProposal";
        public const string ClientCommand = "clientCommand";
        public const string WriteObjects = "writeObjects";
        public const string TrustedProposal = "trustedProposal";
        public const string PeerCommand = "peerCommand";
        public const string WriteNode = "WriteNode";
    }
}
