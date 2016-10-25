namespace RippleSharp.Rippled.Constants
{
    public static class ApiMethod
    {
        // Accounts
        public const string AccountCurrencies = "account_currencies";
        public const string AccountInfo = "account_info";
        public const string AccountLines = "account_lines";
        public const string AccountOffers = "account_offers";
        public const string AccountObjects = "account_objects";
        public const string AccountTx = "account_tx";
        public const string NoRippleCheck = "noripple_check";
        public const string GatewayBalances = "gateway_balances";
        public const string WalletPropose = "wallet_propose";
        
        // Convenience
        public const string Ping = "ping";
        public const string Random = "random";
        public const string Connect = "connect";
        public const string Stop = "stop";

        // Ledger
        public const string Ledger = "ledger";
        public const string LedgerClosed = "ledger_closed";
        public const string LedgerCurrent = "ledger_current";
        public const string LedgerData = "ledger_data";
        public const string LedgerEntry = "ledger_entry";

        // Server
        public const string CanDelete = "can_delete";
        public const string ConsensusInfo = "consensus_info";
        public const string Fee = "fee";
        public const string Feature = "feature";
        public const string FetchInfo = "fetch_info";
        public const string GetCounts = "get_counts";
        public const string ServerInfo = "server_info";
        public const string ServerState = "server_state";
        public const string ValidationCreate = "validation_create";
        
        // Transactions
        public const string Tx = "tx";
        public const string TransactionEntry = "transaction_entry";
        public const string RipplePathFind = "ripple_path_find";
        public const string Sign = "sign";
        public const string SignFor = "sign_for";
        public const string Submit = "submit";
        public const string SubmitMultisigned = "submit_multisigned";
        public const string BookOffers = "book_offers";
    }
}
