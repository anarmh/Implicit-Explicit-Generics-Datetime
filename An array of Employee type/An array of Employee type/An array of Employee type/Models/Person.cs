using System;
using System.Collections.Generic;
using System.Text;

namespace An_array_of_Employee_type.Models
{
   public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public double Salary { get; set; }
        public Person(DateTime birthday,double salary)
        {
            Birthday = birthday;
            Salary = salary;
        }
    }
}
