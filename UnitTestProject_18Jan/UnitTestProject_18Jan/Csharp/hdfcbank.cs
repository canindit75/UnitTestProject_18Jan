using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject_18Jan.Csharp
{
    class hdfcbank : Bank
    {
        public void credit()
        {
            Console.WriteLine("hdfcbank - credit");
        }

        public void debit()
        {
            Console.WriteLine("hdfcbank - debit");
        }

        public void transfermoney()
        {
            Console.WriteLine("hdfcbank - transfermoney");
        }

        public void hdfcROI()
        {
            Console.WriteLine("hdfcbank - hdfcROI");
        }
    }
}
