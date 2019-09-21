using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    class ExceptionExample
    {
        [Test]
        public void ExceptionTestMethod()
        {
            try
            {
                int num1 = 45;
                int num2 = 9;
                int num = num1 / num2;
                int[] arr = new int[5];
                arr[4] = 56;
                String s = null;
                Console.WriteLine(s.Length);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Divide by Zero Exception");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index Out of Range Exception");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
        }

    }
}
