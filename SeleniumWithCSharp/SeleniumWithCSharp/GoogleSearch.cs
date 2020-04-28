using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumWithCSharp
{
    class GoogleSearch
    {
        static void Main(string[] args)
        {
            //Open browser
            ChromeDriver driver = new ChromeDriver();

            //Open google
            driver.Url = "https://www.google.com/";

            driver.FindElement(By.Name("q")).SendKeys("selenium vacancies");

            Thread.Sleep(1000);

            driver.FindElement(By.Name("btnK")).Click();


            // driver.FindElement(By.XPath("//span[contains(text(),'Submit')]"))


            driver.FindElement(By.PartialLinkText("Test Analyst")).Click();

            Thread.Sleep(5000);



            driver.Close();


        }

    }
}
