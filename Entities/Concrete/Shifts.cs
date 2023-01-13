using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Shifts
    {
        public int ShiftID { get; set; }
        public string ShiftName { get; set; }
        public DateTime ShiftDate { get; set; }
        public int ShiftTimeID { get; set; }
        public bool OverTimeIsThere { get; set; }
        public int OverTime { get; set; }
        public bool ShiftIsActive { get; set; }
        public string ShiftDescription { get; set; }
    }
}
