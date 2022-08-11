using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model.Classes;
using Repository.IRepository;
using Repository.Repository;


namespace Repository
{
    public static class Dependeces
    {

        public static IServiceCollection AddRepositories(this IServiceCollection
     services)
        {

            services
                .AddTransient<IUserRepository, UserRepository>()
                    .AddTransient<IPersonRepository, PersonRepository>()
                     .AddTransient<IBikeRepository, BikeRepository>()
                     .AddTransient<ICreditCardRepository, CreditCardRepository>()
               .AddTransient<ICuriousPeopleRepository,CuriousPersonRepository>()
                        .AddTransient<IShoppingRepository, ShoppingRepository>()
                     ;
            return services;
        }
        public static IServiceCollection AddShopRepositories(this IServiceCollection
  services, IConfiguration configuration)
        {

            services
                    .AddTransient<IPersonRepository, PersonRepository>((r) =>
                    {


                        var optionsBuilder = new DbContextOptionsBuilder<BikeContext>();
                        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                        return new PersonRepository(new BikeContext(optionsBuilder.Options));
                    })
                    .AddTransient<IBikeRepository, BikeRepository>((r) =>
              {


                  var optionsBuilder = new DbContextOptionsBuilder<BikeContext>();
                  optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                  return new BikeRepository(new BikeContext(optionsBuilder.Options));
              })
        
                   .AddTransient<ICreditCardRepository, CreditCardRepository>((r) =>
              {


                   var optionsBuilder = new DbContextOptionsBuilder<BikeContext>();
                   optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                    return new CreditCardRepository(new BikeContext(optionsBuilder.Options));
              })


                 
                   .AddTransient<ICuriousPeopleRepository, CuriousPersonRepository>((r) =>
                      {


                          var optionsBuilder = new DbContextOptionsBuilder<BikeContext>();
                          optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                          return new CuriousPersonRepository(new BikeContext(optionsBuilder.Options));
                      })





                     .AddTransient<IUserRepository, UserRepository>((r) =>
                     {


                         var optionsBuilder = new DbContextOptionsBuilder<BikeContext>();
                         optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));

                         return new UserRepository(new BikeContext(optionsBuilder.Options));
              });
            return services;

        }
    }
}
