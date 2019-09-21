using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTestProject_18Jan.Selenium
{   [TestFixture]
    class ExtractWebTable_TagClassName
    {
        [Test]
        public void WebTableTest() { 
        ChromeDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            IWebElement table = driver.FindElement(By.ClassName("cinfoT"));
            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));
              foreach(IWebElement row in rows)
            {
                IList<IWebElement> cols = row.FindElements(By.TagName("td"));
                {
                    foreach(IWebElement col in cols){
                        Console.Write(col.Text + "\t");
                    }
                }
                Console.WriteLine("");
                
            }
        }
    }
}
