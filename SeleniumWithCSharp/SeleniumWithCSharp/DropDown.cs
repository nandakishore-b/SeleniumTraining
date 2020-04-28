using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWithCSharp
{
    class DropDown

    {
        static void Main(string[] args)
        {
            //Open browser
            ChromeDriver driver = new ChromeDriver();

            //Open google
            driver.Url = "https://developer.salesforce.com/signup";

            //           SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("country")));
            //           oSelection.SelectByText("Spain");

            //          Random rnd = new Random();
            //          SelectElement sel = new SelectElement(driver.FindElement(By.Id("country")));
            //          int index = rnd.Next(0, 229);
            //          sel.SelectByIndex(index);

            Random rnd = new Random(); // this can be global
            SelectElement sel = new SelectElement(driver.FindElement(By.Id("country")));
            int itemCount = sel.Options.Count; // get the count of elements in ddlWebElement
            sel.SelectByIndex(rnd.Next(0, itemCount));// will give you random selections

            Thread.Sleep(5000);

   
             
          



           // driver.Close();
        }

        }
}
