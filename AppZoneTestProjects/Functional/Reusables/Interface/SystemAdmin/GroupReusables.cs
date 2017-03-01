using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
using OpenQA.Selenium.Support.UI;

namespace AppZoneTestProjects.Functional.Reusables.Interface.SystemAdmin
{
    [TestClass]
    public class GroupReusables : Base.Base
    {
        public GroupReusables() { }
        public GroupReusables(IWebDriver driver) : base(driver) { }

        public void GroupReusablesMap(String Name, String Code, String Description)
        {
            driver.FindElement(By.CssSelector(GroupConstants.GroupName)).Clear();
            driver.FindElement(By.CssSelector(GroupConstants.GroupName)).SendKeys(Name);

            driver.FindElement(By.CssSelector(GroupConstants.GroupCode)).Clear();
            driver.FindElement(By.CssSelector(GroupConstants.GroupCode)).SendKeys(Code);

            driver.FindElement(By.CssSelector(GroupConstants.GroupDescription)).Clear();
            driver.FindElement(By.CssSelector(GroupConstants.GroupDescription)).SendKeys(Description);

           // driver.FindElement(By.Id(GroupConstants.GroupSysAdminFunc)).Click();
           // driver.FindElement(By.Id(GroupConstants.GroupDevFunction)).Click();

            //new SelectElement(driver.FindElement(By.CssSelector(GroupConstants.GroupUserFunctions))).SelectByIndex(2);

            driver.FindElement(By.Id(GroupConstants.GroupSave)).Click();
        }
    }
}
