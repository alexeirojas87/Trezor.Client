using System;
namespace Trezor.Client.Models
{
    public class XpubRequest
    {
        public string Xpub { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public Details? Details { get; set; }
        public Tokens? Tokens { get; set; }
    }

    
}
