
namespace Trezor.Client.Models
{
    public class Token
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Transfers { get; set; }
        public int Decimals { get; set; }
        public string Balance { get; set; }
        public string TotalReceived { get; set; }
        public string TotalSent { get; set; }
    }
}
