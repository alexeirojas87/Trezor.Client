using System.Collections.Generic;

namespace Trezor.Client.Models
{
    public class BalanceHistoryItem
    {
        public long Time { get; set; }

        public int Txs { get; set; }

        public string Received { get; set; }

        public string Sent { get; set; }

        public string SentToSelf { get; set; }

        public Dictionary<string, decimal> Rates { get; set; }
    }
}
