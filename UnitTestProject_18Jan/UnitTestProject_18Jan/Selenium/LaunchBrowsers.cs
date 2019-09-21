using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace UnitTestProject_18Jan.Selenium
{
    [TestFixture]
    class LaunchBrowsers
    {
        [Test]
        [Ignore ("Ignore the test")]
        public void LaunchBrowserTest()
        {
            //ChromeDriver driver = new ChromeDriver();
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            System.Threading.Thread.Sleep(2000);
            IWebElement ageTextbox = driver.FindElement(By.Id("cage"));
            //Clear the existing data
            ageTextbox.Clear();
            //I can enter data here
            ageTextbox.SendKeys("45");
            Console.WriteLine("Class Attribute value of Element ageTextbox : " + ageTextbox.GetAttribute("class"));
            Console.WriteLine("Current ageTextbox Value : "+ ageTextbox.GetAttribute("value"));

            //driver.Close();
            //FirefoxDriver fdriver = new FirefoxDriver(@"C:\\Users\\Anindita\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject_18Jan\\packages\\Selenium.Firefox.WebDriver.0.16.1\\driver");
            //fdriver.Navigate().GoToUrl("http://www.google.com");
            //System.Threading.Thread.Sleep(2000);
            //driver.Close();
            //System.Threading.Thread.Sleep(2000);

            IList<IWebElement> genderList = driver.FindElements(By.Name("csex"));
            if (genderList.Count > 0) { 
                Console.WriteLine("Element is Present : " + genderList.Count);

            foreach(IWebElement gender in genderList){
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

        }
    }
}
