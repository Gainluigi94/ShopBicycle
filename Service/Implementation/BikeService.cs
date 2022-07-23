using AutoMapper;
using Model.Classes;
using Repository.IRepository;
using Repository.Repository;
using Service.Contract;
using Service.Request.Bike;
using Service.Response.Bike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class BikeService : IBikeService
    {
        IBikeRepository _bikeRepository;
        IMapper _mapper;


        public BikeService(IBikeRepository bikeRepository, IMapper mapper)
        {
            _bikeRepository = bikeRepository;
            _mapper = mapper;
        }

        public BikeResponse AddBike(AddBike add)
        {
            var person = _mapper.Map<Bike>(add);
            _bikeRepository.Add(person);
            return _mapper.Map<BikeResponse>(person);
        }

        public BikeResponse DeleteBike(RemoveBike add)
        {
            var person = _mapper.Map<Bike>(add);
            _bikeRepository.Delete(person);
            return _mapper.Map<BikeResponse>(person);
        }

        public List<BikeResponse> GetAllBike()
        {
           var list = _bikeRepository.GetAll().ToList();
            return _mapper.Map<List<BikeResponse>>(list);
        }

        public BikeResponse GetBike(GetBike add)
        {
            var bike = _bikeRepository.GetAll().Where(x => x.BiciId == add.BiciId).FirstOrDefault();
            return _mapper.Map<BikeResponse>(bike);

        }

        public BikeResponse UpdateBike(UpdateBike add)
        {
            var person = _mapper.Map<Bike>(add);
            _bikeRepository.Update(person);
            return _mapper.Map<BikeResponse>(person);
        }
    }
}
