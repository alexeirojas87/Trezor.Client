using System.Collections.Generic;

namespace Trezor.Client.Models
{
    public class Reciept
    {
        public string GasUsed { get; set; }
        public string Status { get; set; }
        public List<object> Logs { get; set; }
    }
}
