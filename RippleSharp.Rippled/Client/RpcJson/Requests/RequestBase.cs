using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Json;

namespace RippleSharp.Rippled.Client.RpcJson.Requests
{
    public abstract class RequestBase : IRippledCommand
    {
        private readonly IRippledClient _client;
        private readonly JsonSerializerSettings _serializerSettings;

        protected RequestBase(IRippledClient client)
        {
            _client = client;

            _serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new SnakeCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new LedgerNodeConverter(),
                    new CurrencyAmountConverter(),
                    new JobTypeConverter(),
                    new TolerantEnumConverter()
                }
            };
        }

        public string RawResponse { get; set; }

        protected async Task<TResponse> PostAsync<TResponse, TResult>(IRippledRequest request)
            where TResponse : IRpcJsonResponse<TResult>
        {
            RawResponse = await _client.PostAsync(request);
            return JsonConvert.DeserializeObject<TResponse>(RawResponse, _serializerSettings);
        }
    }
}
