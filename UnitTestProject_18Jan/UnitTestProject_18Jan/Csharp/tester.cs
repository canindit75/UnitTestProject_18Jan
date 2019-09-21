using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    class tester : employee
    {
        [Test]
        public void TestTester()
        {
            tester t1 = new tester();
            t1.insertEmployeeRecord(1003, "Kamal", "Samsung");
            t1.displayEmployeeDetails();
            tester t2 = new Csharp.tester();
            t2.empid = 1004;
            t2.empname = "Kajal";
            t2.companyname = "Unisys";
            t2.displayEmployeeDetails();
        }
    }
}
