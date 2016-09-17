using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Responses
{
    public class RippledResult : IRippledResult
    {
        public Status Status { get; set; }
        public Error? Error { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
