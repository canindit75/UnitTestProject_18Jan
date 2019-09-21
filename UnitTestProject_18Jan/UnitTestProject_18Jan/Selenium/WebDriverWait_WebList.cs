using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject_18Jan.Selenium
{
    [TestFixture]
    class WebDriverWait_WebList
    {
        [Test]
        public void ExplicitWaitExample()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("q")).SendKeys("s");
            //webdriverwait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));                
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@role='listbox']")));
            IList<IWebElement> lst = driver.FindElements(By.XPath("//*[@role='listbox']/li"));
            foreach(IWebElement element in lst)
            {
                Console.WriteLine(element.Text);
                //if(element.Text.Equals("sbi online"))
                //{
                //    element.Click();
                //    break;
                //}
            }


        }
    }
}
