using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class mylib
    {

        public static void Add(int x, int y)
        {
            Console.WriteLine(" int int " + (x + y));
        }
        public static void Add(int x,int y,int z)
        {
            Console.WriteLine("int int int" + (x + y + z));
        }
        public static void Add(string x, string y)
        {
            Console.WriteLine("string string" + (x + y));
        }
        public static void Add(int x, string y)
        {
            Console.WriteLine("int string" + (x + y));
        }
        public static void Add(double x,double y)
        {
            Console.WriteLine("double double" + (x + y));
        }
        public static void Add(float x, float y)
        {
            Console.WriteLine("float float" + (x + y));
        }
        public static void Add( long x,int y)
        {
            Console.WriteLine("long int" + (x + y));
        }
        public static void  Add(float x ,double y)
        {
            Console.WriteLine(" float  double" + (x + y));
        }

    }

}
