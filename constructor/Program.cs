using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(501, "anr");
            s1.showstudent();
            student s2 = new student(502, "mouni", "cse");
            s2.showstudent();
            student s3 = new student(503, "basava", "cse", 4000.00);
           // s3.showstudent();


        }
    }
}
