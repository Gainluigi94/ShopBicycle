using AutoMapper;
using Model.Classes;
using Service.Request.Address;
using Service.Request.Bike;
using Service.Request.CreditCard;
using Service.Request.Person;
using Service.Request.Shopping;
using Service.Request.User;
using Service.Response.Address;
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

            #region Address
            CreateMap<Address, AddAddress>();
            CreateMap<AddAddress, Address>();
            CreateMap<Address, RemoveAddress>();
            CreateMap<RemoveAddress,Address>();
            CreateMap<Address,UpdateAddress>();
            CreateMap<UpdateAddress, Address>();
            CreateMap<GetAddress, Address>();
            CreateMap<Address, GetAddress>();
            CreateMap<AddressResponse, Address>();
            CreateMap<Address,AddressResponse>();
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
            CreateMap<PersoneResponse, Person>();
            CreateMap<Person, PersoneResponse>();
            #endregion

            #region Userr
            CreateMap<Userr, AddUser>();
            CreateMap<AddUser, Userr>();
            CreateMap<Userr, RemoveUser>();
            CreateMap<RemoveUser, Userr>();
            CreateMap<Userr, GetUser>();
            CreateMap<GetUser,Userr>();
            CreateMap<Userr, GetAllUser>();
            CreateMap<GetAllUser, Userr>();
            CreateMap<Userr, UserResponse>();
            CreateMap<UserResponse, Userr>();


            #endregion

        }




    }
    }
