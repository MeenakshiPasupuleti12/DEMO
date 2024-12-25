using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinky
{
    internal class product
    {
        int productId;
        string prouductName;
        string Quantity;
        double price;
        public product(int productId,string productName,string Quantity,double price)
        {
            this.productId = productId;
            this.prouductName = productName;
            this.Quantity = Quantity;
            this.price = price;

        }
        public void showproduct()
        {
            Console.WriteLine(productId + " " + prouductName + " " + Quantity + " " + price);
        }
    }
}
