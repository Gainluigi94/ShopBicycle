using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Classes
{
    public partial class Bike
    {
        public Bike()
        {
            Shoppings = new HashSet<Shopping>();
        }

        public int BiciId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int? Wheel { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<Shopping> Shoppings { get; set; }
    }
}
