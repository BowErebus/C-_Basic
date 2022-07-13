using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetitive_Structures
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Goto

            #region Ex1

            //int a = 1;
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("Case 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Case 2");
            //        goto case 1;
            //        break;
            //    case 3:
            //        Console.WriteLine("Case 3");
            //        break;
            //}

            //Console.ReadKey();

            #endregion

            #region Ex2

            //int a = 2;
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("Case 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Case 2");
            //        goto case 1;
            //        break;
            //    case 3:
            //        Console.WriteLine("Case 3");
            //        break;
            //}

            //Console.ReadKey();

            #endregion

            #region Ex3

            //int a = 1;

            //if(a == 2)
            //{
            //    goto a_Is_2;
            //}

            //Console.WriteLine("A == 1");
            //a_Is_2:
            //Console.WriteLine("A == 2");

            //Console.ReadKey();

            #endregion

            #region Ex4

            //int a = 2;

            //if(a == 2)
            //{
            //    goto a_Is_2;
            //}

            //Console.WriteLine("A == 1");
            //a_Is_2:
            //Console.WriteLine("A == 2");

            //Console.ReadKey();

            #endregion

            #region Ex5

            //int a = 1;

            //Ifinity_Loop:

            //if (a == 2)
            //{
            //    goto a_Is_2;
            //}

            //Console.WriteLine("A == 1");
            //a_Is_2:
            //Console.WriteLine("A == 2");
            //goto Ifinity_Loop;

            #endregion

            #region Ex6

            //string bowErebusstr = "BowErebus";

            //int count = 0;

            //beginLoop:

            //Console.WriteLine(bowErebusstr);

            //count++;

            //if (count < 10)
            //    goto beginLoop;

            //Console.ReadKey();

            //Console.WriteLine("End Loop");

            #endregion

            #endregion

            #region For

            //int N = 20;
            //int M = 40;
            //char drawChar = '@';
            //char insideChar = '-';

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < M; j++)
            //    {
            //        if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkRed;
            //            Console.Write(drawChar);
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.Write(insideChar);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            #endregion

            #region While

            #region Ex1

            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int loopTime = 5;

            //while (countLoopTime < loopTime)
            //{
            //    countLoop = 0;
            //    while (countLoop < valueNum)
            //    {
            //        Console.Write("{0,8}", countLoop);
            //        countLoop++;
            //    }
            //    Console.WriteLine();
            //    countLoopTime++;
            //}

            //Console.ReadKey();

            #endregion

            #region Ex2

            //int count = 0;

            //while (count < 10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}

            //Console.ReadKey();

            #endregion

            #region Ex3

            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int loopTime = 5;
            //int minRandomValue = 0;
            //int maxRandomValue = 100;

            //Random rand = new Random();

            //while (countLoopTime < loopTime)
            //{
            //    countLoop = 0;
            //    while (countLoop < valueNum)
            //    {
            //        int showValue = rand.Next(minRandomValue, maxRandomValue);
            //        Console.Write("{0,8}", showValue);
            //        countLoop++;
            //    }
            //    Console.WriteLine();
            //    countLoopTime++;
            //}

            //Console.ReadKey();

            #endregion

            #region Ex4

            //int Vertical = 10;
            //int Horizontal = 20;
            //char drawChar = '=';
            //char insideChar = ' ';
            //int countLoopVertical = 0;
            //int countLoopHorizontal = 0;

            //while (countLoopVertical < Vertical )
            //{
            //    countLoopHorizontal = 0;
            //    while (countLoopHorizontal < Horizontal)
            //    {
            //        if (countLoopVertical % (Vertical - 1) == 0 || ((countLoopVertical % (Vertical - 1) != 0) && (countLoopHorizontal % (Horizontal - 1) == 0)))
            //        {
            //            Console.Write(drawChar);
            //        } 
            //        else
            //        {
            //            Console.Write(insideChar);
            //        }
            //        countLoopHorizontal++;
            //    }
            //    Console.WriteLine();
            //    countLoopVertical++;
            //}

            //Console.ReadKey();

            #endregion

            #endregion

            #region Do While

            #region Ex1

            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int looptime = 5;

            //do
            //{
            //    countLoop = 0;
            //    while (countLoop < valueNum)
            //    {
            //        Console.Write("{0,8}", countLoop);
            //        countLoop++;
            //    }
            //    Console.WriteLine();
            //    countLoopTime++;
            //} while (countLoopTime < looptime);

            //Console.ReadKey();

            #endregion

            #region Ex2

            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int loopTime = 5;
            //int minRandomValue = 0;
            //int maxRandomValue = 100;

            //Random rand = new Random();

            //do
            //{
            //    countLoop = 0;
            //    do
            //    {
            //        int showValue = rand.Next(minRandomValue, maxRandomValue);
            //        Console.Write("{0,8}", showValue);
            //        countLoop++;
            //    } while (countLoop < valueNum);
            //    Console.WriteLine();
            //    countLoopTime++;
            //} while (countLoopTime < loopTime);

            //Console.ReadKey();

            #endregion

            #region Ex3

            //int Vertical = 20;
            //int Horizontal = 50;
            //char drawChar = '=';
            //char insideChar = ' ';
            //int countLoopVertical = 0;
            //int countLoopHorizontal = 0;

            //do
            //{
            //    countLoopHorizontal = 0;

            //    // Vẽ từ trái sang
            //    do
            //    {
            //        if (countLoopVertical % (Vertical - 1) == 0 || ((countLoopVertical % (Vertical - 1) != 0) && (countLoopHorizontal % (Horizontal - 1) == 0)))
            //        {
            //            Console.Write(drawChar);
            //        }
            //        else
            //        {
            //            Console.Write(insideChar);
            //        }
            //        countLoopHorizontal++;
            //    } while (countLoopHorizontal < Horizontal);
            //    Console.WriteLine();
            //    countLoopVertical++;
            //} while (countLoopVertical < Vertical);

            //Console.ReadKey();

            #endregion

            #endregion
        }
    }
}