using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{   [TestFixture]
    class ExceptionHandlingExample
    {
        [Test]
        public void ExceptionTest() {
            try
            {
                int num1 = 45;
                int num2 = 0;
                int num = num1 / num2;
                int[] arr = new int[5];
                arr[5] = 56;
                String s = null;
                Console.WriteLine(s.Length);
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Arithmetic Exception - Divide By Zero");
                Console.WriteLine(e.Message + " " + e.Source);
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Index out of Bounds Exception");
                Console.WriteLine(e.Message + " " + e.Source);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception");
                Console.WriteLine(e.Message + " " + e.Source);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.Source);                
            }
    }

    }
}
