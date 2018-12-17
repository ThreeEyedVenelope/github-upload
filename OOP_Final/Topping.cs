using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Final
{
    public abstract class Topping : IProduct
    {
        //protected string name;
        //protected double price;
        public string Name { get; set; }
        public double Price { get; set; }


        public Topping()
        {
            this.Price = 0;
            this.Name = "Default";
        }
        public string About()
        {
            return $"{this.Name}\t{this.Price:c}";
        }
    }
}