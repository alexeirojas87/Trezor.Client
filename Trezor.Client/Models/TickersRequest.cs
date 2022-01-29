namespace Trezor.Client.Models
{
    public class TickersRequest
    {
        public string Currency { get; set; }
        public long? Timestamp { get; set; }
    }
}
