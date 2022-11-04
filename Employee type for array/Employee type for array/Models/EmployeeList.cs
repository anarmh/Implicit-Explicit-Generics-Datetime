using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_type_for_array.Models
{
    public class EmployeeList<T>
    {
        T[] __datas;
        public EmployeeList(DateTime start, DateTime end, double salary)
        {
            __datas = new T[0];
            DateTime date = Convert.ToDateTime("12.02.2023");
            int count = 0;
            if (date > start || date < end || salary > 2000)
            {
                count++;
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("There is no such thing");
            }

        }
        public void Add(T data)
        {
            Array.Resize(ref __datas, __datas.Length + 1);
            __datas[__datas.Length - 1] = data;
        }
        public T[] GetAll()
        {
            return __datas;
        }

    }
}

