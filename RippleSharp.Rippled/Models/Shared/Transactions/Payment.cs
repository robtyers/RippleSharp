using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Transactions
{
    public class Payment : TransactionBase
    {
        public IAmount Amount { get; set; }
        public string Destination { get; set; }
        public int? DestinationTag { get; set; }
        public string InvoiceID { get; set; }
        public IEnumerable<Path> Paths { get; set; }
        public IAmount SendMax { get; set; }
        public IAmount DeliverMin { get; set; }
    }
}
