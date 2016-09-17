using RippleSharp.Rippled.Enums;

namespace RippleSharp.Rippled.Interfaces
{
    public interface ILedgerNode : IDefaultResolver
    {
        LedgerEntryType LedgerEntryType { get; set; }
    }
}
