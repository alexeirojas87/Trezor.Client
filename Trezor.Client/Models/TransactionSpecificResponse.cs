using System.Collections.Generic;

namespace Trezor.Client.Models
{
    public class TransactionSpecificResponse
    {
        public string Txid { get; set; }
        public string Hash { get; set; }
        public int Version { get; set; }
        public int Size { get; set; }
        public int Vsize { get; set; }
        public int Weight { get; set; }
        public int Locktime { get; set; }
        public List<VinSpecific> Vin { get; set; }
        public List<VoutSpecific> Vout { get; set; }
        public string Hex { get; set; }
        public string Blockhash { get; set; }
        public int Confirmations { get; set; }
        public int Time { get; set; }
        public int Blocktime { get; set; }
    }
}
