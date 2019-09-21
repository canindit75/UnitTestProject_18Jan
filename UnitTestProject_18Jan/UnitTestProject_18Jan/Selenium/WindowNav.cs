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
    class WindowNav
    {
        [Test]
        public void WindowNavTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.online.citibank.co.in/products-services/online-services/internet-banking.htm");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //How to get Window Handles for each Window
            String mainWindowId = driver.CurrentWindowHandle;
            Console.WriteLine("Current Main Window Id : " + mainWindowId);
            //Clicking on Login Button
            driver.FindElement(By.XPath("//*[@title='LOGIN NOW']")).Click();

            IList<String> winids = driver.WindowHandles;
            String mainWindow = winids[0];
            String subWindow = winids[1];
            Console.WriteLine("Number of Open Windows : " + winids.Count);
            Console.WriteLine("mainWindow : " + mainWindow);
            Console.WriteLine("subWindow : " + subWindow);
            //switch control to the subwindow
            driver.SwitchTo().Window(subWindow);
            driver.FindElement(By.Id("User_Id")).SendKeys("selenium");
            System.Threading.Thread.Sleep(3000);
            driver.Close(); //subwindow close
            //go back to main window
            driver.SwitchTo().Window(mainWindow);
            driver.FindElement(By.Id("topMnuinsurance")).Click();            



        }
    }
}
