namespace Trezor.Client.Models
{
    public class UtxoTransaction
    {
        public string Txid { get; set; }
        public int Vout { get; set; }
        public string Value { get; set; }
        public int Confirmations { get; set; }
        public int LockTime { get; set; }
        public bool Coinbase { get; set; }
    }
}
