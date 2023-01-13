using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Images
    {

        public int ImageID { get; set; }
        public string ImageName { get; set; }
        public string ImageURL { get; set; }
        public bool ImageIsActive { get; set; }
        public string ImageDescription { get; set; }
    }
}
