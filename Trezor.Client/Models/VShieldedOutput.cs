namespace Trezor.Client.Models
{
    public class VShieldedOutput
    {
        public string Cv { get; set; }
        public string Cmu { get; set; }
        public string EphemeralKey { get; set; }
        public string EncCiphertext { get; set; }
        public string OutCiphertext { get; set; }
        public string Proof { get; set; }
    }
}
