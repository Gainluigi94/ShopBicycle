using AutoMapper;
using Model.Classes;

using Service.Request.Bike;
using Service.Request.CreditCard;
using Service.Request.Curiousperson;
using Service.Request.Person;
using Service.Request.Shopping;
using Service.Request.User;
using Service.Response.CuriousPeople;
using Service.Response.Person;
using Service.Response.Shopping;
using Service.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ViewMapper : Profile
    {




        public ViewMapper()
        {
            #region Shopping
            CreateMap<Shopping, AddShopping>();
            CreateMap<AddShopping,Shopping>();
            CreateMap<Shopping,RemoveShopping>();
            CreateMap<RemoveShopping ,Shopping >();
            CreateMap<Shopping,GetAllShopping>();
            CreateMap<GetAllShopping,Shopping>();
            CreateMap<Shopping, ShoppingResponse>();
            CreateMap<ShoppingResponse, Shopping>();
            #endregion

         


            #region CreditCard
            CreateMap<CreditCard, AddCreditCard>();
            CreateMap<AddCreditCard, CreditCard>();
            CreateMap<CreditCard, RemoveCreditCard>();
            CreateMap<RemoveCreditCard, CreditCard>();
            CreateMap<GetCreditCard, CreditCard>();
            CreateMap<CreditCard, GetCreditCard>();
            #endregion




            #region Bike
            CreateMap<Bike, AddBike>();
            CreateMap<AddBike,Bike>();
            CreateMap<Bike, RemoveBike>();
            CreateMap<RemoveBike,Bike>();
            CreateMap<Bike, UpdateBike>();
            CreateMap<UpdateBike,Bike>();
            #endregion

            #region Person 
            CreateMap<Person, AddPerson>();
            CreateMap<AddPerson, Person>();
            CreateMap<Person, RemovePerson>();
            CreateMap<RemovePerson, Person>();
            CreateMap<Person, UpdatePerson>();
            CreateMap<UpdatePerson, Person>();
            CreateMap<GetAllPersons, Person>();
            CreateMap<Person, GetAllPersons>();
            CreateMap<AddPerson, PersoneResponse>();
            CreateMap<PersoneResponse, AddPerson>();
            CreateMap<PersoneResponse, Person>();
            CreateMap<Person, PersoneResponse>();
            #endregion

            #region Userr
            CreateMap<Username, AddUser>();
            CreateMap<AddUser, Username>();
            CreateMap<Username, RemoveUser>();
            CreateMap<RemoveUser, Username>();
            CreateMap<Username, GetUser>();
            CreateMap<GetUser,Username>();
            CreateMap<Username, GetAllUser>();
            CreateMap<GetAllUser, Username>();
            CreateMap<Username, UserResponse>();
            CreateMap<UserResponse, Username>();


            #endregion

            #region CuriousPeople
            CreateMap<Curiousperson, AddCuriuousperson>();
            CreateMap<AddCuriuousperson, Curiousperson>();
            CreateMap<Curiousperson, CuriousPeopleResponse>();            
            CreateMap<CuriousPeopleResponse, Curiousperson>();
            
            #endregion


        }




    }
    }
