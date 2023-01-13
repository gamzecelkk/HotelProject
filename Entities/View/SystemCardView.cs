using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.View
{
    public class SystemCardView
    {
        public int ID { get; set; }
        public string AccessCode { get; set; }
        public int EmployerID { get; set; }
        public bool Activity { get; set; }
        public string Descriptions { get; set; }
    }
}
