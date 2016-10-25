namespace RippleSharp.Rippled.Models.Requests.Transactions
{
    public class TransactionEntryRequestParams
    {
        public string LedgerHash { get; set; }
        public int LedgerIndex { get; set; }
        public string TxHash { get; set; }
    }
}
