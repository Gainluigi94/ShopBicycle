using Service.Request.Person;
using Service.Request.User;
using Service.Response.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IPersonService
    {
        public PersoneResponse AddPersona(AddPerson add);

        public PersoneResponse DeletePersona(RemovePerson del);

        public PersoneResponse UpdatePerson(UpdatePerson up);

        public List<PersoneResponse> GetAllPersons();

        public PersoneResponse GetEmail(string user,string password);

        public PersoneResponse GetPassword(string user);  


    }
}
