using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Request.Bike
{
    public class AddBike
    {



        public int BiciId { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public int? Wheel { get; set; }
        public int? Price { get; set; }


    }
}
