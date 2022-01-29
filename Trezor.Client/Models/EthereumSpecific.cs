namespace Trezor.Client.Models
{
    public class EthereumSpecific
    {
        public int Status { get; set; }
        public int Nonce { get; set; }
        public int GasLimit { get; set; }
        public object GasUsed { get; set; }
        public string GasPrice { get; set; }
        public string Data { get; set; }
    }
}
