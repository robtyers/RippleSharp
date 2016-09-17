using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.LedgerNode
{
    public class RippleState : ILedgerNode
    {
        public LedgerEntryType LedgerEntryType { get; set; }
        public int Flags { get; set; }
        public IAmount Balance { get; set; }
        public IAmount LowLimit { get; set; }
        public IAmount HighLimit { get; set; }
        public string PreviousTxnID { get; set; }
        public int PreviousTxnLgrSeq { get; set; }
        public string LowNode { get; set; }
        public string HighNode { get; set; }
        public int? LowQualityIn { get; set; }
        public int? LowQualityOut { get; set; }
        public int? HighQualityIn { get; set; }
        public int? HighQualityOut { get; set; }
    }
}
