using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AppZoneTestProjects.Functional.Base;

namespace AppZoneTestProjects.Functional.Utils.Login
{
    public class LoginValidations : Base.Base
    {
        public LoginValidations() { }
        public LoginValidations(IWebDriver driver) : base(driver) { }

        public static void WaitTime()
        {
            System.Threading.Thread.Sleep(800);
        }
        public void WaitForATime(String InputPathLocator)
        {
            WebDriverWait tests = new WebDriverWait(driver, TimeSpan.FromSeconds(180));
            tests.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(InputPathLocator)));
        }
    }
}
