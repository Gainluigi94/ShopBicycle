using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Request.Person;
using Service.Request.User;
using Service.Response.Person;
using System;
using System.Collections.Generic;

namespace BikeShop.Controllers
{

    [Route("api/[controller]")]

    public class PersonnController : Controller
    {
        IPersonService _personService;


        private readonly IWebHostEnvironment _hostingEnvironment;


        public PersonnController(IWebHostEnvironment webhost, IPersonService personaservice)
        {
            _personService = personaservice;
            _hostingEnvironment = webhost;
     
        }

        [HttpPost("AddPersona")]

        public PersoneResponse addpersona([FromBody]AddPerson persona)
        {
            PersoneResponse pers = null;
            try
            {
               
                pers = _personService.AddPersona(persona);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }



        [HttpDelete("DeletePersona/{Email}/{Passwordd}")]

        public PersoneResponse Deletepersona([FromQuery] RemovePerson persona)
        {
            PersoneResponse pers = null;
            try
            {
                
             pers = _personService.DeletePersona(persona);
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }


        [HttpPut("UpdatePersona/{Email}/{Passwordd}")]

        public PersoneResponse Updatepersona( UpdatePerson persona)
        {
            PersoneResponse pers = null;
            try
            {
                pers = _personService.UpdatePerson(persona);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }


        
        [HttpGet("GetAllPerson")]

        public List<PersoneResponse> GetAllperson()
        {
            List<PersoneResponse> pers = null;
            try
            {
                pers = _personService.GetAllPersons();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }


        [HttpGet("GetUser/{Email}/{Passwordd}")]

        public PersoneResponse GetEmail([FromRoute]GetUser user)
        {
            PersoneResponse pers = null;
            try
            {
                pers = _personService.GetEmail(user.Email,user.Passwordd);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }

        [HttpGet("GetUserr/{Passwordd}")]

        public PersoneResponse GetPassword([FromRoute] string Passwordd)
        {
            PersoneResponse pers = null;
            try
            {
                pers = _personService.GetPassword(Passwordd);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error");

            }
            return pers;
        }


    }
}
