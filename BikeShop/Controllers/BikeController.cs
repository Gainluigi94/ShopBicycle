using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Request.Bike;
using Service.Request.Person;
using Service.Response.Bike;
using System;
using System.Collections.Generic;

namespace BikeShop.Controllers
{


    [Route("api/[controller]")]

    public class BikeController : Controller
    {
        IBikeService _bikeService;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public BikeController(IBikeService bikeService, IWebHostEnvironment hostingEnvironment)
        {
            _bikeService = bikeService;
            _hostingEnvironment = hostingEnvironment;
        }


        [HttpPost("AddBike")]

        public BikeResponse addBike([FromBody] AddBike add)
        {

            BikeResponse pers = null;
            try
            {
                pers = _bikeService.AddBike(add);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
             return pers;


        }


        [HttpDelete("DeleteBike/{biciId}")]

        public BikeResponse deletebike([FromBody] RemoveBike add)
        {

            BikeResponse pers = null;
            try
            {
                pers = _bikeService.DeleteBike(add);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;


        }


        [HttpPut("UpdateBike/{biciId}")]

        public BikeResponse Updatebike(UpdateBike add)
        {

            BikeResponse pers = null;
            try
            {
                pers = _bikeService.UpdateBike(add);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;


        }


        [HttpGet("GetAllBikes")]

        public List<BikeResponse> GetAllPersons()
        {

            List<BikeResponse> pers = null;
            try
            {
                pers = _bikeService.GetAllBike();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;


        }









    }
}
