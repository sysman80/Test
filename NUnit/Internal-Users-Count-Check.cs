using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class InternalUsersCountCheck
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://clarity.edka.me/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheInternalUsersCountCheckTest()
        {
            driver.Navigate().GoToUrl(baseURL + "#/signin");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//sign-in/div/div[2]"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("123456");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("admin@admin.com");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (driver.FindElement(By.XPath("//ng-table-select-count/div/div/span")).Displayed) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            String ExternalUsers = driver.FindElement(By.XPath("//div[2]/div/div[3]")).Text;
            driver.FindElement(By.XPath("//ng-pills-ui-router/div/div[3]")).Click();
            driver.FindElement(By.XPath("//ng-pills/div/div[2]")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//td/div"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            String  = driver.FindElement(By.XPath("//div[2]/div/div[3]")).Text;
            String Items = "items";
            try
            {
                Assert.AreEqual(ExternalUsers + Items, driver.FindElement(By.XPath("//div[2]/div/div/div/div/span")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.CssSelector("div.nav-bar-user-info_dropdown.dropdown-toggle")).Click();
            driver.FindElement(By.LinkText("Sign Out")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
