using Service.Request.CreditCard;
using Service.Response.CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface ICreditCardService
    {
        public CreditCardResponse AddCreditCard(AddCreditCard add);

        public CreditCardResponse DeleteCreditCard(RemoveCreditCard add);

        public CreditCardResponse GetCreditCard(int id);

        public List<CreditCardResponse> GetAllCreditCards();

    }
}
