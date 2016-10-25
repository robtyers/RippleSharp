using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class JobTypePeakTime : IJobType
    {
        public string JobType { get; set; }
        public int PeakTime { get; set; }
    }
}
