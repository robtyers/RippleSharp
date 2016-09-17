using System.Threading.Tasks;
using RippleSharp.Rippled.Client.RpcJson.Requests.Server;
using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Models.Responses.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests
{
    public class ServerRequests : RequestBase
    {
        public ServerRequests(IRippledClient client) : base(client) { }

        public async Task<RpcJsonResponse<CanDeleteResult>> CanDeleteAsync(CanDeleteRequest request)
        {
            return await PostAsync<RpcJsonResponse<CanDeleteResult>, CanDeleteResult>(request);
        }

        public async Task<RpcJsonResponse<ConsensusInfoResult>> ConsensusInfoAsync(ConsensusInfoRequest request)
        {
            return await PostAsync<RpcJsonResponse<ConsensusInfoResult>, ConsensusInfoResult>(request);
        }

        public async Task<RpcJsonResponse<FeatureResult>> FeatureAsync(FeatureRequest request)
        {
            return await PostAsync<RpcJsonResponse<FeatureResult>, FeatureResult>(request);
        }

        public async Task<RpcJsonResponse<FeeResult>> FeeAsync(FeeRequest request)
        {
            return await PostAsync<RpcJsonResponse<FeeResult>, FeeResult>(request);
        }

        public async Task<RpcJsonResponse<FetchInfoResult>> FetchInfoAsync(FetchInfoRequest request)
        {
            return await PostAsync<RpcJsonResponse<FetchInfoResult>, FetchInfoResult>(request);
        }

        public async Task<RpcJsonResponse<GetCountsResult>> GetCountsAsync(GetCountsRequest request)
        {
            return await PostAsync<RpcJsonResponse<GetCountsResult>, GetCountsResult>(request);
        }

        public async Task<RpcJsonResponse<ServerInfoResult>> ServerInfoAsync(ServerInfoRequest request)
        {
            return await PostAsync<RpcJsonResponse<ServerInfoResult>, ServerInfoResult>(request);
        }

        public async Task<RpcJsonResponse<ServerStateResult>> ServerStateAsync(ServerStateRequest request)
        {
            return await PostAsync<RpcJsonResponse<ServerStateResult>, ServerStateResult>(request);
        }

        public async Task<RpcJsonResponse<ValidationCreateResult>> ValidationCreateAsync(ValidationCreateRequest request)
        {
            return await PostAsync<RpcJsonResponse<ValidationCreateResult>, ValidationCreateResult>(request);
        }
    }
}
