using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeeze_Style 
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit

            //int k = 1;
            //long l = k;
            //float f = 2.9f;
            //double d = f;

            #endregion

            #region Explicit

            //int i = 300;
            //byte b = (byte)i;

            //Console.WriteLine(" i = " + i);
            //Console.WriteLine(" b = " + b);

            //double d = 2 / 3;
            //double k = (double)2 / 3;
            //double t = 1.0 * 2 / 3;

            //Console.WriteLine(" d = {0} \n k = {1} \n t = {2}", d, k, t);

            //Console.ReadKey();

            #endregion

            #region Parse()

            //string s = "10";
            //int k = int.Parse(s);
            //double e = double.Parse("10.9");

            //Console.WriteLine(" k = " + k);
            //Console.WriteLine(" e = " + e);

            //Console.ReadKey();

            #endregion

            #region TryParse()

            //int Result;
            //bool isSuccess;
            //string Data1 = "10", Data2 = "Bow";

            //isSuccess = int.TryParse(Data1, out Result);
            //Console.Write(isSuccess == true ? " Sucess !" : " Failed !");
            //Console.WriteLine(" Result = " + Result);

            //isSuccess = int.TryParse(Data2, out Result);
            //Console.Write(isSuccess == true ? " Sucess !" : " Failed !");
            //Console.WriteLine(" Result = " + Result);

            //Console.ReadKey();

            #endregion

            #region Convert

            //int a = Convert.ToInt32("9");

            //Console.WriteLine(" a = " + a);

            //Console.ReadKey();

            #endregion

            #region Ex Parse()

            //int A, B;
            //int Sum, Difference, Product;
            //double Quotient;
            //string strA, strB;

            //Console.WriteLine("         ***********************************************************************");
            //Console.WriteLine("         *                                                                     *");
            //Console.WriteLine("         *     Program to calculate Sum, Difference, Product and Quotient      *");
            //Console.WriteLine("         *                                                                     *");
            //Console.WriteLine("         ***********************************************************************");

            //Console.Write("\n Please Enter The Number A: ");
            //strA = Console.ReadLine();
            //Console.Write("\n Please Enter The Number B: ");
            //strB = Console.ReadLine();

            //A = int.Parse(strA);
            //B = int.Parse(strB);

            //Sum = A + B;
            //Difference = A - B;
            //Product = A * B;
            //Quotient = (double)A / B;

            //Console.WriteLine(" Sum = " + Sum);
            //Console.WriteLine(" Difference = " + Difference);
            //Console.WriteLine(" Product = " + Product);
            //Console.WriteLine(" Quotient = " + Quotient);

            //Console.ReadKey();

            #endregion

            #region Ex TryParse()

            //int A, B;
            //int Sum, Difference, Product;
            //double Quotient;
            //string strA, strB;
            //bool isSuccess;

            //Console.WriteLine("         *******************************************************************");
            //Console.WriteLine("         *                                                                 *");
            //Console.WriteLine("         *   Program to calculate Sum, Difference, Product and Quotient    *");
            //Console.WriteLine("         *                                                                 *");
            //Console.WriteLine("         *******************************************************************");

            //Console.Write("\n Please Enter The Number A: ");
            //strA = Console.ReadLine();
            //Console.Write("\n Please Enter The Number B: ");
            //strB = Console.ReadLine();

            //isSuccess = int.TryParse(strA, out A);
            //Console.WriteLine(isSuccess == true ? " Sucess !" : " Failed !");
            //Console.WriteLine(" A = " + A);

            //isSuccess = int.TryParse(strB, out B);
            //Console.WriteLine(isSuccess == true ? " Sucess !" : " Failed !");
            //Console.WriteLine(" B = " + B);

            //Sum = A + B;
            //Difference = A - B;
            //Product = A * B;
            //Quotient = (double)A / B;

            //Console.WriteLine(" Sum = " + Sum);
            //Console.WriteLine(" Difference = " + Difference);
            //Console.WriteLine(" Product = " + Product);
            //Console.WriteLine(" Quotient = " + Quotient);

            //Console.ReadKey();

            #endregion
        }
    }
}