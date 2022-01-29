using System.Collections.Generic;

namespace Trezor.Client.Models
{
    public class TickersResponce
    {
        public long Ts { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
