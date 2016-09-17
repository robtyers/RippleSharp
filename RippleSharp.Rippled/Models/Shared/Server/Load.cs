using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Server
{
    public class Load
    {
        public List<IJobType> JobTypes { get; set; }
        public int Threads { get; set; }
    }
}
