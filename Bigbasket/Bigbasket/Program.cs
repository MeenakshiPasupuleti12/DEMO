using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigbasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProContext context = new ProContext();
            foreach (Product p in context.products)
            {
                Console.WriteLine(p.Id + " " + p.Name + "" + p.cost + "" + p.price);
            }
        }
    }
}
