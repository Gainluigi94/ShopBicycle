using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using Service.Request.Person;
using Service.Response.Person;
using System;
using System.Collections.Generic;

namespace BikeShop.Controllers
{

    [Route("api/[controller]")]

    public class PersonController : Controller
    {
        IPersonService _personService;


        private readonly IWebHostEnvironment _hostingEnvironment;


        public PersonController(IWebHostEnvironment webhost, IPersonService personaservice)
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
                Console.WriteLine(persona.Email);
                Console.WriteLine(persona.Passwordd);
                Console.WriteLine(persona.Surname);
                Console.WriteLine(persona.Birth);
                Console.WriteLine(persona.Nation);
                Console.WriteLine(persona.Name);
                Console.WriteLine(persona.Taxcode);
                Console.WriteLine(persona.Sex);
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





    }
}
