namespace RippleSharp.Rippled.Models.Shared.Transactions
{
    public class SetFee : TransactionBase
    {
        public string BaseFee { get; set; }
        public int ReferenceFeeUnits { get; set; }
        public int ReserveBase { get; set; }
        public int ReserveIncrement { get; set; }
        public int LedgerSequence { get; set; }
    }
}
