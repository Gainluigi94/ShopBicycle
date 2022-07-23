using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Request.CreditCard
{
   public class AddCreditCard
    {

        public int Id { get; set; }
        public int? Cardnumber { get; set; }
        public DateTime? Expiration { get; set; }
        public int? Validity { get; set; }
        public string? PersonId { get; set; }


    }
}
