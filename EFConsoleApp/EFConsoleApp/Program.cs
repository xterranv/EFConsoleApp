using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var cntxt = new SchoolContext())
            {
                var student = new Student() { StudentName = "Adam" };

                cntxt.Students.Add(student);
                cntxt.SaveChanges();

                Console.Write("Student entry saved successfully.");                
            }
        }
    }
}
