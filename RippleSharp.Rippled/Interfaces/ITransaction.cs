using RippleSharp.Rippled.Enums;

namespace RippleSharp.Rippled.Interfaces
{
    public interface ITransaction : IDefaultResolver
    {
        TransactionType TransactionType { get; set; }
    }
}
