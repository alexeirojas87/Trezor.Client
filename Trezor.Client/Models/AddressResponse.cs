using System.Collections.Generic;

namespace Trezor.Client.Models
{
    public class AddressResponse
    {
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int ItemsOnPage { get; set; }
        public string Address { get; set; }
        public string Balance { get; set; }
        public string TotalReceived { get; set; }
        public string TotalSent { get; set; }
        public string UnconfirmedBalance { get; set; }
        public int UnconfirmedTxs { get; set; }
        public int Txs { get; set; }
        public List<TransactionResponse> Transactions { get; set; } = new List<TransactionResponse>();
        public List<string> Txids { get; set; } = new List<string>();
    }
}
