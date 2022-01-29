namespace Trezor.Client.Models
{
    public class AddressRequest
    {
        public string Descriptor { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public Details? Details { get; set; }
        public string Contract { get; set; }
    }
}
