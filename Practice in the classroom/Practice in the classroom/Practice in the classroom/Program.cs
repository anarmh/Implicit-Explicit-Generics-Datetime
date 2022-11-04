using Practice_in_the_classroom.Models;
using System;

namespace Practice_in_the_classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit-Explicit
            //    Manat manat = new Manat(200);
            //    Dollar dollar = manat;
            //    Console.WriteLine(dollar.Usd);
            //DateTime date = DateTime.Now;
            //Console.WriteLine(date.ToString("MM/dd/yyyy HH:mm"));
            #endregion
            #region MyRegion
            //StringList list = new StringList();
            //list.Add("Anar");
            //list.Add("Tunar");
            //list.Add("Elnar");
            //list.GetAll();
            //IntList ages = new IntList();
            //ages.Add(35);
            //ages.Add(5);
            //ages.Add(4);
            //ages.GetAll();
            //BookList books = new BookList();
            //books.Add(new Book { Name = "CSS" });
            //books.Add(new Book { Name = "C++" });
            //books.Add(new Book { Name = "C#" });
            //books.GetAll();

            //DataList<int> ages = new DataList<int>();
            //ages.Add(35);
            //ages.Add(5);
            //ages.Add(4);

            //var resultsages = ages.GetAll();
            //foreach (var item in resultsages)
            //{
            //    Console.WriteLine(item);
            //}

            //DataList<string> list = new DataList<string>();
            //list.Add("Anar");
            //list.Add("Tunar");
            //list.Add("Elnar");
            //list.GetAll();

            //DataList<Book> books = new DataList<Book>();
            //books.Add(new Book { Name = "CSS" });
            //books.Add(new Book { Name = "C++" });
            //books.Add(new Book { Name = "C#" });
            //books.GetAll();
            #endregion
            //Repository<int> number = new Repository<int>();
            //Repository<string> name = new Repository<string>();
            //Repository<Student> student= new Repository<Student>();
            //Repository<double> Double= new Repository<double>();
            //Repository<Employee> employee = new Repository<Employee>();

            //Repository<Student,Person> student1 = new Repository<Student,Person>();
            //Repository<Employee,Common> employee1 = new Repository<Employee,Common>();

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddDays(10);
            //Console.WriteLine($"start date:{start}-end date {end}");
            GetProductsByDate(start, end,800);
        }
        public  static void GetProductsByDate(DateTime start,DateTime end,double price)
        {
            DateTime productate=DateTime.Now.AddDays(-20);
            if (productate>start && productate > end&& price>1000)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
           
        }


    }

    //public class DataList<T>
    //{
    //   T[] _datas;
    //    public DataList()
    //    {
    //        _datas = new T[0];
    //    }
    //    public void Add(T type)
    //    {
    //        Array.Resize(ref _datas, _datas.Length + 1);
    //        _datas[_datas.Length - 1] = type;
    //    }
    //    //public void GetAll()
    //    //{
    //    //    for (int i = 0; i < _datas.Length; i++)
    //    //    {
    //    //        Console.WriteLine(_datas[i]);
    //    //    }
    //    //}
    //    public T[] GetAll()
    //    {
    //        return _datas;
    //    }

    //}
    //public class IntList
    //{
    //    int[] _arr;
    //    public IntList()
    //    {
    //        _arr = new int[0];
    //    }
    //    public void Add(int num)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);
    //        _arr[_arr.Length - 1] = num;
    //    }
    //    public void GetAll()
    //    {
    //        for (int i = 0; i < _arr.Length; i++)
    //        {
    //            Console.WriteLine(_arr[i]);
    //        }
    //    }


    //}
    //public class StringList
    //{
    //    String[] _arr;
    //    public StringList()
    //    {
    //        _arr = new String[0];
    //    }
    //    public void Add(String str)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);
    //        _arr[_arr.Length - 1] = str;
    //    }
    //    public void GetAll()
    //    {
    //        for (int i = 0; i < _arr.Length; i++)
    //        {
    //            Console.WriteLine(_arr[i]);
    //        }
    //    }

    //}
    //public class BookList
    //{
    //    Book[] _arr;
    //    public BookList()
    //{
    //    _arr = new Book[0];
    //}
    //public void Add(Book book)
    //{
    //    Array.Resize(ref _arr, _arr.Length + 1);
    //    _arr[_arr.Length - 1] =book;
    //}
    //public void GetAll()
    //{
    //    for (int i = 0; i < _arr.Length; i++)
    //    {
    //        Console.WriteLine(_arr[i].Name);
    //    }
    //}

}










public class Dollar
    {
        #region Implicit-Excplicit
    //    public double Usd { get; set; }
    //    public Dollar(double usd)
    //    {
    //        Usd = usd;
    //    }
    //}
    //public class Manat
    //{
    //    public double Azn { get; set; }
    //    public Manat(double azn)
    //    {
    //        Azn = azn;
    //    }

    //    public static implicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.Azn / 1.7);
    //    }
        #endregion


    }

