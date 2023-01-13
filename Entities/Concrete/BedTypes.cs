using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BedTypes
    {
        public int BedTypeID { get; set; }
        public string BedTypeName { get; set; }
        public bool BedTypeIsActive { get; set; }
        public string BedTypeDescription { get; set; }
    }
}
