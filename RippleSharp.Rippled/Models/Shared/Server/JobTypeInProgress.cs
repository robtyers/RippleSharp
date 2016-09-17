using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class JobTypeInProgress : IJobType
    {
        public string JobType { get; set; }
        public int InProgress { get; set; }
    }
}
