using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Requests.Transactions
{
    public class BookOffersRequestParams
    {
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
        public int? Limit { get; set; }
        public string Taker { get; set; }
        public IAmount TakerGets { get; set; }
        public IAmount TakerPays { get; set; }
    }
}
