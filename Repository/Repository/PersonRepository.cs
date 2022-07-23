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
    public class PersonRepository : RepositoryBase<Person> , IPersonRepository
    {

        public PersonRepository(BikeContext context) : base(context)
        {
        }





        internal PersonRepository(DbContextOptions<BikeContext> options) : base(options)
        {
        }
    }
}
