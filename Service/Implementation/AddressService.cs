using AutoMapper;
using Model.Classes;
using Repository.IRepository;
using Service.Contract;
using Service.Request.Address;
using Service.Response.Address;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Implementation
{
    public class AddressService : IAddressService
    {

        IAddressRepository _addressRepository;
        IMapper _mapper;

        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public AddressResponse AddAddress(AddAddress add)
        {
            var address = _mapper.Map<Address>(add);
            _addressRepository.Add(address);
            return _mapper.Map<AddressResponse>(address);
        }

        public AddressResponse DeleteAddress(RemoveAddress delete)
        {
            var address = _mapper.Map<Address>(delete);
            _addressRepository.Delete(address);
            return _mapper.Map<AddressResponse>(address);
        }

        public AddressResponse GetAddress(GetAddress addresss)
        {
            var address = _addressRepository.GetAll().Where(x => x.Idaddress == addresss.Idaddress).FirstOrDefault();
            return _mapper.Map<AddressResponse>(address);
        }

        public List<AddressResponse> GetAllAddress()
        {
            var address = _addressRepository.GetAll().ToList();
            return _mapper.Map<List<AddressResponse>>(address);
        }


        public AddressResponse UpdateAddress(UpdateAddress addrress)
        {
            var address = _mapper.Map<Address>(addrress);
            _addressRepository.Update(address);
            return _mapper.Map<AddressResponse>(address);
        }
    }
}
