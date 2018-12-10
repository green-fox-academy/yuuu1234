using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class Until
    {
        public string Action { get; set; }
        public long UntilNumber { get; set; }
        public long Result { get; set; }
        public string Error { get; set; }
    }
}
