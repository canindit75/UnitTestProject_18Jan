using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject_18Jan.Csharp
{
    class axisbank : Bank
    {
        public void credit()
        {
            Console.WriteLine("axisbank - credit");
        }

        public void debit()
        {
            Console.WriteLine("axisbank - debit");
        }

        public void transfermoney()
        {
            Console.WriteLine("axisbank - transfermoney");
        }

        public void axisBalance()
        {
            Console.WriteLine("axisbank - axisBalance");
        }
    }
}
