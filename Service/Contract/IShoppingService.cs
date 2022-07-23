using Service.Request.Shopping;
using Service.Response.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IShoppingService
    {

        public ShoppingResponse AddShopping(AddShopping add);

        public ShoppingResponse RemoveShopping(RemoveShopping remove);

        public List<ShoppingResponse> GetAllShopping();




    }
}
