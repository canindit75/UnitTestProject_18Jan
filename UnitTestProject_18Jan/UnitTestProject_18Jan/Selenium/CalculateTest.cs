using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitClassLibrary_18Jan;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Selenium
{ 
    [TestFixture]
    public class CalculateTest
    {
        [Test]
        public void AdditionTests()
        {
            Calculate cal = new Calculate();
            cal.Addition(10, 5);
            Console.WriteLine("Testing 10+5");
            Assert.AreEqual(15, cal.Output());
            cal.Addition(-5, 10);
            Console.WriteLine("Testing -5+10");
            //Assert.AreEqual(15, cal.Output());
        }
        [Test]
        public void DivisionTests()
        {
            Calculate cal = new Calculate();
            cal.Division(10, 5);
            Console.WriteLine("Testing 10/5");
            Assert.AreEqual(2, cal.Output());
            //cal.Division(-10, 0);
            //Console.WriteLine("Testing -10/0");
            Assert.AreEqual(2, cal.Output());

        }
    
    }
}
