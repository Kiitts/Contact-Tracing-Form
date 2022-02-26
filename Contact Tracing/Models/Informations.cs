using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Tracing.Models
{
    class Informations
    {
        public class Personal
        {
            public string FullName { get; set; }
            public string Age { get; set; }
            public string Address { get; set; }
            public string Gender { get; set; }
            public string OutSideNCR { get; set; }
            public string WhereOutside { get; set; }
            public List<int> Sick { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
        }
    }
}
