using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppZoneTestProjects.Functional.Base;
using AppZoneTestProjects.Functional.Reusables.Login;
using AppZoneTestProjects.Functional.Reusables.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Constants.Login;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Utils.Interface.SystemAdmin;

namespace AppZoneTestProjects.Functional.Suits.SystemAdmin.Users
{
    public class SearchUsers : Base.Base
    {
        //Global variable values and objects
        public static string[] UserParamObjects = new string[] { UserConstants.UserName, UserConstants.LastName, UserConstants.Email, UserConstants.FirstName };
        public static string[] UserParamValues = new string[] { "kadeoya", "Adeoya", "kadeoya@appzonegroup.com", "Kehinde" };
        
        public SearchUsers() { }
        public SearchUsers(IWebDriver driver) : base(driver) { }
        UsersReusables UsersReusables;
        
        public void LoginUSerPage()
        {
            UsersReusables = new UsersReusables(driver);
            new LoginReusables(driver).DejaVutLogin(LoginConstants.DejaVuInstitutionCode, LoginConstants.DejaVuLoginUsername, LoginConstants.DejaVutLoginPassword);
            UsersReusables.NavigateElements(LoginValidate.DefaultFooter, SystemAdminConstants.SystemAdmin, SystemAdminConstants.SystemAdmin, LoginValidate.DefaultFooter, driver, LoginValidate.Inbox);
            UsersReusables.NavigateElements(LoginValidate.DefaultFooter, SystemAdminConstants.Users, SystemAdminConstants.Users, UserValidations.UserPageLoad, driver, UserConstants.UserSearch);
        }

        public void SearchUsersGlobal()
        {
            Base.Base.ParamObjects = UserParamObjects;
            new Base.Base().ReusableGlobalSearch();
        }
        public void SearchWithRecord()
        {
           
        }

        public void SearchMismatchRecord()
        {

        }
    }
}
