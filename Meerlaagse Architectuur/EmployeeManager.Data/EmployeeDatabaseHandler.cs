using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EmployeeManager.Data
{
    public class EmployeeDatabaseHandler
    {
        private string connectionString = "server=meelsnet.nl;user id=root;database=demo;password=Rsam.0255!;";

        public List<EmployeeDto> GetAllEmployees()
        {
            List<EmployeeDto> employees = new List<EmployeeDto>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Employee";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeeDto dto = new EmployeeDto();
                            dto.PersonnelNumber = reader.GetInt32(0);
                            dto.FirstName = reader.GetString(1);
                            dto.LastName = reader.GetString(2);
                            dto.DateOfBirth = reader.GetDateTime(3);
                            dto.StartDate = reader.GetDateTime(4);

                            employees.Add(dto);
                        }
                    }
                }
            }
            catch (MySqlException sex)
            {
                throw new EmployeeDataException(sex.Message);
            }
            
            return employees;
        }

    }
}
