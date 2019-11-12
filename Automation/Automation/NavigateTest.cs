using Automation.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    [TestFixture]
    public class NavigateTest
    {
        IWebDriver _driver = null;
        [Test]
        public void NavigateToDellPage()
        {
            _driver.FindElement(By.Id("dell")).Click();
            Assert.IsTrue(_driver.Title.Contains("Computers and Electronics"));
        }

        [Test]
        public void DellPage()
        {
            _driver.FindElement(By.Id("dell")).Click();
            Assert.IsTrue(_driver.Title.Contains("Computers and Electronics"));
        }

        [SetUp]
        public void Init()
        {
            _driver = TestBase.GetDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Close();
        }
    }
}
