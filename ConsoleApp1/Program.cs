using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver dw = new FirefoxDriver();
            dw.Manage().Window.Maximize();

            dw.Navigate().GoToUrl("http://www.durgasoft.com/");

            IWebElement elem = dw.FindElement(By.XPath("/html/body/div[8]/table/tbody/tr[5]/td[15]/div/a[20]/img"));



            elem.Click();
            elem = dw.FindElement(By.XPath("/html/body/table/tbody/tr/td[2]/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table[1]/tbody/tr/td[2]/table/tbody/tr[2]/td/ul/li[1]/ul/li[13]"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)dw;
            string ForrasHTML = (string)js.ExecuteScript("return arguments[0].innerHTML;", elem);

            Console.WriteLine(ForrasHTML);
            Console.Read();
            //Assert.IsTrue(ForrasHTML.Contains("Inversion of Control / Dependency injection"));
        }

        public static void Asserthez()
        {

        }
    }
}
