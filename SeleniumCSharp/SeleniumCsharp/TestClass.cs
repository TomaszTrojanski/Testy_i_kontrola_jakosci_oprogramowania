using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCsharp
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {

            IWebElement cookie = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            cookie.Click();
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement form = driver.FindElement(By.XPath(".//*[@data-testid='open-registration-form-button']"));
            form.Click();
            Thread.Sleep(1000);
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("mar");
            element.SelectByValue("6");
        }
        [Test,Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
