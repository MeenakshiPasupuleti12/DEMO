
using System.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class student
    {
        int studentid;
        string studentName;
        String studentbranch;
        double studentfee;
        public student()
        {
           // It is a empty constructor
        }
        public student(int sid,string sName)
        {
            studentid = sid;
            studentName = sName;
        }
        public student(int sid, string sName,string sbr)
        {
            studentid = sid;
            studentName = sName;
            studentbranch = sbr;
        }
        public student(int sid, string sName, string sbr,double sfee)
        {
            studentid = sid;
            studentName = sName;
            studentbranch = sbr;
            studentfee = sfee;
        }
        public void showstudent()
        {
            Console.WriteLine(studentid + "" + studentName + ""
                + studentbranch + "" +studentfee);
        }
        ~student()
        {
            Console.WriteLine("destructor");
        }
    } 
    
    
}
