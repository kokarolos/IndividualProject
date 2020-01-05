using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2020, 1, 15);
            DateTime dt2 = new DateTime(2020, 1, 17);
            var dt = dt1 - dt2;
            Console.WriteLine(dt.Days);
        }
    }
}
