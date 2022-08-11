using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Model.Classes;
using Repository.IRepository;
using Service.Contract;
using Service.Request.Person;
using Service.Request.User;
using Service.Response.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class PersonService : IPersonService
    {
        IMapper _mapper;
        IPersonRepository _personRepository;
        public PersonService(IMapper mapper,IPersonRepository personRepository)
        {
            _mapper = mapper;       
            _personRepository = personRepository;
        }


        public PersoneResponse AddPersona(AddPerson add)
        {
            var person = _mapper.Map<Person>(add);

          
             _personRepository.Add(person);
            return _mapper.Map<PersoneResponse>(person);    

        }

        public PersoneResponse DeletePersona(RemovePerson del)
        {
            var person = _mapper.Map<Person>(del);
            _personRepository.Delete(person);
            return _mapper.Map<PersoneResponse>(person);
        }

        public List<PersoneResponse> GetAllPersons()
        {
            var person = _personRepository.GetAll().ToList();
            return _mapper.Map<List<PersoneResponse>>(person);
        }

        public PersoneResponse GetEmail(string userr,string password)
        {

            using (var context = new BikeContext())
            {
                var user = context.Personns.FromSqlInterpolated(
                    $"SELECT * from Person where Email = {userr} and Passwordd = {password}").FirstOrDefault();
                return _mapper.Map<PersoneResponse>(user);
            }

            
        }

       

        public PersoneResponse GetPassword(string userr)
        {
            var user = _personRepository.GetAll().Where(X => X.Passwordd == userr).FirstOrDefault();
            return _mapper.Map<PersoneResponse>(user);
        }

        public PersoneResponse UpdatePerson(UpdatePerson up)
        {

            var person = _mapper.Map<Person>(up);
            _personRepository.Update(person);
            return _mapper.Map<PersoneResponse>(person);
        }
    }
}
