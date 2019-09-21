using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    class Car : Vehicle
    {
        //long speed = 50;
        //public void getSpeed()
        //{
        //    Console.WriteLine("Car Class - getSpeed Method");
        //}
        [Test]
        public void TestCar()
        {
            Car c1 = new Car();
            c1.getSpeed();
            Console.WriteLine(c1.speed);
        }
    }
}
