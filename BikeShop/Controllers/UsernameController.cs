using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Request.User;
using Service.Response.User;
using System;
using System.Collections.Generic;

namespace BikeShop.Controllers
{


    [Route("api/[controller]")]


    public class UsernameController : Controller
    {

        IUserrService _userService;
        IWebHostEnvironment _hostingEnvironment;

        public UsernameController(IUserrService user, IWebHostEnvironment webHostEnvironment)
        {

            _userService = user;
            _hostingEnvironment = webHostEnvironment;

        }


        [HttpPost("AddUser")]

        public UserResponse AddUser([FromBody] AddUser add)
        {
            UserResponse user = null;
            try
            {
                user = _userService.AddUser(add);

            }catch(Exception ex)
            {
                Console.WriteLine("Error");
            }


            return user;
        }


        [HttpDelete("RemoveUser/{Email}")]

        public UserResponse RemoveUser([FromBody] RemoveUser add)
        {
            UserResponse user = null;
            try
            {
                user = _userService.RemoveUser(add);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }


            return user;
        }


        [HttpGet("GetAllUsers")]

        public List<UserResponse> GetAllUsers()
        {
            List<UserResponse> users = null;
            try
            {
                users = _userService.GetUsers();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }


            return users;
        }

        [HttpGet("GetUser/{Email}")]

        public UserResponse GetUser([FromBody] GetUser user)
        {
            UserResponse users = null;
            try
            {
                users = _userService.GetUser(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }


            return users;
        }



    }
}
