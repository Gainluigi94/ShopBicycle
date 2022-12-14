using Microsoft.EntityFrameworkCore;
using Model.Classes;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
   public class CreditCardRepository : RepositoryBase<CreditCard> , ICreditCardRepository
    {
        public CreditCardRepository(BikeContext context) : base(context)
        {
        }
        internal CreditCardRepository(DbContextOptions<BikeContext> options)
     : base(options)
        {
        }





    }
}
