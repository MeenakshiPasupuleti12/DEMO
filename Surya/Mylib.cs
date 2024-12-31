using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Surya
{
    internal class Mylib
    {
        //static Mutex m = new Mutex();
        public static void ShowMessage(object message)
        {
          string msg = message.ToString();
            string[] data = msg.Split();
            // m.WaitOne();
           // Console.WriteLine("----------");
            foreach (string m in data)
            {
                Console.Write(m + " ");
               // Console.WriteLine(" ");
            }
           // Console.WriteLine("--------------");
          //  m.ReleaseMutex();
        }
    }
}
