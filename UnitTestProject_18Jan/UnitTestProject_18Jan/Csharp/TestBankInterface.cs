using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    class TestBankInterface
    {
        [Test]
        public void BankInterfaceTest()
        {
            //Creating an instance of hdfcbank
            hdfcbank hdfc = new hdfcbank();
            hdfc.credit();
            hdfc.debit();
            hdfc.transfermoney();
            hdfc.hdfcROI();
            axisbank axis = new axisbank();
            axis.axisBalance();
            axis.credit();
            axis.debit();
            axis.transfermoney();
            Bank b = new hdfcbank();
            b.credit();
            b.debit();
            b.transfermoney();
            b = new axisbank();
            b.credit();
            b.debit();
            b.transfermoney();



        }
    }
}
