using Employee_type_for_array.Models;
using System;

namespace Employee_type_for_array
{
   public class Program
    {
        static void Main(string[] args)
        {
           
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMonths(10);

            EmployeeList<Employee>employee = new EmployeeList<Employee>(start,end,3000);
            employee.Add(new Employee { Name = "Anar" });
            employee.Add(new Employee { Surname = "Huseynov" });
            employee.Add(new Employee { Birthday = "12.02.2023" });
            employee.Add(new Employee { Salary = 2500 });

            employee.Add(new Employee { Name = "Cavid" });
            employee.Add(new Employee { Surname = "Rzayev" });
            employee.Add(new Employee { Birthday = "15.10.2022" });
            employee.Add(new Employee { Salary = 800 });
            var resultemployee= employee.GetAll();
            foreach (var item in resultemployee)
            {
                Console.WriteLine(item.Birthday);
            }
             
            
        }
    }
}
