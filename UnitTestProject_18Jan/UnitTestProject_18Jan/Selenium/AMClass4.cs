using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject_18Jan.Csharp;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Selenium
{
    class AMClass4 :AMClass1
    {
        [Test]
        public void TestPrivateMethodAMClass4()
        {
            AMClass4 am4 = new AMClass4();
            Console.WriteLine(am4.var1);
            am4.method1();
        }

    }
}
