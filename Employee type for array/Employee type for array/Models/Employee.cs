using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_type_for_array.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; } 
        public double Salary { get; set; }
        public Employee(DateTime birthday,double salary)
        {
            Birthday = birthday;
            Salary = salary;
        }
    }
}
