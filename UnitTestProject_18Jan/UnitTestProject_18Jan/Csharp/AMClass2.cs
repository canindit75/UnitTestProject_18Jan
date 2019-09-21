using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    class AMClass2
    {
        [Test]
        public void TestPrivateMethodAMClass2()
        {
            AMClass1 am1 = new AMClass1();
            Console.WriteLine(am1.var1);
            am1.method1();
        }
    }
}
