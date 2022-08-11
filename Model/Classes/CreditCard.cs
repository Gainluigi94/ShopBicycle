using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Classes
{
    public partial class CreditCard
    {
        public int Id { get; set; }
        public int? Cardnumber { get; set; }
        public DateTime? Expiration { get; set; }

        public int? Validity { get; set; }
        public string PersonId { get; set; }
    }
}
