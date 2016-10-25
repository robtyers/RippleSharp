using RippleSharp.Rippled.Enums;

namespace RippleSharp.Rippled.Interfaces
{
    public interface ITransaction : IDefaultResolver
    {
        TransactionNodeType TransactionType { get; set; }
    }
}
