using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses.Transactions
{
    public class SubmitResult
    {
        public string EngineResult { get; set; } // ToDo: Enum?
        public int EngineResultCode { get; set; }
        public string EngineResultMessage { get; set; }
        public string TxBlob { get; set; }
        public ITransaction TxJson { get; set; }
    }
}
