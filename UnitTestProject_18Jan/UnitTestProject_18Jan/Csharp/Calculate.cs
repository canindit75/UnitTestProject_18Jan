using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    class Calculate
    {
        //public void sum(int n1, int n2)
        //{
        //    Console.WriteLine("sum(int n1,int n2");
        //}


        public void sum(int n1, int n2, int n3)
        {
            Console.WriteLine("sum(int n1,int n2, int n3)");
        }

        public void sum(double n1, double n2)
        {
            Console.WriteLine("sum(double n1,int n2");
        }
        [Test]
        public void MethodOverloadTest()
        {
            Calculate c1 = new Calculate();
            c1.sum(10, 10);
            c1.sum(20, 340, 50);
            c1.sum(10.5, 45.5);
        }
    }
}
