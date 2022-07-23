using AutoMapper;
using Repository.IRepository;
using Service.Contract;
using Service.Request.CreditCard;
using Service.Response.CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class CreditCardService : ICreditCardService
    {
        IMapper _mapper;
        ICreditCardRepository _CreditCardRepository;



        public CreditCardService (IMapper mapper,ICreditCardRepository creditCardRepository)
        {
            _mapper = mapper;                   
            _CreditCardRepository = creditCardRepository;
        }




        public CreditCardResponse AddCreditCard(AddCreditCard add)
        {
            throw new NotImplementedException();
        }

        public CreditCardResponse DeleteCreditCard(RemoveCreditCard add)
        {
            throw new NotImplementedException();
        }

        public List<CreditCardResponse> GetAllCreditCards()
        {
            throw new NotImplementedException();
        }

        public CreditCardResponse GetCreditCard(int id)
        {
            throw new NotImplementedException();
        }
    }
}
