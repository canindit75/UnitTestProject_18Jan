using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject_18Jan.Selenium
{
    [TestFixture]
    class dragdrop_frame
    {
        [Test]
        public void dragdropTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement frameElement = driver.FindElement(By.ClassName("demo-frame"));
            driver.SwitchTo().Frame(frameElement);
            //drag and drop is a mouse operation - we will use Actions Class
            Actions actions = new Actions(driver);
            IWebElement dragElement = driver.FindElement(By.Id("draggable"));
            IWebElement dropElement = driver.FindElement(By.Id("droppable"));
            actions.DragAndDrop(dragElement, dropElement).Build().Perform();
            String dropMsg = dropElement.Text;
            if (dropMsg.Equals("Dropped!"))
                Console.WriteLine("Dropped successfully");
            else
                Console.WriteLine("Drop Failed");

        }
    }
}
