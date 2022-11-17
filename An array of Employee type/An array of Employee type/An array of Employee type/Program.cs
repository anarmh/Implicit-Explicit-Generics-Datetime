using An_array_of_Employee_type.Models;
using System;

namespace An_array_of_Employee_type
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now.AddDays(-10);
            DateTime end = DateTime.Now.AddDays(30);

            var result = GetEmployeeCount(start, end);
            Console.WriteLine(result);

        }
        public static int GetEmployeeCount(DateTime start, DateTime end)
        {

            Person person1 = new Person(DateTime.Now.AddDays(3), 2000);
            Person person2 = new Person(DateTime.Now.AddDays(15), 1000);
            Person person3 = new Person(DateTime.Now.AddDays(-5), 3000);
            Person person4 = new Person(DateTime.Now.AddDays(25), 4000);

            Person[] people = { person1, person2, person3, person4 };
            int empCount = 0;
            foreach (var item in people)
            {
                if (item.Birthday > start && item.Birthday < end && item.Salary > 2000)
                {
                    empCount++;
                }
            }
            return empCount;
        }
    }
    

        

       
        
    
}
