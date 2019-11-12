using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Core
{
    class TestBase
    {
        public static IWebDriver GetDriver()
        {
            var driver = new ChromeDriver();
            var url = ConfigurationManager.AppSettings["baseUrl"].ToString();
            driver.Navigate().GoToUrl(url);
            return driver;
        }
    }
}
