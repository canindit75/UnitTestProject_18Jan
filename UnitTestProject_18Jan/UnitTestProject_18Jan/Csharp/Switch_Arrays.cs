using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    public class Switch_Arrays
    {
        [Test]
        public void Switch_ArrayExample()
        {
            Console.WriteLine("Example of Switch Statement");
            int weekday = 60;
            switch (weekday)
            {
                case 0: { Console.WriteLine("Monday"); break; }
                case 1: Console.WriteLine("Tuesday");break;
                case 2: Console.WriteLine("Wednesday");break;
                case 3: Console.WriteLine("Thursday"); break;
                case 4: Console.WriteLine("Friday"); break;
                case 5: Console.WriteLine("Saturday"); break;
                case 6: Console.WriteLine("Sunday");break;
                default: Console.WriteLine("Invalid Weekday");break;
            }

            Console.WriteLine("Example of Single Dimensional Arrays");
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 34;
            arr[2] = 45;
            arr[3] = 56;
            arr[4] = 90;
            //Print the values in array to the Console
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr["+i+"] ="+ arr[i]);
                //if(arr[i] == 45)
                //{
                //    Console.WriteLine("Match found for 45 at index position " + i);
                //    break;                    
                //}
            }

            Console.WriteLine("Example of Two Dimensional Array");
            int[,] mat = new int[4,2];
            //first dimension represents number of rows
            //second dimension represents number of cols
            Console.WriteLine(mat.Length); //3*2 --> total number of elements
            Console.WriteLine("first/row dimension size : " +mat.GetLength(0));
            Console.WriteLine("second/column dimension size : " +mat.GetLength(1));
            for (int r = 0; r < mat.GetLength(0); r++)
            {
                for(int c = 0; c < mat.GetLength(1); c++)
                {
                    mat[r, c] = r + c;
                    Console.WriteLine("mat["+r+","+ c+"] ="+ mat[r, c]);
                }
            }



        }
    }
}
