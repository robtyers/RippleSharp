using System;
using System.Net.Http;
using NUnit.Framework;
using RippleSharp.Rippled.Client.RpcJson;
using RippleSharp.Rippled.Client.RpcJson.Requests.Transactions;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Tests
{
    [TestFixture]
    public class Transactions
    {
        private readonly RpcJsonClient _client;
        private const string Url = "http://s1.ripple.com:51234";

        public Transactions()
        {
            var client = new HttpClient { BaseAddress = new Uri(Url) };
            _client = new RpcJsonClient(client);
        }

        [Test]
        public void CanCallTx()
        {
            // Arrange
            var request = new TxRequest();

            request.Params.Add(new TxRequestParams
            {
                Transaction= "E08D6E9754025BA2534A78707605E0601F03ACE063687A0CA1BDDACFCD1698C7",
                Binary = false
            });

            // Act
            var response =
                _client.Transactions.TxAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }
    }
}

