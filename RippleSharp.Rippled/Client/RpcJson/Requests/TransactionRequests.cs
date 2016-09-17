using System.Threading.Tasks;
using RippleSharp.Rippled.Client.RpcJson.Requests.Transactions;
using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Models.Responses.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests
{
    public class TransactionRequests : RequestBase
    {
        public TransactionRequests(IRippledClient client) : base(client) { }

        public async Task<RpcJsonResponse<TxResult>> TxAsync (TxRequest request)
        {
            return await PostAsync<RpcJsonResponse<TxResult>, TxResult>(request);
        }

        public async Task<RpcJsonResponse<TransactionEntryResult>> TransactionEntryAsync(TransactionEntryRequest request)
        {
            return await PostAsync<RpcJsonResponse<TransactionEntryResult>, TransactionEntryResult>(request);
        }

        public async Task<RpcJsonResponse<SignResult>> SignAsync(SignRequest request)
        {
            return await PostAsync<RpcJsonResponse<SignResult>, SignResult>(request);
        }

        public async Task<RpcJsonResponse<SignResult>> SignForAsync(SignForRequest request)
        {
            return await PostAsync<RpcJsonResponse<SignResult>, SignResult>(request);
        }

        public async Task<RpcJsonResponse<SubmitResult>> SubmitOnlyAsync(SubmitOnlyRequest request)
        {
            return await PostAsync<RpcJsonResponse<SubmitResult>, SubmitResult>(request);
        }

        public async Task<RpcJsonResponse<SubmitResult>> SubmitMultisignedAsync(SubmitMultisignedRequest request)
        {
            return await PostAsync<RpcJsonResponse<SubmitResult>, SubmitResult>(request);
        }

        public async Task<RpcJsonResponse<BookOffersResult>> BookOffersAsync(BookOffersRequest request)
        {
            return await PostAsync<RpcJsonResponse<BookOffersResult>, BookOffersResult>(request);
        }
    }
}
