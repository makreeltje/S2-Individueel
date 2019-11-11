using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManager.Data;

namespace EmployeeManager.Business
{
    public class Employee
    {
        public Employee(string firstName, string lastName, int pNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonnelNumber = pNumber;
        }

        public int PersonnelNumber { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public string ImageName
        {
            get { return string.Format("Image\\{0}.jpg", PersonnelNumber); }
        }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();

            EmployeeDatabaseHandler handler = new EmployeeDatabaseHandler();

            var employeeFromDatabase = handler.GetAllEmployees();

            foreach (var empDto in employeeFromDatabase)
            {
                Employee employee = new Employee(empDto.FirstName, empDto.LastName, empDto.PersonnelNumber);
                employee.DateOfBirth = empDto.DateOfBirth;
                employee.StartDate = empDto.StartDate;
                allEmployees.Add(employee);
            }

            return allEmployees;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1} {2}", PersonnelNumber, FirstName, LastName);
        }
    }
}
