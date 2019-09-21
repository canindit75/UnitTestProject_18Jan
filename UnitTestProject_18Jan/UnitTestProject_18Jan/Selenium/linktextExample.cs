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
    class linktextExample
    {
        [Test]
        public void linkTextExample()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            IWebElement BMILink = driver.FindElement(By.LinkText("BMI"));
            BMILink.Click();
            //wait time for 2 seconds
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().Back();//Navigates back to Calorie Calculator
            driver.Navigate().Forward(); //navigates forward to BMI Calculator
            //Click on Weight Watcher Points in BMI Calculator
            IWebElement WatcherLink = driver.FindElement(By.PartialLinkText("Watcher"));
            WatcherLink.Click();
            
            driver.Navigate().Refresh(); //Refresh Weight Watcher Points 
        }
    }
}
