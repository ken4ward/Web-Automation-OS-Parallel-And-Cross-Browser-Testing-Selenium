using System;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Reusables.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Constants.Login;
using AppZoneTestProjects.Functional.Reusables.Login;
using AppZoneTestProjects.Functional.Suits.SystemAdmin.Group;

namespace AppZoneTestProjects.Functional.Suits.SystemAdmin.Group
{
    public class GroupSuites : Base.Base
    {
        public GroupSuites() { }
        public GroupSuites(IWebDriver driver) : base(driver) { }

        public GroupReusables GroupReusables;
        public UsersReusables UsersReusables;

        public static String[] ParamValuesOne = { GroupConstants.GroupEmptyParameter, GroupConstants.GroupSpaceCharacter, GroupConstants.GroupNameRight };
        public static String[] ParameValuesTwo = { GroupConstants.GroupSpecialCharacter, GroupConstants.GroupSpecialCharacterWithInt, GroupConstants.GroupCodeRight };
        public static String[] ParamValuesThree = { GroupConstants.GroupSpecialCharacterWithString, GroupConstants.GroupWrongParameter, GroupConstants.GroupDescriptionRight };

        public void GroupNavigate()
        {
            UsersReusables = new UsersReusables(driver);
            new LoginReusables(driver).DejaVutLogin(LoginConstants.DejaVuInstitutionCode, LoginConstants.DejaVuLoginUsername, LoginConstants.DejaVutLoginPassword);
            UsersReusables.NavigateElements(LoginValidate.DefaultFooter, SystemAdminConstants.SystemAdmin, SystemAdminConstants.SystemAdmin, LoginValidate.DefaultFooter, driver, LoginValidate.Inbox);
            UsersReusables.NavigateElements(LoginValidate.DefaultFooter, GroupConstants.Groups, GroupConstants.Groups, GroupConstants.GroupFooter, driver, GroupConstants.GroupSearchs);
            UsersReusables.NavigateElements(GroupConstants.GroupFooter, GroupConstants.GroupAdd, GroupConstants.GroupAdd, GroupConstants.GroupAddFooter, driver, GroupConstants.GroupAddAssert);    
        }

        public void RunGroupSuite()
        {
            GroupReusables = new GroupReusables(driver);
            foreach(var ItemOne in GroupSuites.ParamValuesOne)
            {
                foreach(var ItemTwo in GroupSuites.ParameValuesTwo)
                {
                    foreach(var ItemThree in GroupSuites.ParamValuesThree)
                    {
                        GroupReusables.GroupReusablesMap(ItemOne, ItemTwo, ItemThree);
                        UsersReusables.ReclickCreate(GroupConstants.Groups, GroupConstants.GroupAdd, GroupConstants.GroupAdd, GroupConstants.GroupAddFooter, driver, GroupConstants.GroupAddAssert);
                    }
                }
            }
        }

        public void RunAllGroupTestCases()
        {
            new GroupSuites(driver).GroupNavigate();
            new GroupSuites(driver).RunGroupSuite();
        }

        public void RunAllGroupSearch()
        {
            new GroupSearch(driver).LoginGroupPage();
            new GroupSearch(driver).ReusableGlobalSearch();
        }
    }
}
