using Service.Request.Curiousperson;
using Service.Response.CuriousPeople;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface ICuriousPeopleService
    {



        public CuriousPeopleResponse AddCuriousPeople(AddCuriuousperson person);
    }
}
