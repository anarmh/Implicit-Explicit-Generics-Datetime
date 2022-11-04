using Implisit_operation_for_Celcius.Models;
using System;

namespace Implisit_operation_for_Celcius
{
   public class Program
    {
        static void Main(string[] args)
        {
           
            Kelvin kelvin = new Kelvin(600);
            Celcius celcius = kelvin;
            Console.WriteLine(celcius.Degree);
            
        }
    }
}
