using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstDemo
{
    partial class Product
    {
        partial void AddProduct();
        partial void EditProduct();
        partial void FindProduct();
        partial void DeleteProduct();

    }
        //Developer 1
        public partial class product
        {
            partial void AddProduct()
            {
                Console.WriteLine("Add product by developer1");
            }
            public void saveproduct()
            {
               AddProduct();
            }
        }
        //Developer 2 
        public partial class product
        {
            partial void EditProduct()
            {

            }
        public void upadateproduct()
        {

        }
       }
        //Developer 3
        public partial class product
        {
            partial void DeleteProduct()
            {

            }
        }
        //Developer 4
        public partial class product
        {
            partial void FindProduct()
            {

            }
        }


    
}