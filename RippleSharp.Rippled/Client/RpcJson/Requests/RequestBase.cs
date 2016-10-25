using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
                //ContractResolver = new SnakeCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new LedgerNodeConverter(),
                    new TransactionConverter(),
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
            var formattedResponse = FormatPropertyNames(RawResponse);

            return JsonConvert.DeserializeObject<TResponse>(formattedResponse, _serializerSettings);
        }

        private static string FormatPropertyNames(string response)
        {
            var responseJson = JObject.Parse(response);
            var nodes = new HashSet<string>();

            ParseJson(responseJson, nodes, "");
            
            foreach (var node in nodes.Where(n => n.Length > 0 && (n.Contains('_') || n.All(char.IsLower))))
            {
                response = response.Replace(node, node.ToPascalCase());
            }

            return response;
        }

        private static bool ParseJson(JToken token, HashSet<string> nodes, string parentLocation = "")
        {
            if (token.HasValues)
            {
                foreach (var child in token.Children())
                {
                    if (token.Type == JTokenType.Property)
                        parentLocation += "/" + ((JProperty)token).Name;
                    ParseJson(child, nodes, parentLocation);
                }

                // we are done parsing and this is a parent node
                return true;
            }

            parentLocation.Split('/').ToList().ForEach(pl => nodes.Add(pl));
            return false;
        }
    }
}
