using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTestProject_18Jan.Selenium
{
    [TestFixture]
    class XpathAttributePatternMatch
    {
        [Test]
        public void XPathPatternMatch()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            Console.WriteLine("Pattern Match on Attribute value id starting with c using xpath");
            IList<IWebElement> startswithcxpath = driver.FindElements(By.XPath("//*[starts-with(@id,'c')]"));
            foreach(IWebElement element in startswithcxpath) {
                Console.WriteLine(element.GetAttribute("id"));
            }

            Console.WriteLine("Pattern Match on Attribute value name containing with height using xpath");
            IList<IWebElement> containsheightxpath = driver.FindElements(By.XPath("//*[contains(@name,'height')]"));
            foreach (IWebElement element in containsheightxpath)
            {
                Console.WriteLine(element.GetAttribute("name"));
            }

        }
    }
}
