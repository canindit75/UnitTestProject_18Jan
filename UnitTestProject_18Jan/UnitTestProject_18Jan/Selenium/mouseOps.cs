using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject_18Jan.Selenium
{
    [TestFixture]
    class mouseOps
    {
        [Test]
        public void MouseOpsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Identify COmponent Menu
            IWebElement componentMenu= driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/a"));
            componentMenu.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //Check if PrinterElement exists to make sure the sub menu is appearing on clicking on COmponent menu
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a")));
            IWebElement printerElement = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(printerElement).Click().Build().Perform();

        }
    }
}
