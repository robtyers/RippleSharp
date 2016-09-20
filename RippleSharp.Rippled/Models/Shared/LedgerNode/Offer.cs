using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.LedgerNode
{
    public class Offer : ILedgerNode
    {
        public LedgerEntryType LedgerEntryType { get; set; }
        public int Flags { get; set; }
        public string Account { get; set; }
        public int Sequence { get; set; }
        public CurrencyIssuerValue TakerPays { get; set; }
        public CurrencyIssuerValue TakerGets { get; set; }
        public string BookDirectory { get; set; }
        public string BookNode { get; set; }
        public string OwnerNode { get; set; }
        public string PreviousTxnID { get; set; }
        public int PreviousTxnLgrSeq { get; set; }
        public int? Expiration { get; set; }
    }
}
