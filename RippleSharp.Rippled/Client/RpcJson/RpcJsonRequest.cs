using System.Collections.Generic;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Client.RpcJson
{
    public abstract class RpcJsonRequest<TParams> : IRippledRequest 
        where TParams : class
    {
        protected RpcJsonRequest()
        {
            Params = new List<TParams>();
        }

        public virtual string Method { get; }
        public List<TParams> Params { get; }
    }
}
