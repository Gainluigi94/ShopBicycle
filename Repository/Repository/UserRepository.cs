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
  public  class UserRepository : RepositoryBase<Username> , IUserRepository
    {
        public UserRepository(BikeContext context) : base(context)
        {
        }

        internal UserRepository(DbContextOptions<BikeContext> options)
     : base(options)
        {
        }

    
    }
}
