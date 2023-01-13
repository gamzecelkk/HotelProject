using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ShiftsTime
    {

        public int ShiftTimeID { get; set; }
        public string ShiftTime { get; set; }
        public bool ShiftTimeIsActive { get; set; }
        public string ShiftTimeDescription { get; set; }
    }
}
