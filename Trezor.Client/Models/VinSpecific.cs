namespace Trezor.Client.Models
{
    public class VinSpecific
    {
        public string Txid { get; set; }
        public int Vout { get; set; }
        public ScriptSig ScriptSig { get; set; }
        public long Sequence { get; set; }
    }
}
