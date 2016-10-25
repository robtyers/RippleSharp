namespace RippleSharp.Rippled.Models.Responses.Server
{
    public class GetCountsResult : RippledResult
    {
        public decimal? ALHitRate { get; set; }
        public int? HashRouterEntry { get; set; }
        public int? Ledger { get; set; }
        public int? NodeObject { get; set; }
        public decimal? SLEHitRate { get; set; }
        public int? STArray { get; set; }
        public int? STLedgerEntry { get; set; }
        public int? STObject { get; set; }
        public int? STTx { get; set; }
        public int? STValidation { get; set; }
        public int? Transaction { get; set; }
        public int? DbKBLedger { get; set; }
        public int? DbKBTotal { get; set; }
        public int? DbKBTransaction { get; set; }
        public int? FullbelowSize { get; set; }
        public int? HistoricalPerminute { get; set; }
        public decimal? LedgerHitRate { get; set; }
        public decimal? NodeHitRate { get; set; }
        public int? NodeReadBytes { get; set; }
        public int? Node_reads_hit { get; set; }
        public int? Node_reads_total { get; set; }
        public int? Node_writes { get; set; }
        public int? Node_written_bytes { get; set; }
        //public string Status { get; set; }
        public int? TreenodeCacheSize { get; set; }
        public int? TreenodeTrackSize { get; set; }
        public string Uptime { get; set; }
        public int? WriteLoad { get; set; }
    }
}
