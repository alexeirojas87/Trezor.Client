using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trezor.Client.Models
{
    public class ScriptPubKey
    {
        public string Asm { get; set; }
        public string Hex { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
    }
}
