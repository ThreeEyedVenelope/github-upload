using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Final
{
    public class ThickCrust : Pizza
    {
        public ThickCrust()
        {
            this.Name = "Thick Crust";
        }

        public ThickCrust(Size s)
        {
            this.PizzaSize = s;
            switch (PizzaSize)
            {
                case Size.Small:
                    this.Price = 11.99;
                    break;
                case Size.Medium:
                    this.Price = 13.99;
                    break;
                case Size.Large:
                    this.Price = 16.99;
                    break;
                case Size.Family:
                    this.Price = 18.99;
                    break;
            }
        }

        public double PizzaCost => this.Price;

        /*public double GetPizzaCost()
        {   

        }*/
    }
}