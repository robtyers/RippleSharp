using System.Collections.Generic;
using RippleSharp.Rippled.Models.Shared.Transactions;

namespace RippleSharp.Rippled.Models.Responses.Transactions
{
    public class BookOffersResult
    {
        public int? LedgerCurrentIndex { get; set; }
        public int? LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public List<BookOffer> Offers { get; set; }
    }
}
