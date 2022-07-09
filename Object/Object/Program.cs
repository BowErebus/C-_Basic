using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "BowErebus";

            int value = 100;

            object objectValue = value;

            int newValue = (int)objectValue;

            Console.ReadKey();
        }
    }
}