using System;
using System.Collections.Generic;
using System.Text;

namespace Implisit_operation_for_Celcius.Models
{
    public class Celcius
    {
        public double Degree { get; set; }
        public Celcius(double degree)
        {
            Degree = degree;
        }
    }
}
