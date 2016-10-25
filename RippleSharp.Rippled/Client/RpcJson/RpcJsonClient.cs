using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RippleSharp.Rippled.Client.RpcJson.Requests;
using RippleSharp.Rippled.Client.RpcJson.Requests.Convenience;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Json;

namespace RippleSharp.Rippled.Client.RpcJson
{
    public class RpcJsonClient : IRippledClient
    {
        private readonly HttpClient _client;

        public AccountInformationRequests AccountInformation { get; private set; }
        public ConvenienceRequests Convenience { get; private set; }
        public LedgerRequests Ledger { get; private set; }
        public ServerRequests Server { get; private set; }
        public TransactionRequests Transactions { get; private set; }

        public RpcJsonClient(HttpClient client)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            AccountInformation = new AccountInformationRequests(this);
            Convenience = new ConvenienceRequests(this);
            Ledger = new LedgerRequests(this);
            Server = new ServerRequests(this);
            Transactions = new TransactionRequests(this);
        }
        
        public async Task<bool> ConnectedAsync()
        {
            var response = await Convenience.PingAsync(new PingRequest());
            return response.Result.Status == Status.Success;
        }
        
        public async Task<string> PostAsync(IRippledRequest request)
        {
            var json = request.ToJson();
            var queryString = new StringContent(json);
            var message = await _client.PostAsync("", queryString);

            message.EnsureSuccessStatusCode();

            return await message.Content.ReadAsStringAsync();
        }

        public string RippledApiVersion => "0.30.1";
    }
}
