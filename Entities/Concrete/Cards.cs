using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cards
    {

        public int CardID { get; set; }
        public int RoomID { get; set; }
        public bool CardIsActive { get; set; }
        public string CardDescription { get; set; }
    }
}
