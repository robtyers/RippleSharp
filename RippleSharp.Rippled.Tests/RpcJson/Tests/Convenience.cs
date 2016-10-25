using System;
using System.Net.Http;
using NUnit.Framework;
using RippleSharp.Rippled.Client.RpcJson;
using RippleSharp.Rippled.Client.RpcJson.Requests.Convenience;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Models.Requests.Convenience;
using RippleSharp.Rippled.Tests.RpcJson.TestData.MessageHandler;

namespace RippleSharp.Rippled.Tests.RpcJson.Tests
{
    [TestFixture]
    public class Convenience
    {
        private readonly RpcJsonClient _client;
        
        public Convenience()
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
        public void Ping()
        {
            // Arrange
            var request = new PingRequest();
            request.Params.Add(new PingRequestParams { });

            // Act
            var response = _client.Convenience.PingAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void Random()
        {
            // Arrange
            var request = new RandomRequest();
            request.Params.Add(new RandomRequestParams { });

            // Act
            var response = _client.Convenience.RandomAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }
        
        [Test]
        public void Connect()
        {
            // Arrange
            var request = new ConnectRequest();
            request.Params.Add(new ConnectRequestParams
            {
                Ip = "192.170.145.88",
                Port = 51235
            });

            // Act
            var response = _client.Convenience.ConnectAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void Stop()
        {
            // Arrange
            var request = new StopRequest();
            request.Params.Add(new StopRequestParams { });

            // Act
            var response = _client.Convenience.StopAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }
    }
}
