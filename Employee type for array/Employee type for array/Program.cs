using Employee_type_for_array.Models;
using System;

namespace Employee_type_for_array
{
   public class Program
    {
        static void Main(string[] args)
        {

            DateTime start = DateTime.Now.AddDays(-10);
            DateTime end = DateTime.Now.AddDays(30);

            var result = GetEmpployeeCount(start, end);
            Console.WriteLine(result);
          

        }
        public static int GetEmpployeeCount(DateTime start, DateTime end)
        {
            Employee emp1 = new Employee(DateTime.Now.AddDays(10), 2000);
            Employee emp2 = new Employee(DateTime.Now.AddDays(20), 3000);
            Employee emp3 = new Employee(DateTime.Now.AddDays(-10), 3000);
            Employee emp4 = new Employee(DateTime.Now.AddDays(2), 1000);
            Employee emp5 = new Employee(DateTime.Now.AddDays(15), 5000);

            Employee[] employees = { emp1, emp2, emp3, emp4, emp5 };
            int empCount = 0;

            foreach (var item in employees)
            {
                if (item.Birthday > start && item.Birthday < end && item.Salary > 2000)
                    empCount++;
            }
            return empCount;
        }
    }
}
