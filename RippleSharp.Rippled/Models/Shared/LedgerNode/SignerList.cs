using System.Collections.Generic;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.LedgerNode
{
    public class SignerList : ILedgerNode
    {
        public LedgerEntryType LedgerEntryType { get; set; }
        public uint Flags { get; set; }
        public string OwnerNode { get; set; }
        public uint SignerQuorum { get; set; }
        public IEnumerable<SignerEntry> SignerEntries { get; set; }
        public uint SignerListID { get; set; }
        public string PreviousTxnID { get; set; }
        public uint PreviousTxnLgrSeq { get; set; }
    }
}
