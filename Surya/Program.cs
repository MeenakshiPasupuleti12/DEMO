vusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Surya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the Main:");

            ParameterizedThreadStart ts1 = new
            ParameterizedThreadStart (Mylib.ShowMessage);
            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts1);
            string m1 = "There once was a boy who grew bored " +
                "while watching over the village sheep. " +
                "He wanted to make things more exciting." +
                " So, he yelled out that he saw a wolf chasing " +
                "the sheep. All the villagers came running to " +
                "drive the wolf away. However, they saw no wolf. " +
                "The boy was amused, but the villagers were not. " +
                "They told him not to do it again. Shortly after," +
                " he repeated this antic. The villagers came running again" +
                ", only to find that he was lying. Later that day, the boy " +
                "really sees a wolf sneaking amongst the flock. He jumped up and" +
                " called out for help. But no one came this time because they thought" +
                " he was still joking around. At sunset, the villagers looked for the boy." +
                " He had not returned with their sheep. They found him crying. He told them" +
                " that there really was a wolf, and the entire flock was gone. An old man" +
                " came to comfort him and told him that nobody would believe a liar even when" +
                " they are being honest.";
            string m2 = "A hungry fox once looked everywhere for food. He couldn’t find a" +
                "nything until he stumbled upon a farmer’s wall. He saw big, purple, juicy" +
                " grapes. He jumped as high as possible to reach the grapes. No matter how" +
                " many times he tried, he failed. Finally, he gave up and went home, thinking" +
                " to himself that the grapes must have been sour anyway.";
            t1.Start(m1);
            t2.Start(m2);
            Console.WriteLine("End of the Main:");
        }
    }
}
