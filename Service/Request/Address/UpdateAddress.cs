using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Request.Address
{
    public class UpdateAddress
    {


        public int Idaddress { get; set; }
        public string? Way { get; set; }
        public int? PostalCode { get; set; }
        public string? Common { get; set; }
        public string? Sidestreet { get; set; }
        public int? Numbercivic { get; set; }

    }
}
