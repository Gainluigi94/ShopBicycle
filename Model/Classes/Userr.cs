using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Classes
{
    public partial class Userr
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Passwordd { get; set; }

        public virtual Person Person { get; set; }
    }
}
