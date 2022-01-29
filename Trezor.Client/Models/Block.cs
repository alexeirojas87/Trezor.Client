namespace Trezor.Client.Models
{
    public class Block
    {
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public string Hash { get; set; }
        public string PreviousBlockHash { get; set; }
        public string NextBlockHash { get; set; }
        public long Height { get; set; }
        public int Confirmations { get; set; }
        public int Size { get; set; }
        public long Time { get; set; }
        public long Version { get; set; }
        public string  MerkleRoot { get; set; }
        public string Nonce { get; set; }
        public string Bits { get; set; }
        public string Difficulty { get; set; }
        public int TxCount { get; set; }
        public TransactionResponse[] Txs { get; set; }
    }
}
