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

            Employee employee1 = new Employee("Anar","Huseynov",DateTime.Parse("12/02/2023"),2500);
            Employee employee2 = new Employee("Cavid","Rzayev",DateTime.Parse("18/11/2022"),4000);
            Employee employee3 = new Employee("Rafael","Babaverdiyev",DateTime.Parse("15/03/2023"),3000);

            Employee[] employees = { employee1, employee2, employee3 };
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Name} {item.Surname} {item.Birthday} {item.Salary}");
            }
            Console.WriteLine(employee1.EmployeeCount(start,end,2500));
           
        }
    }
}
