using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product p1 = new product(120,"mango","3kg",150.00);
            p1.showproduct();
            product p2 = new product(201, "grapee", "3kg", 100.00);
            p2.showproduct();
            product p3 = new product(202, "apple", "3kg", 150.00);
            p3.showproduct();
        }
    }
}
