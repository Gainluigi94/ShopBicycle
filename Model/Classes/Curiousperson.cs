using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Classes
{
    public partial class Curiousperson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
    }
}
