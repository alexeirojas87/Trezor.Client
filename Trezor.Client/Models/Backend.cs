namespace Trezor.Client.Models
{
    public class Backend
    {
        public string Chain { get; set; }
        public int Blocks { get; set; }
        public int Headers { get; set; }
        public string BestBlockHash { get; set; }
        public string Difficulty { get; set; }
        public long SizeOnDisk { get; set; }
        public string Version { get; set; }
        public string Subversion { get; set; }
        public string ProtocolVersion { get; set; }
        public int TimeOffset { get; set; }
        public int Warnings { get; set; }
    }
}
