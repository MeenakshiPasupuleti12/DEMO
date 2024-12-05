using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExpHandle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the progam");
            ParameterizedThreadStart ts1 = new ParameterizedThreadStart(Mylib.showMessage);
            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts1);
            string s1 = "The Fox one day thought of a plan to am" +
                "use himself at the expense of the Stork, at whose odd " +
                "appearance he was always laughing. \"You must come and " +
                "dine with me ...";

            string s2 = "In a spell of dry weather" +
                ", when the Birds could find very little" +
                " to drink, a thirsty Crow found a pitcher " +
                "with a little water in it. But the pitcher was" +
                " high ...";
            t1.Start(s1);
            t2.Start(s2);
            t1.Join();
            t2.Join();
            Console.WriteLine("End of the Program");
        }
    }
}
