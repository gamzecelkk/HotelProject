using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomStates
    {
        public int RoomStateID { get; set; }
        public string RoomStateName { get; set; }
        public bool RoomStateIsActive { get; set; }
        public string RoomStateDescription { get; set; }
    }
}
