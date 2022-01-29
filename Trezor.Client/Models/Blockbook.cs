using System;

namespace Trezor.Client.Models
{
    public class Blockbook
    {
        public string Coin { get; set; }
        public string Host { get; set; }
        public string Version { get; set; }
        public string GitCommit { get; set; }
        public DateTime BuildTime { get; set; }
        public bool SyncMode { get; set; }
        public bool InitialSync { get; set; }
        public bool InSync { get; set; }
        public int BestHeight { get; set; }
        public DateTime LastBlockTime { get; set; }
        public bool InSyncMempool { get; set; }
        public DateTime LastMempoolTime { get; set; }
        public int MempoolSize { get; set; }
        public int Decimals { get; set; }
        public long DbSize { get; set; }
        public string About { get; set; }
    }
}
