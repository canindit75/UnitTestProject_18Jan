using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestProject_18Jan.Csharp;
namespace UnitTestProject_18Jan.Selenium
{
    [TestFixture]
    class AMClass3
    {

        [Test]
        public void TestPrivateMethodAMClass3()
        {
            AMClass1 am1 = new AMClass1();
            Console.WriteLine(am1.var1);
            am1.method1();
        }

    }
}
