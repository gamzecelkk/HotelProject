using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Packages
    {

        public int PackageID { get; set; }
        public string PackageName { get; set; }
        public string PackageProperties { get; set; }
        public decimal PackagePrice { get; set; }
        public bool PackageIsActive { get; set; }
        public string PackageDescription { get; set; }
    }
}
