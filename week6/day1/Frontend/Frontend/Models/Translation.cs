using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class Translation
    {
        public string Text { get; set; }
        public string OringinalLang { get; set; }
        public string TranslatedText { get; set; }
        public string TargetLang { get; set; }
    }
}
