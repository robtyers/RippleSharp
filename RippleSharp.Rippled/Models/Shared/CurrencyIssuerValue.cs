using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared
{
    public class CurrencyIssuerValue : IAmount
    {
        public string Currency { get; set; }
        public string Issuer { get; set; }
        public float Value { get; set; }
    }
}
