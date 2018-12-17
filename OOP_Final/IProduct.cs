using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Final
{
    public interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }

        string About();
    }
}