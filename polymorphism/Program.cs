/﻿using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mylib.Add(19, 29);
            mylib.Add(19, 20, 30);
            mylib.Add(".net", "c#");
            mylib.Add(12, "meena");
            mylib.Add(11.0, 178.0);
            mylib.Add(140.00f, 23.09f);
            mylib.Add(7396018872l, 2);
            mylib.Add(12.0f, 132.099);
        }
    }
}
