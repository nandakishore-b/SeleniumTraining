using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp
{
    class BasicActions
    {
        static void Main(string[] args)
        {
            //Open browser
            ChromeDriver driver = new ChromeDriver();

            //Open google
            driver.Url = "https://www.graphnethealth.com/";
            
            //Title of the current page
            string title = driver.Title;
            Console.WriteLine("Title of the Current page-->"+ title);

            //Current url of the page
            string currenturl = driver.Url;
            Console.WriteLine("Current url of the page-->"+currenturl);

            //Close browser
            //driver.Close();


           // driver.Quit();

        }
    }
}
