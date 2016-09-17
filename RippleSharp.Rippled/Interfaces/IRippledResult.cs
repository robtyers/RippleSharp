using RippleSharp.Rippled.Enums;

namespace RippleSharp.Rippled.Interfaces
{
    public interface IRippledResult
    {
        Status Status { get; set; }
        Error? Error { get; set; }
    }
}
