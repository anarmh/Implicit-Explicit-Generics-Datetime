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
        public string Birthday { get; set; } = "12.02.2023";
        public double Salary { get; set; }
    }
}
