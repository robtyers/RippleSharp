namespace RippleSharp.Rippled.Models.Shared.Transactions
{
    public class AccountSet : TransactionBase
    {
        public int? ClearFlag { get; set; }
        public string Domain { get; set; }
        public string EmailHash { get; set; }
        public string MessageKey { get; set; }
        public int? SetFlag { get; set; }
        public int? TransferRate { get; set; }
        public string WalletLocator { get; set; }
        public int? WalletSize { get; set; }
    }
}
