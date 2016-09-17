namespace RippleSharp.Rippled.Models.Requests.Transactions
{
    public class SubmitOnlyRequestParams
    {
        public string TxBlob { get; set; }
        public bool FailHard { get; set; }
    }
}
