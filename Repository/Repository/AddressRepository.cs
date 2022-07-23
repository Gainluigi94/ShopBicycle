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
    public class AddressRepository : RepositoryBase<Address> , IAddressRepository
    {
        public AddressRepository(BikeContext context) : base(context)
        {
        }


        internal AddressRepository(DbContextOptions<BikeContext> options)
      : base(options)
        {
        }




    }
}
