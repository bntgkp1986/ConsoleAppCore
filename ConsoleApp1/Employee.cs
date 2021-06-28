using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Insert()
        {
            ConnectionManager connection = new ConnectionManager();
            SqlCommand command = new SqlCommand();
            command.Connection = connection.OpenSqlConnection();
            command.CommandText = "INSERT INTO Employee(Name, Address, Salary, Department) values('" + "Akhilesh Nath Tripathi" + "','" + "Noida" + "','" + 50000 + "','" + "IT" + "')";
            command.CommandType = System.Data.CommandType.Text;
            int result = command.ExecuteNonQuery();
            connection.CloseSqlConnection();
            return result;
        }

        public List<EmployeeBo> Select()
        {
            ConnectionManager connection = new ConnectionManager();
            SqlCommand command = new SqlCommand();
            var employees = new List<EmployeeBo>();
            command.Connection = connection.OpenSqlConnection();
            command.CommandText = "SELECT * FROM Employee";
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader result = command.ExecuteReader();
            float salary=0F;
            if (result.HasRows)
            {
                while (result.Read())
                {
                    var employee = new EmployeeBo()
                    {
                        Id = Convert.ToInt32(result["Id"]),
                        Name = result["Name"].ToString(),
                        Address = result["Address"].ToString(),
                        Salary = float.TryParse(result["Salary"].ToString(), out salary) == true ? salary:0F,
                        Department = result["Department"].ToString()
                    };
                    employees.Add(employee);
                }
            }
            connection.CloseSqlConnection();
            return employees;
        }
    }

    public class EmployeeBo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }
        public string Department { get; set; }
    }
}
