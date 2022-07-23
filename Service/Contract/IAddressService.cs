using Service.Request.Address;
using Service.Response.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
  public interface IAddressService
    {

        public AddressResponse AddAddress(AddAddress add);

        public AddressResponse DeleteAddress(RemoveAddress delete);

        public AddressResponse GetAddress(GetAddress address);

        public AddressResponse UpdateAddress(UpdateAddress address);

        public List<AddressResponse> GetAllAddress();





    }
}
