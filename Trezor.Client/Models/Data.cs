namespace Trezor.Client.Models
{
    public class Data
    {
        public bool Subscribed { get; set; }
        public string Address { get; set; }
        public TransactionResponse Tx { get; set; }
        public int Height { get; set; }
        public string Hash { get; set; }
    }
}
