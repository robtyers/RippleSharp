using System.Collections.Generic;
using RippleSharp.Rippled.Enums;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Models.Shared.Transactions
{
    public abstract class TransactionBase : ITransaction
    {
        public string Account { get; set; }
        public string AccountTxnID { get; set; }
        public string Fee { get; set; }
        public int Flags { get; set; }
        public int LastLedgerSequence { get; set; }
        public IEnumerable<dynamic> Memos { get; set; } // ToDo: What are these?
        public int Sequence { get; set; }
        public string SigningPubKey { get; set; }
        public IEnumerable<dynamic> Signers { get; set; } // ToDo: What are these?
        public int SourceTag { get; set; }
        public TransactionNodeType TransactionType { get; set; }
        public string TxnSignature { get; set; } 
    }
}
