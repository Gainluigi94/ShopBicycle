using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Request.Curiousperson;
using Service.Response.CuriousPeople;
using System;

namespace BikeShop.Controllers
{


    [Route("api/[controller]")]



    public class CuriouspersonController : Controller
    {

        ICuriousPeopleService _ICuriousPeopleService;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public CuriouspersonController(ICuriousPeopleService iCuriousPeopleService, IWebHostEnvironment hostingEnvironment)
        {
            _ICuriousPeopleService = iCuriousPeopleService;
            _hostingEnvironment = hostingEnvironment;
        }


        [HttpPost("AddCuriousPerson")]

        public CuriousPeopleResponse AddCuriousPeople([FromBody]AddCuriuousperson person)

        {
            CuriousPeopleResponse curiousPeopleResponse = null;

            try
            {
                curiousPeopleResponse = _ICuriousPeopleService.AddCuriousPeople(person);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error");    
            }

            return curiousPeopleResponse;

        }





    }
}
