using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.LedgerNode
{
    public class AccountRoot : ILedgerNode
    {
        public LedgerEntryType LedgerEntryType { get; set; }
        public string Account { get; set; }
        public int Flags { get; set; }
        public int Sequence { get; set; }
        public string Balance { get; set; }
        public int OwnerCount { get; set; }
        public string PreviousTxnID { get; set; }
        public int PreviousTxnLgrSeq { get; set; }
        public string AccountTxnID { get; set; }
        public string RegularKey { get; set; }
        public string EmailHash { get; set; }
        public string MessageKey { get; set; }
        public int? TransferRate { get; set; }
        public string Domain { get; set; }
        public string Index { get; set; }
    }
}
