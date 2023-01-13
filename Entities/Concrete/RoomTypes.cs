using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoomTypes
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeProperties { get; set; }
        public int RoomTypeBeds { get; set; }
        public int BedTypeID { get; set; }
        public int RoomTypePersons { get; set; }
        public bool RoomTypeIsActive { get; set; }
        public string RoomTypeDescription { get; set; }
       
    }
}
