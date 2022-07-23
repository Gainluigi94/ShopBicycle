using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Request.Person
{
    public class AddPerson
    {
        public string Email { get; set; }
        public string Passwordd { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public string Sex { get; set; }
        public string Nation { get; set; }
        public string Taxcode { get; set; }
        

    }
}
