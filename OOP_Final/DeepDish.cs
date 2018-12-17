using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Final
{
    public class DeepDish : Pizza
    {
        public DeepDish()
        {
            this.Name = "Deep Dish";
            this.Price = 0;
        }

        public DeepDish(Size s)
        {
            this.PizzaSize = s;
            switch (PizzaSize)
            {
                case Size.Small:
                    this.Price = 14.99;
                    break;
                case Size.Medium:
                    this.Price = 16.99;
                    break;
                case Size.Large:
                    this.Price = 19.99;
                    break;
                case Size.Family:
                    this.Price = 21.99;
                    break;
            }
        }

        public double PizzaCost => this.Price;
    }
}