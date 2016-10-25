using System.Collections.Generic;
using RippleSharp.Rippled.Enums;

namespace RippleSharp.Rippled.Models.Shared.Transactions
{
    public class Meta
    {
        public IEnumerable<dynamic> AffectedNodes { get; set; } 
        public string TransactionIndex { get; set; }
        public TesResult TransactionResult { get; set; }
    }
}
