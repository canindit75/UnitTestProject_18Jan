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
    class dropdownExample
    {
        [Test]
        public void dropdownTest() { 
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //dropdown activity
            IWebElement activity = driver.FindElement(By.Id("cactivity"));
            SelectElement select = new SelectElement(activity);
            Console.WriteLine("Current dropdown Value - Default " + select.SelectedOption.Text);
            //Selecting Sedentry
            select.SelectByIndex(1);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Current dropdown Value - Changed to Sedentry by index " + select.SelectedOption.Text);
            //Selecting Active by value
            select.SelectByValue("1.55");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Current dropdown Value - Changed to Active by value " + select.SelectedOption.Text);
            select.SelectByText("Extra Active: very intense exercise daily, or physical job");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Current dropdown Value - Changed to Extra Active by Text " + select.SelectedOption.Text);
            Console.WriteLine("Is the dropdown Multiselect : " + select.IsMultiple);

        }
    }
}
