using System;
namespace Trezor.Client.Models
{
    public class BalanceHistoryRequest
    {
        public string Xpub { get; set; }
        public string Address { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string FiatCurrency { get; set; }
        public int? GroupBy { get; set; }
    }
}
