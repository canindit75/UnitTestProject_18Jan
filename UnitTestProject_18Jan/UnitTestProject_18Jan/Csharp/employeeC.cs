using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    public class employeeC
    {
        public int empid;
        public string empname;
        public string companyname;
        //Example of Default Constructor    
        public employeeC()
        {
            Console.WriteLine("Default Constructor Created");
        }
        //Example of Parameterized Constructor
        public employeeC(int empid, string empname, string companyname)
        {
            Console.WriteLine("Calling Parameterized Constructor");
            this.empid = empid;
            this.empname = empname;
            this.companyname = companyname;
        }

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
        public void employeeParamConstTest()
        {
            employeeC e1 = new employeeC(1000, "Ravi", "Fiserv");            
            e1.displayEmployeeDetails();
            employeeC e2 = new employeeC(1001, "Amit", "Capgemini");
            e2.displayEmployeeDetails();
            employeeC e3 = new employeeC();
            e3.empid = 1002;
            e3.empname = "Raji";
            e3.companyname = "Siemens";
            e3.displayEmployeeDetails();
            employeeC e4 = new employeeC();
            e4.displayEmployeeDetails();

        }

        [Test]
        public void employeeCTest()
        {
            employeeC e1 = new employeeC();
            e1.insertEmployeeRecord(1000, "Ravi", "Fiserv");
            e1.displayEmployeeDetails();
            employeeC e2 = new employeeC();
            e2.insertEmployeeRecord(1001, "Amit", "Capgemini");
            e2.displayEmployeeDetails();
            employeeC e3 = new employeeC();
            e3.empid = 1002;
            e3.empname = "Raji";
            e3.companyname = "Siemens";
            e3.displayEmployeeDetails();
            employeeC e4 = new employeeC();
            e4.displayEmployeeDetails();

        }
    }
}
