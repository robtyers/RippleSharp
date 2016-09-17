using System.Collections.Generic;
using RippleSharp.Rippled.Models.Shared.LedgerNode;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class AccountInfoResult : RippledResult
    {
        public AccountRoot AccountData { get; set; }
        public IEnumerable<SignerList> SignerLists { get; set; }
        public int? LedgerCurrentIndex { get; set; }
        public string LedgerHash { get; set; }
        public int? LedgerIndex { get; set; }
        public bool Validated { get; set; }
    }
}
