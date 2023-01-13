using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Floors
    {

        public int FloorID { get; set; }
        public string FloorNumber { get; set; }
        public string FloorProperties { get; set; }
        public bool FloorIsActive { get; set; }
        public string FloorDescription { get; set; }
    }
}
