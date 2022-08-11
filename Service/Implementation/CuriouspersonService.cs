using AutoMapper;
using Model.Classes;
using Repository.IRepository;
using Service.Contract;
using Service.Request.Curiousperson;
using Service.Response.CuriousPeople;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class CuriouspersonService : ICuriousPeopleService
    {
        IMapper _mapper;
        ICuriousPeopleRepository _CuriousPeopleRepository;


        public CuriouspersonService(IMapper mapper, ICuriousPeopleRepository curiousPeopleRepository)
        {
            _mapper = mapper;
            _CuriousPeopleRepository = curiousPeopleRepository;
        }   


        public CuriousPeopleResponse AddCuriousPeople(AddCuriuousperson person)
        {
            var personn = _mapper.Map<Curiousperson>(person);
            _CuriousPeopleRepository.Add(personn);
            return _mapper.Map<CuriousPeopleResponse>(personn);

        }



    }
}
