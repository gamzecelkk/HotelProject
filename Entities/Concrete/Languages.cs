using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Languages
    {

        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCode { get; set; }
        public bool LanguageIsActive { get; set; }
        public string LanguageDescription { get; set; }
    }
}
