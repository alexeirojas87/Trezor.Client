using Trezor.Client.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using RestSharp;

namespace Trezor.Client.ApiClient
{
    public class TrezorApiClient : ITrezorApiClient
    {
        private readonly RestClient httpClient;
        public TrezorApiClient(string trezorUri)
        {
            var uri = new Uri(trezorUri);
            var clientOptions = new RestClientOptions(uri) { Timeout = 30000, ThrowOnAnyError = true };
            httpClient = new RestClient(clientOptions);
        }
        public async Task<StatusResponse> GetStatus() =>
            await httpClient.GetAsync<StatusResponse>(new RestRequest("/api"));
        public async Task<BlockHashResponse> GetBlockHash(BlockHashRequest request) =>
            await httpClient.GetAsync<BlockHashResponse>(new RestRequest($"/api/v2/block-index/{request.BlockHeight}"));
        public async Task<TransactionResponse> GetTransaction(TransactionRequest request) =>
            await httpClient.GetAsync<TransactionResponse>(new RestRequest($"/api/v2/tx/{request.TxId}"));
        public async Task<TransactionSpecificResponse> GetTransactionSpecific(TransactionRequest request) =>
            await httpClient.GetAsync<TransactionSpecificResponse>(new RestRequest($"/api/v2/tx-specific/{request.TxId}"));
        public async Task<AddressResponse> GetAddress(AddressRequest request)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            if (request.Page != 0)
                query["page"] = request.Page.ToString();
            if (request.PageSize != 0)
                query["pageSize"] = request.PageSize.ToString();
            if (request.From != null)
                query["from"] = request.From.ToString();
            if (request.To != null)
                query["to"] = request.To.ToString();

            query["details"] = request.Details.ToString();
            if (request.Contract != null)
                query["contract"] = request.Contract.ToString();
            return await httpClient.GetAsync<AddressResponse>(new RestRequest($"/api/v2/address/{request.Descriptor}?{query}"));
        }
        public async Task<List<BalanceHistoryItem>> GetBalanceHistory(BalanceHistoryRequest request)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            if (request.From != null)
                query["from"] = request.From?.Ticks.ToString();
            if (request.To != null)
                query["to"] = request.To?.Ticks.ToString();
            if (request.FiatCurrency != null)
                query["fiatcurrency"] = request.FiatCurrency;

            if (request.GroupBy != null)
                query["groupBy"] = request.GroupBy.ToString();

            return await httpClient.GetAsync<List<BalanceHistoryItem>>(new RestRequest($"/api/v2/balancehistory/{request.Xpub ?? request.Address}?{query}"));
        }
        public async Task<TickersResponce> GetTickers(TickersRequest request)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            if (request.Currency != null)
                query["currency"] = request.Currency;

            if (request.Timestamp != null)
                query["timestamp"] = request.Timestamp.ToString();

            return await httpClient.GetAsync<TickersResponce>(new RestRequest($"/api/v2/tickers/?{query}"));
        }
        public async Task<TickersListResponse> GetTickersList(long timestamp)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["timestamp"] = timestamp.ToString();

            return await httpClient.GetAsync<TickersListResponse>(new RestRequest($"/api/v2/tickers-list/?{query}"));
        }
        public async Task<SendTransactionResponse> SendTransaction(string hex) =>
            await httpClient.GetAsync<SendTransactionResponse>(new RestRequest($"/api/v2/sendtx/{hex}"));
        public async Task<Block> GetBlock(string blockHeightOrHash) =>
            await httpClient.GetAsync<Block>(new RestRequest($"/api/v2/block/{blockHeightOrHash}"));
        public async Task<List<UtxoTransaction>> GetUtxo(string addressOrXpub, bool? confirmed = true)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            if (confirmed.HasValue)
                query["confirmed"] = confirmed.ToString();
            return await httpClient.GetAsync<List<UtxoTransaction>>(new RestRequest($"/api/v2/utxo/{addressOrXpub}?{query}"));
        }
        public async Task<XpubTransaction> GetXpub(XpubRequest request)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            if (request.Page != 0)
                query["page"] = request.Page.ToString();
            if (request.PageSize != 0)
                query["pageSize"] = request.PageSize.ToString();
            if (request.From != null)
                query["from"] = request.From.ToString();
            if (request.To != null)
                query["to"] = request.To.ToString();

            query["details"] = request.Details.ToString();
            if (request.Tokens != null)
                query["tokens"] = request.Tokens.ToString();
            return await httpClient.GetAsync<XpubTransaction>(new RestRequest($"/api/v2/xpub/{request.Xpub}?{query}"));
        }
    }
}
