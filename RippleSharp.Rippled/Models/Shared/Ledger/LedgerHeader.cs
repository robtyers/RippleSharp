using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Ledger
{
    public class LedgerHeader
    {
        public string AccountHash { get; set; }
        public IEnumerable<ILedgerNode> Accounts { get; set; } // ToDo: Check this
        public int CloseTime { get; set; }
        public string CloseTimeHuman { get; set; }
        public int CloseTimeResolution { get; set; }
        public bool Closed { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
        public string ParentHash { get; set; }
        public string TotalCoins { get; set; }
        public string TransactionHash { get; set; }
        public IEnumerable<string> Transactions  { get; set; } // ToDo: Check this
    }
}
