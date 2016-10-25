using System;
using System.Net.Http;
using NUnit.Framework;
using RippleSharp.Rippled.Client.RpcJson;
using RippleSharp.Rippled.Client.RpcJson.Requests.Server;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Models.Requests.Server;
using RippleSharp.Rippled.Tests.RpcJson.TestData.MessageHandler;

namespace RippleSharp.Rippled.Tests.RpcJson.Tests
{
    [TestFixture]
    public class Server
    {
        private readonly RpcJsonClient _client;
        
        public Server()
        {
            //var client = new HttpClient
            //{
            //    BaseAddress = new Uri("http://s1.ripple.com:51234")
            //};

            var client = new HttpClient(new RippleSharpMessageHandler())
            {
                BaseAddress = new Uri("http://xxxx:1234")
            };

            _client = new RpcJsonClient(client);
        }

        [Test]
        public void ServerInfo()
        {
            // Arrange
            var request = new ServerInfoRequest();
            request.Params.Add(new ServerInfoRequestParams { });

            // Act
            var response = _client.Server.ServerInfoAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void ServerState()
        {
            // Arrange
            var request = new ServerStateRequest();
            request.Params.Add(new ServerStateRequestParams { });

            // Act
            var response = _client.Server.ServerStateAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void CanDelete()
        {
            // Arrange
            var request = new CanDeleteRequest();
            request.Params.Add(new CanDeleteRequestParams
            {
                CanDelete = "11320417"
            });

            // Act
            var response = _client.Server.CanDeleteAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void ConsensusInfo()
        {
            // Arrange
            var request = new ConsensusInfoRequest();
            request.Params.Add(new ConsensusInfoRequestParams { });

            // Act
            var response = _client.Server.ConsensusInfoAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void FetchInfo()
        {
            // Arrange
            var request = new FetchInfoRequest();
            request.Params.Add(new FetchInfoRequestParams
            {
                Clear = false
            });

            // Act
            var response = _client.Server.FetchInfoAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void Feature()
        {
            // Arrange
            var request = new FeatureRequest();
            request.Params.Add(new FeatureRequestParams
            {
                Feature = "4C97EBA926031A7CF7D7B36FDE3ED66DDA5421192D63DE53FFB46E43B9DC8373",
                Vetoed = false
            });

            // Act
            var response = _client.Server.FeatureAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void Fee()
        {
            // Arrange
            var request = new FeeRequest();
            request.Params.Add(new FeeRequestParams { });

            // Act
            var response = _client.Server.FeeAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void GetCounts()
        {
            // Arrange
            var request = new GetCountsRequest();
            request.Params.Add(new GetCountsRequestParams
            {
                MinCount = 100
            });

            // Act
            var response = _client.Server.GetCountsAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void ValidationCreate()
        {
            // Arrange
            var request = new ValidationCreateRequest();
            request.Params.Add(new ValidationCreateRequestParams
            {
                Secret = "BAWL MAN JADE MOON DOVE GEM SON NOW HAD ADEN GLOW TIRE"
            });

            // Act
            var response = _client.Server.ValidationCreateAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }
    }
}
