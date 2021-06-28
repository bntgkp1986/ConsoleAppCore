using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    class Program
    {
        
        static async Task Main(string[] args)
        {
            var employee = new Employee();
            //if(employee.Insert() > 0)
            //{
            //    Console.WriteLine("Inserted successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong.");
            //}

            //var listOfEmployee = await employee.Select();

            var listOfEmployee = await employee.Select1();

            foreach (var item in listOfEmployee)
            {
                Console.WriteLine($"Employee's details - name -  {item.Name} address - {item.Address}  Salary - {item.Salary}  and Department is - {item.Department}");
            }

            Console.WriteLine("Hello world!!");
            Console.ReadLine();
        }
    }
}
