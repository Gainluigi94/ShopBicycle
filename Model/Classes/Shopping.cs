using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Classes
{
    public partial class Shopping
    {
        public int Id { get; set; }
        public int? BiciId { get; set; }
        public string Email { get; set; }

        public virtual Bike Bici { get; set; }
    }
}
