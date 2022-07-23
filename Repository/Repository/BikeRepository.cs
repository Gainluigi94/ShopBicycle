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
    public class BikeRepository : RepositoryBase<Bike>,IBikeRepository
    {
        public BikeRepository(BikeContext context) : base(context)
        // public BX_FlussiRepository(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {

        }


        internal BikeRepository(DbContextOptions<BikeContext> options)
       : base(options)
        {
        }








    }
}
