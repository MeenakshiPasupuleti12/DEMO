//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClgApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            studentContext context = new studentContext();
            Read products - using foreach

            foreach (Student s in context.Students)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Branch + " " + s.College + " " + s.City );
            }
          /  /Student e = new Student();

            Console.WriteLine("Enter Student Id:");
            e.Id= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student name:");
            e.Name=Console.ReadLine();

            Console.WriteLine("Enter the College:");
            e.Branch= Console.ReadLine();

            Console.WriteLine("Enter the City:");
            e.City= Console.ReadLine();

            Console.WriteLine("Enter the state");
            e.state= Console.ReadLine();

            context.Students.Remove(e);
            context.SaveChanges();
            Console.WriteLine("new add is created successfully");
        }
    }
}
