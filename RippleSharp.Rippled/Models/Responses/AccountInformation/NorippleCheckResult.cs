﻿using System.Collections.Generic;

namespace RippleSharp.Rippled.Models.Responses.AccountInformation
{
    public class NorippleCheckResult : RippledResult
    {
        public int LedgerCurrentIndex { get; set; }
        public IEnumerable<string> Problems { get; set; }
        public IEnumerable<dynamic> Transactions { get; set; } // ToDo
    }
}
