using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Data
{
    public class EmployeeDataException : Exception
    {
        public EmployeeDataException(string message) : base(message)
        {

        }
    }
}
