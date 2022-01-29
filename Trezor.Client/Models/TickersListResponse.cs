using System.Collections.Generic;

namespace Trezor.Client.Models
{
    public class TickersListResponse
    {
        public long Ts { get; set; }
        public IEnumerable<string> AvailableCurrencies { get; set; }
    }
}
