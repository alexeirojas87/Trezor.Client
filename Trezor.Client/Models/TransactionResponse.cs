using System.Collections.Generic;

namespace Trezor.Client.Models
{
    public class TransactionResponse
    {
        public string Txid { get; set; }
        public int Version { get; set; }
        public int LockTime { get; set; }
        public List<Vin> Vin { get; set; }
        public List<Vout> Vout { get; set; }
        public string BlockHash { get; set; }
        public int BlockHeight { get; set; }
        public int Confirmations { get; set; }
        public int BlockTime { get; set; }
        public string Value { get; set; }
        public string ValueIn { get; set; }
        public string Fees { get; set; }
        public string Hex { get; set; }
        public bool Rbf { get; set; }
        public EthereumSpecific EthereumSpecific { get; set; }

    }
}
