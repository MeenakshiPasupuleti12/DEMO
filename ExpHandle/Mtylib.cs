using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExpHandle
{
    internal class Mylib
    {
        public static void showMessage(Object message)
        {
            string msg = message.ToString();
            string[] data = msg.Split();
            foreach (string s in data)
            {
                Console.WriteLine(s+"   ");
            }
        }



    }
}
