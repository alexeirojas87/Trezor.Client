namespace Trezor.Client.Models
{
    public class Vout
    {
        public string Value { get; set; }
        public int N { get; set; }
        public string Hex { get; set; }
        public string[] Addresses { get; set; }
        public bool IsAddress { get; set; }
    }
}
