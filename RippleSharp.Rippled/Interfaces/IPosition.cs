namespace RippleSharp.Rippled.Interfaces
{
    public interface IPosition
    {
        int CloseTime { get; set; }
        string PreviousLedger { get; set; }
        int ProposeSeq { get; set; }
        string TransactionHash { get; set; }
    }
}
