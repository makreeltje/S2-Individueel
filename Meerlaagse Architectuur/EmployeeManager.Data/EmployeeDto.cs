using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Data
{
    public class EmployeeDto
    {
        public int PersonnelNumber { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public DateTime StartDate { get; internal set; }
    }
}
