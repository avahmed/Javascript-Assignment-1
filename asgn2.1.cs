using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class asgn2.1
    {
        static void Main(string[] args)
        {
            int eid;
            string ename;
            string ejob;
            string sal;

            Console.WriteLine("Enter ID: ");
            eid=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            ename = (Console.ReadLine());

            Console.WriteLine("Enter Job: ");
            ejob = (Console.ReadLine());

            Console.WriteLine("Enter Salary: ");
            sal = (Console.ReadLine());

            Console.WriteLine("~~~~~~ Employee Details ~~~~~~");
            Console.WriteLine("Emp Id: "+eid);
            Console.WriteLine("Emp Name: " + ename);
            Console.WriteLine("Job: " + ejob);
            Console.WriteLine("Salary: " + sal);

            Console.ReadLine();
        }
    }
}
