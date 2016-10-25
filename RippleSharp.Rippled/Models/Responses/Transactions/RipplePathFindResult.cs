using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Models.Shared;

namespace RippleSharp.Rippled.Models.Responses.Transactions
{
    public class RipplePathFindResult : RippledResult
    {
        public List<Path> PathsComputed { get; set; }
        public IAmount SourceAmount { get; set; } 
    }
}
