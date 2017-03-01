using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AppZoneTestProjects.Functional.Base;

namespace AppZoneTestProjects.Functional.Utils.Interface.SystemAdmin
{
    public class UserValidate : Base.Base
    {
        public UserValidate() { }
        public UserValidate(IWebDriver driver) : base(driver){ }
        public void WaitPageLoad(String InputPathLocator)
        {
            WebDriverWait tests = new WebDriverWait(driver, TimeSpan.FromSeconds(180));
            tests.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(InputPathLocator)));
        }

        public void WaitElementVisible(String ElementVisible)
        {
            WebDriverWait tests = new WebDriverWait(driver, TimeSpan.FromSeconds(180));
            tests.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(ElementVisible)));
        }

        public bool PageContainsText(IWebDriver driver, string TextToFind)
        {
            return driver.FindElement(By.TagName("body")).Text.Contains(TextToFind);
        }

        public void ListViewContainsText(IWebDriver driver, string TextToFind)
        {
            String bodyText = driver.FindElement(By.TagName("body")).Text;
            Assert.AreEqual(true, bodyText.Contains(TextToFind));
        }
    }
}

