using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Final
{
    public class ThinCrust : Pizza
    {
        public ThinCrust()
        {
            this.Name = "Thin Crust";
        }

        public ThinCrust(Size s)
        {
            this.PizzaSize = s;
            switch (PizzaSize)
            {
                case Size.Small:
                    this.Price = 10.99;
                    break;
                case Size.Medium:
                    this.Price = 12.99;
                    break;
                case Size.Large:
                    this.Price = 15.99;
                    break;
                case Size.Family:
                    this.Price = 17.99;
                    break;
            }
        }
    }
}