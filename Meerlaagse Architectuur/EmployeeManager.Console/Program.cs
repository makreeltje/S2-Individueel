using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManager.Business;

namespace EmployeeManager.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var emps = Employee.GetAllEmployees();
            foreach (var e in emps)
            {
                System.Console.WriteLine(e);
            }

            System.Console.Read();
        }
    }
}
