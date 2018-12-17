using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            // PIZZA ORDER 1 //
            ThinCrust tcPizza = new ThinCrust(Size.Small);
            tcPizza.AddTopping(new Pepperoni());
            tcPizza.AddTopping(new Mushroom());

            // PIZA ORDER 2 //
            ThickCrust thcPizza = new ThickCrust(Size.Large);
            thcPizza.AddTopping(new Pepperoni());
            thcPizza.AddTopping(new ExtraCheese());

            // PIZZA ORDER 3 //
            DeepDish ddPizza = new DeepDish(Size.Medium);
            ddPizza.AddTopping(new Pepperoni());
            ddPizza.AddTopping(new GreenPepper());
            ddPizza.AddTopping(new Sausage());

            Console.WriteLine("===OOPS PIZZA===");
            Console.WriteLine();
            Console.WriteLine(tcPizza.About());
            Console.WriteLine();
            Console.WriteLine(thcPizza.About());
            Console.WriteLine();
            Console.WriteLine(ddPizza.About());

            Console.ReadKey();
        }
    }
}
