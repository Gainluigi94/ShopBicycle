using AutoMapper;
using Model.Classes;
using Repository.IRepository;
using Service.Contract;
using Service.Request.Shopping;
using Service.Response.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class ShoppingService : IShoppingService
    {

        IMapper _mapper;
        IShoppingRepository _shoppingRepository;

        public ShoppingService(IMapper mapper, IShoppingRepository  shoppingRepository)
        {
            _mapper = mapper;
            _shoppingRepository = shoppingRepository;
        }


        public ShoppingResponse AddShopping(AddShopping add)
        {
            var shopping = _mapper.Map<Shopping>(add);
            _shoppingRepository.Add(shopping);
            return _mapper.Map<ShoppingResponse>(shopping);
        }

        public List<ShoppingResponse> GetAllShopping()
        {
            var shopping = _shoppingRepository.GetAll().ToList();
            return _mapper.Map<List<ShoppingResponse>>(shopping);
        }

        public ShoppingResponse RemoveShopping(RemoveShopping remove)
        {
            var shopping = _mapper.Map<Shopping>(remove);
            _shoppingRepository.Delete(shopping);
            return _mapper.Map<ShoppingResponse>(shopping);
        }
    }
}
