using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared
{
    public class CurrencyIssuerAmount : IAmount
    {
        public string Currency { get; set; }
        public string Issuer { get; set; }
        public decimal Amount { get; set; }
    }
}
