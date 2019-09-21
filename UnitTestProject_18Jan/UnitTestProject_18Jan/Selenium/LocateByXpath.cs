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
    class LocateByXpath
    {
        [Test]
        public void LocateXpath() { 
        ChromeDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //Absolute Xpath
            IWebElement ageLabel = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[5]/table[1]/tbody/tr[1]/td[1]"));
            Console.WriteLine("Age Label Text : " + ageLabel.Text);
            //Relative Xpath
            IWebElement ageLabel1 = driver.FindElement(By.XPath("//table[@id='calinputtable']/tbody/tr[1]/td[1]"));
            Console.WriteLine("Age Label Text : " + ageLabel1.Text);
        }
    }
}
