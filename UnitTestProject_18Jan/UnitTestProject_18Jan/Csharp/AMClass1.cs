using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    class AMClass1
    {
        public int var1=10;

        public void method1()
        {
            Console.WriteLine("AMClass1 - method1");
        }
        [Test]
        public void TestPrivateMethodAMClass1()
        {
            AMClass1 am1 = new AMClass1();
            Console.WriteLine(am1.var1);
            am1.method1();
        }
    }
}
