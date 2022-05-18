using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int Integer_Type = 5;
            float Variable_Of_Type_Real_Number = 6.9f;
            string String_Variable = "Bow";
            bool Logical_Type_Variable = true;
            char Character_Type_Variable = 'B';

            int aNum = 6;
            int bNum = 7;
            int cNum = aNum + bNum;

            Console.WriteLine("a + b = c : {0} + {1} = {2}", aNum, bNum, cNum);

            Console.ReadKey();
        }
    }
}