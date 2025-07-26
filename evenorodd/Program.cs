 ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenorodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 1)
            {
                Console.WriteLine(number + "Is a postive number");
            }
            else if (number == 0)
            {
                Console.WriteLine(number + "neutral number");
            }
            else
            {
                Console.WriteLine(number + "is negative number");
            }

        }
    }
}
