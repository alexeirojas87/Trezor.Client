namespace Trezor.Client.Models
{
    public class VShieldedSpend
    {
        public string Cv { get; set; }
        public string Anchor { get; set; }
        public string Nullifier { get; set; }
        public string Rk { get; set; }
        public string Proof { get; set; }
        public string SpendAuthSig { get; set; }
    }
}
