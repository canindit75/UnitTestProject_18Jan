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
    class HandlePopups
    {
        [Test]
        public void HandlePopupTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            System.Threading.Thread.Sleep(2000);
            //Invoke JavaScript - alert popup 
            Console.WriteLine("Example of Alert information Popup");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("alert('This is an information alert box');");
            //Switches the control to alert - needed to perform operations on alert
            IAlert alert = driver.SwitchTo().Alert();
            //operations performed - retrieving alert message, click on Ok button
            String alertMsg = alert.Text;
            System.Threading.Thread.Sleep(3000);
            alert.Accept();
            Console.WriteLine("Example of Confirmation Popup");
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("confirm('Do you want to continue(y/n)?');");
            alert = driver.SwitchTo().Alert();
            alertMsg = alert.Text;
            System.Threading.Thread.Sleep(3000);
            alert.Dismiss();



        }
    }
}
