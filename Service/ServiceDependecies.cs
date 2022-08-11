using Microsoft.Extensions.DependencyInjection;
using Repository.IRepository;
using Repository.Repository;
using Service.Contract;
using Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public static class ServiceDependecies
    {



        public static IServiceCollection AddServices(this IServiceCollection
    services)
        {
            services.AddTransient<IUserrService, UserService>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IBikeService, BikeService>();
 services.AddTransient<ICuriousPeopleService,CuriouspersonService>();
            services.AddTransient<IShoppingService, ShoppingService>();


            return services;

        }



    }
}
