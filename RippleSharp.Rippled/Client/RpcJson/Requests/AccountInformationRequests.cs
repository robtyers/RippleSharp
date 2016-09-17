using System.Threading.Tasks;
using RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation;
using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Models.Responses.AccountInformation;

namespace RippleSharp.Rippled.Client.RpcJson.Requests
{
    public class AccountInformationRequests : RequestBase
    {
        public AccountInformationRequests(IRippledClient client) : base(client) { }

        public async Task<RpcJsonResponse<AccountCurrencyResult>> AccountCurrenciesAsync (AccountCurrencyRequest request)
        {
            return await PostAsync<RpcJsonResponse<AccountCurrencyResult>, AccountCurrencyResult>(request);
        }

        public async Task<RpcJsonResponse<AccountInfoResult>> AccountInfoAsync (AccountInfoRequest request)
        {
            return await PostAsync<RpcJsonResponse<AccountInfoResult>, AccountInfoResult>(request);
        }

        public async Task<RpcJsonResponse<AccountLinesResult>> AccountLinesAsync (AccountLinesRequest request)
        {
            return await PostAsync<RpcJsonResponse<AccountLinesResult>, AccountLinesResult>(request);
        }

        public async Task<RpcJsonResponse<AccountOffersResult>> AccountOffersAsync (AccountOffersRequest request)
        {
            return await PostAsync<RpcJsonResponse<AccountOffersResult>, AccountOffersResult>(request);
        }

        public async Task<RpcJsonResponse<AccountObjectsResult>> AccountObjectsAsync (AccountObjectsRequest request)
        {
            return await PostAsync<RpcJsonResponse<AccountObjectsResult>, AccountObjectsResult>(request);
        }

        public async Task<RpcJsonResponse<AccountTxResult>> AccountTxAsync (AccountTxRequest request)
        {
            return await PostAsync<RpcJsonResponse<AccountTxResult>, AccountTxResult>(request);
        }

        public async Task<RpcJsonResponse<NorippleCheckResult>> NorippleCheckAsync (NorippleCheckRequest request)
        {
            return await PostAsync<RpcJsonResponse<NorippleCheckResult>, NorippleCheckResult>(request);
        }

        public async Task<RpcJsonResponse<GatewayBalancesResult>> GatewayBalancesAsync (GatewayBalancesRequest request)
        {
            return await PostAsync<RpcJsonResponse<GatewayBalancesResult>, GatewayBalancesResult>(request);
        }

        public async Task<RpcJsonResponse<WalletProposeResult>> WalletProposeAsync (WalletProposeRequest request)
        {
            return await PostAsync<RpcJsonResponse<WalletProposeResult>, WalletProposeResult>(request);
        }
    }
}
