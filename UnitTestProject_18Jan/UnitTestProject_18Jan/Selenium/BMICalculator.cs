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
    class BMICalculator
    {
        IWebDriver driver;
        [SetUp]
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        [Test]
        public void EnterBMIDetails()
        {
            IWebElement ageTextbox = driver.FindElement(By.Id("cage"));
            //Clear the existing data
            ageTextbox.Clear();
            //I can enter data here
            ageTextbox.SendKeys("45");
            IList<IWebElement> genderList = driver.FindElements(By.Name("csex"));
            if (genderList.Count > 0)
            {
                Console.WriteLine("Element is Present : " + genderList.Count);
                foreach (IWebElement gender in genderList)
                {
                    if (gender.GetAttribute("value").Equals("f"))
                    {
                        if (!gender.Selected)
                        {
                            gender.Click();
                            break;
                        }
                    }
                }
              }

            System.Threading.Thread.Sleep(5000);
            }
        [TearDown]
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }
    }
}
