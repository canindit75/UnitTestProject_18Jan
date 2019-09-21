using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    public class Selenium_Basics
    {
        [Test]
        public void FirstTestMethod()
        {
            Console.WriteLine("Selenium C#");
            //Declare variables
            int i;
            i= 100;
            float price = 34.5f;
            double totalprice = 45000.5;
            char c = 'r';
            bool flag = true;
            i = 200;
            Console.WriteLine("Value of i = " + i);
            Console.WriteLine("Value of price = " + price);
            Console.WriteLine("Value of total price = " + totalprice);
            Console.WriteLine("Value of c = " + c);
            Console.WriteLine("Value of flag = " + flag);




        }
    }
}
