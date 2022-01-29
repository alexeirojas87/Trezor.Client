namespace Trezor.Client.Models
{
    public class Vin
    {
        public string Txid { get; set; }
        public int Vout { get; set; }
        public long Sequence { get; set; }
        public int N { get; set; }
        public string[] Addresses { get; set; }
        public bool IsAddress { get; set; }
        public string Value { get; set; }
        public string Hex { get; set; }
    }
}
