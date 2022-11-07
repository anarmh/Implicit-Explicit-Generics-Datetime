using Microsoft.VisualBasic.CompilerServices;
using System;



namespace Employee_type_for_array.Models
{
    public class Employee
    {
        Employee[] _employees;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public double Salary { get; set; }
        static int Count = 0;
        public Employee(string name,string surname,DateTime birthday,double salary)
        {
            _employees = new Employee[0];
            Birthday = birthday;
            Name = name;
            Surname = surname;
            Salary = salary;
        }
        public int EmployeeCount(DateTime start,DateTime end,double salary)
        {
            if (start < Birthday && Birthday < end && salary > 2000)
            {
                Count++;
            }
            return Count;
        }
    }
}
