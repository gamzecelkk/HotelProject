using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.View
{
    public class CardView
    {
        
        public int ID { get; set; }
        public int Room { get; set; }
        public bool Activity { get; set; }
        public string Descriptions { get; set; }
    }
}
