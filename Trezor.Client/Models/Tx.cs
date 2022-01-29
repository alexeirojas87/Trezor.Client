namespace Trezor.Client.Models
{
    public class Tx
    {
        public string Nonce { get; set; }
        public string GasPrice { get; set; }
        public string Gas { get; set; }
        public string To { get; set; }
        public string Value { get; set; }
        public string Inpute { get; set; }
        public string BlockNumber { get; set; }
        public string BlockHash { get; set; }
        public string From { get; set; }
        public string TransactionIndex { get; set; }
    }
}
