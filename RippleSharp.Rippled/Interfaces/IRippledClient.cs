using System.Threading.Tasks;
using RippleSharp.Rippled.Client.RpcJson.Requests;

namespace RippleSharp.Rippled.Interfaces
{
    public interface IRippledClient
    {
        AccountInformationRequests AccountInformation { get; }
        LedgerRequests Ledger { get; }
        TransactionRequests Transactions { get; }
      
        Task<bool> ConnectedAsync();
        Task<string> PostAsync(IRippledRequest request);
    }
}
