using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Classes
{
    public class Person
    {
        public Person()
        {
            Userrs = new HashSet<Userr>();
        }

        public string Email { get; set; }
        public string Passwordd { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public string Sex { get; set; }
        public string Nation { get; set; }
        public string Taxcode { get; set; }
        public int? BiciId { get; set; }

        public virtual Bike Bici { get; set; }
        public virtual ICollection<Userr> Userrs { get; set; }
    }
}
