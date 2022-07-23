using Service.Request.Bike;
using Service.Response.Bike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
   public interface IBikeService
    {
        public BikeResponse AddBike(AddBike add);

        public BikeResponse DeleteBike(RemoveBike add);

        public BikeResponse UpdateBike(UpdateBike add);

        public BikeResponse GetBike(GetBike add);

        public List<BikeResponse> GetAllBike();



    }
}
