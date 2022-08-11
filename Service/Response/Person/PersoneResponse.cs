using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Response.Person
{
    public class PersoneResponse
    {
        public string Email { get; set; }
        public string Passwordd { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birth { get; set; }
        public string Gender { get; set; }
        public string Nation { get; set; }
        public string Taxcode { get; set; }
        public string Way { get; set; }
        public string PostalCode { get; set; }
        public string Common { get; set; }
        public int? NumberStreet { get; set; }
        public int? Telephonenumber { get; set; }
    }
}
