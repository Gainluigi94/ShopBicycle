using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Request.Shopping;
using Service.Response.Person;
using Service.Response.Shopping;
using System;
using System.Collections.Generic;

namespace BikeShop.Controllers
{

    [Route("api/[controller]")]
    public class ShoppingController : Controller
    {

        IShoppingService _shoppingService;
        IWebHostEnvironment _hostingEnvironment;


        public ShoppingController(IWebHostEnvironment hostingEnvironment, IShoppingService addressService)
        {
            _shoppingService = addressService;
            _hostingEnvironment = hostingEnvironment;

        }


        [HttpPost("AddShopping")]

        public ShoppingResponse addshopping([FromBody] AddShopping persona)
        {
            ShoppingResponse pers = null;
            try
            {
                pers = _shoppingService.AddShopping(persona);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }



        [HttpDelete("DeleteShopping/{Id}")]

        public ShoppingResponse deleteshopping([FromBody] RemoveShopping persona)
        {
            ShoppingResponse pers = null;
            try
            {
                pers = _shoppingService.RemoveShopping(persona);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }

        [HttpGet("GetAllShopping")]

        public List<ShoppingResponse> getAllShopping()
        {
            List<ShoppingResponse> pers = null;
            try
            {
                pers = _shoppingService.GetAllShopping();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }



    }
}
