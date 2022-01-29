using Trezor.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trezor.Client.ApiClient
{
    public interface ITrezorApiClient
    {
        Task<StatusResponse> GetStatus();
        Task<BlockHashResponse> GetBlockHash(BlockHashRequest request);
        Task<TransactionResponse> GetTransaction(TransactionRequest request);
        Task<TransactionSpecificResponse> GetTransactionSpecific(TransactionRequest request);
        Task<List<BalanceHistoryItem>> GetBalanceHistory(BalanceHistoryRequest request);
        Task<TickersResponce> GetTickers(TickersRequest request);
        Task<TickersListResponse> GetTickersList(long timestamp);
        Task<SendTransactionResponse> SendTransaction(string hex);
        Task<AddressResponse> GetAddress(AddressRequest request);
        Task<Block> GetBlock(string blockHeightOrHash);
        Task<List<UtxoTransaction>> GetUtxo(string addressOrXpub, bool? confirmed = true);
        Task<XpubTransaction> GetXpub(XpubRequest request);
    }
}
