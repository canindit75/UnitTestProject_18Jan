using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject_18Jan.Selenium
{
    [TestFixture]
    class ImplicitExample
    {
        [Test]
        public void ImplicitExplicitTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize(); //maximizes your window
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Console.WriteLine(driver.Title); //Application title of current page
            Console.WriteLine(driver.PageSource); //Current Page - Page Source
            Console.WriteLine(driver.Url); //Current Page URL
            driver.Close(); //close your current active browser
            driver.Quit(); //closes all open browsers which got opened via automation script
        }
    }
}
