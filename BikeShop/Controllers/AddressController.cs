using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Request.Address;
using Service.Response.Address;
using System;
using System.Collections.Generic;

namespace BikeShop.Controllers
{


    [Route("api/[controller]")]


    public class AddressController : Controller
    {
        IAddressService _addressService;
        IWebHostEnvironment _hostingEnvironment;


        public AddressController(IWebHostEnvironment hostingEnvironment, IAddressService addressService)
        {
            _addressService = addressService;
            _hostingEnvironment = hostingEnvironment;

        }

        [HttpPost("AddAddress")]

        public AddressResponse addAddress([FromQuery] AddAddress add)
        {

            AddressResponse pers = null;
            try
            {
                pers = _addressService.AddAddress(add);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }


        [HttpDelete("DeleteAddress/{Idaddress}")]

        public AddressResponse Deletepersona([FromBody] RemoveAddress per)
        {
            AddressResponse pers = null;
            try
            {
                pers = _addressService.DeleteAddress(per);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }




        [HttpPut("UpdateAddress/{Idaddress}")]

        public AddressResponse Updatepersona(UpdateAddress persona)
        {
            AddressResponse pers = null;
            try
            {
                pers = _addressService.UpdateAddress(persona);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }


        [HttpGet("GetAddress/{Idaddress}")]

        public AddressResponse Getaddress(GetAddress get)
        {
            AddressResponse pers = null;
            try
            {
                pers = _addressService.GetAddress(get);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }



        [HttpGet("GetAllAddresses")]

        public List<AddressResponse> GetAlladdress()
        {
            List<AddressResponse> pers = null;
            try
            {
                pers = _addressService.GetAllAddress(); 

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }



    }
}
