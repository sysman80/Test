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
    public class AdminMenuItems
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
        public void TheAdminMenuItemsTest()
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
            driver.FindElement(By.CssSelector("span.ng-binding")).Click();
            driver.FindElement(By.LinkText("Settings")).Click();
            driver.FindElement(By.LinkText("User Details")).Click();
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("div.settings-header_text")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("div.entity-value_label")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("div.entity-value_value.ng-binding")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[2]/div[2]/div/div/div")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[2]/div[2]/div/div/div[2]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div/img")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[2]/div/div[2]/div/div")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[2]/div/div[2]/div/div[2]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[2]/div[2]/div[2]/div/div")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[2]/div[2]/div/div[2]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("div.settings-bar_navigation-header")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='settings-bar_body']/div[2]/div[2]/div")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("img[alt=\"Brand\"]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//input[@type='text']")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("div.nav-bar-user-info_dropdown.dropdown-toggle")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("div.nav-bar-user-info_photo")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[@id='settings-bar_body']/div[2]/div[2]/div")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("Users")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.CssSelector("p.ng-binding.ng-scope"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("div.settings-header_text")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("button.btn.btn-success")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.Name("Search")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-pills/div/div")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-pills/div/div[2]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-pills/div/div[3]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//input[@type='search']")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//th[2]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//th[3]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//th[4]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//th[5]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div/div/div/div/p")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-pagination/div/div/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[3]/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.LinkText("1")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("Groups")).Click();
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("div.settings-header_text")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("button.btn.btn-success")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("span.ng-binding.sort-indicator")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//th[2]/div/span")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//th[3]/div/span")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//th[4]/div/span")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[1]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[2]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[3]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("span.ng-binding.ng-scope")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("p.ng-binding.ng-scope")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-pagination/div/div/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.LinkText("1")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[3]/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-table-select-count/div/div/span")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.CssSelector("div.settings-bar_navigation-item")).Click();
            driver.FindElement(By.XPath("//div[@id='settings-bar_body']/div[2]/div[2]/div[3]")).Click();
            driver.FindElement(By.LinkText("Info")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//tr[10]/td"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.Name("Search")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.date-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.email-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.type-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.action-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.message-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("td.strong.ng-binding")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[2]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("td.type-col.ng-binding")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[4]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("td.message-col.ng-binding")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("p.ng-binding.ng-scope")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-pagination/div/div/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.LinkText("1")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[3]/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("Error")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//div[2]/div/div/p"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.Name("Search")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.date-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.email-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.message-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td/i")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("td.strong.ng-binding")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[3]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("td.message-col.ng-binding")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("p.ng-binding.ng-scope")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-pagination/div/div/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.LinkText("1")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[3]/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("Email")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//tbody[10]/tr/td[2]"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.Name("Search")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.date-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.email-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//th[4]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("th.message-col")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td/i")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("td.strong.ng-binding")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[3]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//td[4]")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("td.message-col.ng-binding")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.CssSelector("p.ng-binding.ng-scope")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//ng-pagination/div/div/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.LinkText("1")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//div[3]/button")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//nav-bar-user-info/div/div/div")).Click();
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
