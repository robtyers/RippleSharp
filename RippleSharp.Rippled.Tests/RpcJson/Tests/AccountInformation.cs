using System;
using System.Collections.Generic;
using System.Net.Http;
using NUnit.Framework;
using RippleSharp.Rippled.Client.RpcJson;
using RippleSharp.Rippled.Client.RpcJson.Requests.AccountInformation;
using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Json;
using RippleSharp.Rippled.Models.Requests.AccountInformation;
using RippleSharp.Rippled.Tests.RpcJson.TestData.MessageHandler;

namespace RippleSharp.Rippled.Tests.RpcJson.Tests
{
    [TestFixture]
    public class AccountInformation
    {
        private readonly RpcJsonClient _client;
        
        public AccountInformation()
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
        public void AccountCurrencies()
        {
            // Arrange
            var request = new AccountCurrencyRequest();

            request.Params.Add(new AccountCurrencyRequestParams
            {
                Account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                LedgerHash = null,
                LedgerIndex = LedgerIndex.Validated.ToLower(),
                Strict = true
            });
            
            // Act
            var response = _client.AccountInformation.AccountCurrenciesAsync(request).Result;
            
            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void AccountInfo()
        {
            // Arrange
            var request = new AccountInfoRequest();

            request.Params.Add(new AccountInfoRequestParams
            {
                Account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                LedgerIndex = LedgerIndex.Validated.ToLower(),
                Strict = true
            });

            // Act
            var response = _client.AccountInformation.AccountInfoAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void AccountLines()
        {
            // Arrange
            var request = new AccountLinesRequest();

            request.Params.Add(new AccountLinesRequestParams
            {
                Account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59"
            });

            // Act
            var response = _client.AccountInformation.AccountLinesAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void AccountObjects()
        {
            // Arrange
            var request = new AccountObjectsRequest();

            request.Params.Add(new AccountObjectsRequestParams
            {
                Account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                LedgerIndex = LedgerIndex.Validated.ToLower(),
                Limit = 10,
                Type = LedgerNodeType.State.ToLower()
            });

            // Act
            var response = _client.AccountInformation.AccountObjectsAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void AccountOffers()
        {
            // Arrange
            var request = new AccountOffersRequest();

            request.Params.Add(new AccountOffersRequestParams
            {
                Account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                LedgerIndex = LedgerIndex.Current.ToLower()
            });

            // Act
            var response = _client.AccountInformation.AccountOffersAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void AccountTx()
        {
            // Arrange
            var request = new AccountTxRequest();

            request.Params.Add(new AccountTxRequestParams
            {
                Account= "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                LedgerIndexMin = -1,
                LedgerIndexMax = -1,
                Binary = false,
                //Count = false,
                Limit = 10,
                Forward = false
            });

            // Act
            var response =
                _client.AccountInformation.AccountTxAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void NorippleCheck()
        {
            // Arrange
            var request = new NorippleCheckRequest();

            request.Params.Add(new NorippleCheckRequestParams()
            {
                Account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                LedgerIndex = LedgerIndex.Current.ToLower(),
                Role = Role.Gateway.ToLower(),
                Limit = 2,
                Transactions = true
            });

            // Act
            var response =
                _client.AccountInformation.NorippleCheckAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void GatewayBalances()
        {
            // Arrange
            var request = new GatewayBalancesRequest();

            request.Params.Add(new GatewayBalancesRequestParams()
            {
                Account = "rMwjYedjc7qqtKYVLiAccJSmCwih4LnE2q",
                LedgerIndex = LedgerIndex.Validated.ToLower(),
                Strict = true,
                HotWallet = new List<string>
                {
                    "ra7JkEzrgeKHdzKgo4EUUVBnxggY4z37kt",
                    "rKm4uWpg9tfwbVSeATv4KxDe6mpE9yPkgJ"
                }
            });

            // Act
            var response =
                _client.AccountInformation.GatewayBalancesAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void WalletProposeWithKeyType()
        {
            // Arrange
            var request = new WalletProposeRequest();

            request.Params.Add(new WalletProposeRequestParams()
            {
                Seed = "snoPBrXtMeMyMHUVTgbuqAfg1SUTb",
                KeyType = KeyType.SECP256K1
            });

            // Act
            var response =
                _client.AccountInformation.WalletProposeAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void WalletProposeWithoutKeyType()
        {
            // Arrange
            var request = new WalletProposeRequest();

            request.Params.Add(new WalletProposeRequestParams()
            {
                PassPhrase = "snoPBrXtMeMyMHUVTgbuqAfg1SUTb"
            });

            // Act
            var response =
                _client.AccountInformation.WalletProposeAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }
    }
}
