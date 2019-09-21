using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    public class employee
    {
        public int empid;
        public string empname;
        public string companyname;
    
        public void displayEmployeeDetails()
        {
            Console.WriteLine("empid = " + empid + " empanme = " + empname + " company = " + companyname);
        }
        public void insertEmployeeRecord(int id,string name, string company)
        {
            empid = id;
            empname = name;
            companyname = company;
        }
        [Test]
        public void employeeTest()
        {
            employee e1 = new employee();
            e1.insertEmployeeRecord(1000, "Ravi", "Fiserv");
            e1.displayEmployeeDetails();
            employee e2 = new employee();
            e2.insertEmployeeRecord(1001, "Amit", "Capgemini");
            e2.displayEmployeeDetails();
            employee e3 = new employee();
            e3.empid = 1002;
            e3.empname = "Raji";
            e3.companyname = "Siemens";
            e3.displayEmployeeDetails();
            employee e4 = new employee();
            e4.displayEmployeeDetails();

        }
    }
}
