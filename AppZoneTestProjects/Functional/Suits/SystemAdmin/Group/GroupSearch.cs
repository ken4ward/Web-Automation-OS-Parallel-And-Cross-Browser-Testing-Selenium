using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Utils.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Reusables.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Reusables.Login;
using AppZoneTestProjects.Functional.Constants.Login;

namespace AppZoneTestProjects.Functional.Suits.SystemAdmin.Group
{
    public class GroupSearch : Base.Base
    {
        public GroupSearch() { }
        public GroupSearch(IWebDriver driver) : base(driver) { }

        public static String[] ParamObjectGroup = { GroupConstants.GroupName, GroupConstants.GroupCode };
        public static String[] ParamValuesGroup = { "Test user role", "002" };
        public UsersReusables UsersReusables;

        public void LoginGroupPage()
        {
            UsersReusables = new UsersReusables(driver);
            new LoginReusables(driver).DejaVutLogin(LoginConstants.DejaVuInstitutionCode, LoginConstants.DejaVuLoginUsername, LoginConstants.DejaVutLoginPassword);
            UsersReusables.NavigateElements(LoginValidate.DefaultFooter, SystemAdminConstants.SystemAdmin, SystemAdminConstants.SystemAdmin, LoginValidate.DefaultFooter, driver, LoginValidate.Inbox);
            UsersReusables.NavigateElements(LoginValidate.DefaultFooter, GroupConstants.Groups, GroupConstants.Groups, GroupConstants.GroupFooter, driver, GroupConstants.GroupSearchs);
        }
        public void ReusableGlobalSearch()
        {
            for (int i = 0; i < ParamObjectGroup.Length; i++)
            {
                driver.FindElement(By.CssSelector(ParamObjectGroup[i])).SendKeys(ParamValuesGroup[i]);
                driver.FindElement(By.CssSelector(GroupConstants.GroupSearch)).Click();
                System.Threading.Thread.Sleep(500);
                driver.FindElement(By.Id(GroupConstants.GroupReset)).Click();
                new UserValidate(driver).WaitPageLoad(ParamObjectGroup[i]);
            }
        }
    }
}
