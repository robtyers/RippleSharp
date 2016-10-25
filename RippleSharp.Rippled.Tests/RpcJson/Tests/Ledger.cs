using System;
using System.Net.Http;
using NUnit.Framework;
using RippleSharp.Rippled.Client.RpcJson;
using RippleSharp.Rippled.Client.RpcJson.Requests.Ledger;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Json;
using RippleSharp.Rippled.Models.Requests.Ledger;
using RippleSharp.Rippled.Tests.RpcJson.TestData.MessageHandler;

namespace RippleSharp.Rippled.Tests.RpcJson.Tests
{
    [TestFixture]
    public class Ledger
    {
        private readonly RpcJsonClient _client;
        
        public Ledger()
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
        public void CallLedger()
        {
            // Arrange
            var request = new LedgerRequest();

            request.Params.Add(new LedgerRequestParams
            {
                LedgerIndex = LedgerIndex.Validated.ToLower(),
                Accounts = false,
                Full = false,
                Transactions = true,
                Expand = false,
                OwnerFunds = false
            });

            // Act
            var response =
                _client.Ledger.LedgerAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void LedgerClosed()
        {
            // Arrange
            var request = new LedgerClosedRequest();

            request.Params.Add(new LedgerClosedRequestParams { });

            // Act
            var response =
                _client.Ledger.LedgerClosedAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void LedgerCurrent()
        {
            // Arrange
            var request = new LedgerCurrentRequest();

            request.Params.Add(new LedgerCurrentRequestParams { });

            // Act
            var response =
                _client.Ledger.LedgerCurrentAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void LedgerData()
        {
            // Arrange
            var request = new LedgerDataRequest();

            request.Params.Add(new LedgerDataRequestParams
            {
                Binary = false,
                Limit = 5
            });

            // Act
            var response =
                _client.Ledger.LedgerDataAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void LedgerEntry()
        {
            // Arrange
            var request = new LedgerEntryRequest();

            request.Params.Add(new LedgerEntryRequestParams
            {
                AccountRoot = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                LedgerIndex = LedgerIndex.Validated.ToLower(),
                Type = LedgerEntryType.AccountRoot.ToSnakeCase()
            });

            // Act
            var response =
                _client.Ledger.LedgerEntryAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }
    }
}
