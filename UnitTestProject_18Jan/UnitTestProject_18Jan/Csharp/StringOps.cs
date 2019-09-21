using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_18Jan.Csharp
{
    [TestFixture]
    class StringOps
    {
        [Test]
        public void StringMethod() { 
        String s1 = "Srikanth is getting married";
            Console.WriteLine("Length of string s1 - " + s1.Length);
            Console.WriteLine("Conver to UpperCase : " + s1.ToLower());
            Console.WriteLine("Conver to UpperCase : " + s1.ToUpper());
            String browser = "chrome";
            if (browser.Equals("chrome"))
            {
                Console.WriteLine("Launching Chrome");
            }
            bool IsMarried = !s1.Contains("married");
            bool startsWith = s1.StartsWith("i");
            bool endsWith = s1.EndsWith("married");
            bool UpperCheck =s1.ToUpper().EndsWith("MARRIED");
            Console.WriteLine(String.Concat(s1,browser));
            Console.WriteLine(s1.Substring(3)); //starts 0,1,2 --> pick starting from index 3 character- 
            Console.WriteLine(s1.Substring(3, 6));
            int posOfn = s1.IndexOf("n");
            Console.WriteLine(s1.IndexOf("n"));
            String price = "10000.5";
            double dprice = Double.Parse(price);
            String sprice = dprice.ToString();
            String dollarprice = "$100";
            String s3 =dollarprice.Replace("$", "");
            Console.WriteLine(s3.Trim());
            String browser1 = "  chrome ";
            if (browser1.Trim().Equals(browser))
            { 

            }
            String[] sarr = s1.Split(' ');
            for(int i = 0; i < sarr.Length; i++)
            {
                Console.WriteLine(sarr[i]);
            }

            double d = 50000.67;
            int y = (int)d;
            Console.WriteLine(y);





                
        }
    }
}

