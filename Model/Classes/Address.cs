using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Classes
{
    public partial class Address
    {
        public int? Idaddress { get; set; }
        public string Way { get; set; }
        public int? PostalCode { get; set; }
        public string Common { get; set; }
        public string Sidestreet { get; set; }
        public int? Numbercivic { get; set; }
    }
}
