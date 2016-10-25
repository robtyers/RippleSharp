using System;
using System.Collections.Generic;
using System.Net.Http;
using NUnit.Framework;
using RippleSharp.Rippled.Client.RpcJson;
using RippleSharp.Rippled.Client.RpcJson.Requests.Transactions;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Models.Requests.Transactions;
using RippleSharp.Rippled.Models.Shared;
using RippleSharp.Rippled.Tests.RpcJson.TestData.MessageHandler;

namespace RippleSharp.Rippled.Tests.RpcJson.Tests
{
    [TestFixture]
    public class Transactions
    {
        private readonly RpcJsonClient _client;
        
        public Transactions()
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
        public void Tx()
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

        [Test]
        public void TransactionEntry()
        {
            // Arrange
            var request = new TransactionEntryRequest();

            request.Params.Add(new TransactionEntryRequestParams
            {
                TxHash = "E08D6E9754025BA2534A78707605E0601F03ACE063687A0CA1BDDACFCD1698C7",
                LedgerIndex = 348734
            });

            // Act
            var response =
                _client.Transactions.TransactionEntryAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }

        [Test]
        public void RipplePathFind()
        {
            // Arrange
            var request = new RipplePathFindRequest();

            request.Params.Add(new RipplePathFindRequestParams
            {

                SourceAccount = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                SourceCurrencies = new List<CurrencyIssuer> {new CurrencyIssuer {Currency = "USD"}},
                DestinationAccount = "ra5nK24KXen9AHvsdFTKHSANinZseWnPcX",
                DestinationAmount = new CurrencyIssuerValue
                {
                    Currency = "USD",
                    Value = 0.01f,
                    Issuer = "ra5nK24KXen9AHvsdFTKHSANinZseWnPcX"
                }
            });

            // Act
            var response =
                _client.Transactions.RipplePathFindAsync(request).Result;

            // Assert
            Assert.AreEqual(Status.Success, response.Result.Status);
        }
    }
}

