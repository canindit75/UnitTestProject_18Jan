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
    class LocateByCss
    {
        [Test]
        public void LocateElementsInCSS()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //Absolute CSS
            //IWebElement ageLabel = driver.FindElement(By.CssSelector("html > body > div:nth-child(3) > div:nth-child(1) > div:nth-child(5) > table:nth-child(1) > tbody > tr:nth-child(1) > td:nth-child(1)"));
            //Console.WriteLine("Age Label Text : " + ageLabel.Text);
            //Relative Xpath
            IWebElement ageLabel1 = driver.FindElement(By.CssSelector("table#calinputtable>tbody>tr:nth-child(1)>td:nth-child(1)"));
            Console.WriteLine("Age Label Text : " + ageLabel1.Text);

            Console.WriteLine("Pattern Match on Attribute value id starting with c using css selectors");
            IList<IWebElement> startswithccss = driver.FindElements(By.CssSelector("[id^='c']"));
            foreach (IWebElement element in startswithccss)
            {
                Console.WriteLine(element.GetAttribute("id"));
            }

            Console.WriteLine("Pattern Match on Attribute value name containing with height using CSS");
            IList<IWebElement> containsheightcss = driver.FindElements(By.CssSelector("[name*='height']"));
            foreach (IWebElement element in containsheightcss)
            {
                Console.WriteLine(element.GetAttribute("name"));
            }



        }
    }
}
