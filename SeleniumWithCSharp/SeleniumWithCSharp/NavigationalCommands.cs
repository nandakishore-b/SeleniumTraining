using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWithCSharp
{
    class NavigationalCommands
    {

        static void Main(string[] args)
        {
            //Open browser
            ChromeDriver driver = new ChromeDriver();

            //Open google
            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.FindElement(By.LinkText("Gmail")).Click();

            Thread.Sleep(3000);

            driver.Navigate().Back();

            Thread.Sleep(1000);

            driver.Navigate().Forward();

            Thread.Sleep(1000);

            driver.Navigate().Refresh(); 
    

           
            Thread.Sleep(5000);



            driver.Close();

        
    }
        
    }
}
