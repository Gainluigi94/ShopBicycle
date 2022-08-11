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
    public class CuriousPersonRepository : RepositoryBase<Curiousperson>, ICuriousPeopleRepository
    {

        public CuriousPersonRepository(BikeContext context) : base(context)
        {
        }
        internal CuriousPersonRepository(DbContextOptions<BikeContext> options)
     : base(options)
        {
        }



    }
}
