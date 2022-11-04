using Practice_in_the_classroom.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_in_the_classroom.Models
{
   public class Studen:Person,ITest
    {
        public string Teacher { get; set; }
    }
}
