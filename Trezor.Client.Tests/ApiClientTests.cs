using System.Threading.Tasks;
using Trezor.Client.ApiClient;
using Trezor.Client.Models;
using Xunit;

namespace Trezor.Client.Tests
{
    public class ApiClientTests
    {
        private readonly ITrezorApiClient _client;
        public ApiClientTests()
        {
            _client = new TrezorApiClient("https://tbtc1.trezor.io");
        }
        [Fact]
        public async Task CheckBlock()
        {
            var blockResponse = await _client.GetBlock("000000000000000047a4240481b9adba186b3ca4ce7c1099635d71c7ef734569");
            Assert.NotNull(blockResponse);
            Assert.Equal("000000000000000047a4240481b9adba186b3ca4ce7c1099635d71c7ef734569", blockResponse.Hash);
        }
        [Fact]
        public async Task CheckTransaction()
        {
            var transactionResponce = await _client.GetTransaction(new TransactionRequest { TxId = "7a38507014d36824b6439679141b8ed0cbf18a434dd8a93d0e4108b64f385cbd" });
            Assert.NotNull(transactionResponce);
            Assert.Equal("7a38507014d36824b6439679141b8ed0cbf18a434dd8a93d0e4108b64f385cbd", transactionResponce.Txid);
        }
        [Fact]
        public async Task CheckTransactionSpecific()
        {
            var transactionResponce = await _client.GetTransactionSpecific(new TransactionRequest { TxId = "7a38507014d36824b6439679141b8ed0cbf18a434dd8a93d0e4108b64f385cbd" });
            Assert.NotNull(transactionResponce);
            Assert.Equal("7a38507014d36824b6439679141b8ed0cbf18a434dd8a93d0e4108b64f385cbd", transactionResponce.Hash);
        }
        [Fact]
        public async Task CheckAddress()
        {
            var addressResponce = await _client.GetAddress(new AddressRequest { Descriptor = "mrSzj9gz6NyMKcGpvsUarZLadSQQZ5xwP5" });
            Assert.NotNull(addressResponce);
            Assert.Equal("mrSzj9gz6NyMKcGpvsUarZLadSQQZ5xwP5", addressResponce.Address);
        }
        [Fact]
        public async Task CheckUtxos()
        {
            var utxosResponce = await _client.GetUtxo("mrSzj9gz6NyMKcGpvsUarZLadSQQZ5xwP5", false);
            Assert.NotNull(utxosResponce);
        }
        [Fact]
        public async Task CheckTickers()
        {
            var tickersResponce = await _client.GetTickersList(1643338536);
            Assert.NotNull(tickersResponce);
        }
        [Fact]
        public async Task CheckTicker()
        {
            var tickerResponce = await _client.GetTickers(new TickersRequest { Currency = "usd", Timestamp = 1643338536 });
            Assert.NotNull(tickerResponce);
        }
        [Fact]
        public async Task CheckBalanceHistory()
        {
            var balanceHistoryResponce = await _client.GetBalanceHistory(new BalanceHistoryRequest { Address= "mrSzj9gz6NyMKcGpvsUarZLadSQQZ5xwP5" });
            Assert.NotNull(balanceHistoryResponce);
        }
    }
}
