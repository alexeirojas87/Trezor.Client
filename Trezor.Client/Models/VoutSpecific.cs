namespace Trezor.Client.Models
{
    public class VoutSpecific
    {
        public double Value { get; set; }
        public int N { get; set; }
        public ScriptPubKey ScriptPubKey { get; set; }
    }
}
