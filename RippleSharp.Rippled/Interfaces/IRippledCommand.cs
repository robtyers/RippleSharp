namespace RippleSharp.Rippled.Interfaces
{
    public interface IRippledCommand
    {
        string RawResponse { get; set; }
    }
}
