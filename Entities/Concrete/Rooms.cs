using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rooms
    {

        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int RoomTypeID { get; set; }
        public decimal RoomPrice { get; set; }
        public bool RoomIsEmpty { get; set; }
        public int FloorID { get; set; }
        public bool RoomIsClean { get; set; }
        public string RoomSize { get; set; }
        public bool AirConditioningIsActive { get; set; }
        public bool MinibarIsActive { get; set; }
        public bool HairDryerIsActive { get; set; }
        public bool WifiIsActive { get; set; }
        public bool SafeIsActive { get; set; }
        public bool TVIsActive { get; set; }
        public bool BalconyIsActive { get; set; }
        public string RoomBedType { get; set; }
        public bool RoomIsActive { get; set; }
        public string RoomDescription { get; set; }
    }
}
