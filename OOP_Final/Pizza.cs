using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Final
{
    public abstract class Pizza : IProduct
    {
        public double Price { get; set; }

        //public string Name { get; set; }
        public string Name 
        {
            get { return this.ToString().Replace("OOP_Final.", ""); }
            set { }
        }
    
        public Size PizzaSize { get; set; }

        public double TaxRate => .115;

        public List<Topping> Toppings;

        int maxToppings = 5;

        //protected double price;
        
        public Pizza()
        {
            this.Price = 0;
            PizzaSize = new Size();
            Toppings = new List<Topping>();
        }

        public Pizza(Size s)
        {
            this.Price = 0;
            this.PizzaSize = s;
        }

        public string About()
        {
            string About = $"{this.PizzaSize} {this.Name} with\n";
            About += $"{GetToppingsAbout()}";
            About += $"Total:\t{GetTotalCost():c} + {this.GetTax():c}";
            return About;
        }

        public string GetToppingsAbout()
        {
            string toppingsAbout = "";

            foreach (Topping t in this.Toppings)
            {
                toppingsAbout += t.About() + "\n";
            }

            return toppingsAbout;
        }

        public void AddTopping(Topping t)
        {
            if (this.Toppings.Count < this.maxToppings)
            {
                this.Toppings.Add(t);
            } 
        }

        public double GetPizzaCost()
        {
            return this.Price;
        }

        public double GetToppingCost()
        {
            double totalToppingPrice = 0;
            foreach (var t in Toppings)
            {
                totalToppingPrice += t.Price;
            }
            return totalToppingPrice;
        }

        public double GetTotalCost()
        {
            return GetPizzaCost() + GetToppingCost();
        }

        public double GetTax()
        {
            return this.GetTotalCost() * this.TaxRate;
        }
    }
}