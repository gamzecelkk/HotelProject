using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.View
{
    public class PackageView
    {
        public int ID { get; set; }
        public string PackageName { get; set; }
        public string Properties { get; set; }
        public decimal Price { get; set; }
        public bool Activity { get; set; }
        public string Descriptions { get; set; }
    }
}
