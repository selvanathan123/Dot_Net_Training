using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_example
{
    public class Student
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

    }

    //Inheritance
    public class Details: Student
    {
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        public void StudentDetails() 
        {
            Console.WriteLine("StudentDetails:" + Address);
        
        }

    }


}
