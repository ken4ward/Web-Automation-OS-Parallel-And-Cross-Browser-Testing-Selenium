using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppZoneTestProjects.Functional.Reusables.Login;
using AppZoneTestProjects.Functional.Constants.Login;
using AppZoneTestProjects.Functional.Utils.Login;
using AppZoneTestProjects.Functional.Base;
using AppZoneTestProjects.Functional.Reusables.Interface;
using AppZoneTestProjects.Functional.Reusables.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Suits.SystemAdmin.Users;
using AppZoneTestProjects.Functional.Reports;
using AppZoneTestProjects.Properties;

namespace AppZoneTestProjects.Functional.Suits.SystemAdmin
{
    public class UserSuites : Base.Base
    {
        public UserSuites() { }
        public UserSuites(IWebDriver driver) : base(driver) { }
        public UsersReusables UsersReusables;
        public static Random random = new Random();

        public static String[] ParamValOne   = { UserVariables.UserWrongParameter, UserVariables.FirstName };
        public static String[] ParamValTwo   = { UserVariables.UserEmptyParameter, UserVariables.LastName };
        public static String[] ParamValThree = { UserVariables.UserSpecialCharacter, UserVariables.Phone };
        public static String[] ParamValFour  = { UserVariables.UserSpecialCharacterInt, UserVariables.Email };
        public static String[] ParamValFive  = { UserVariables.UserSpecialCharacterString, UserVariables.EmployeeNo };
        public static String[] ParamValSix   = { UserVariables.UserStringNumber, UserVariables.Designation };
        public static String[] ParamValSeven = { UserVariables.UserSpaceCharacter, UserVariables.UserName };

        public static String[] SearchParamsValues = { UserVariables.UserName, UserVariables.FirstName, UserVariables.LastName, UserVariables.Phone, UserVariables.Email, UserVariables.EmployeeNo, UserVariables.Designation };
        public static String[] SearchParamsObjects = { UserConstants.UserName, UserConstants.FirstName, UserConstants.LastName, UserConstants.Phone, UserConstants.Email, UserConstants.EmployeeNo, UserConstants.Designation };
        
        public static int Count = 0;
        public static int Counting = 0;
        public static String[] lines = { };

        public static String UserReadPath = Resources.UserReadLog;
        public static String UserWritePath = Resources.UserWriteLog;
        public static String UserResult = "";

        public void UserNavigate()
        {
            UsersReusables = new UsersReusables(driver);
            new LoginReusables(driver).DejaVutLogin(LoginConstants.DejaVuInstitutionCode, LoginConstants.DejaVuLoginUsername, LoginConstants.DejaVutLoginPassword);
            UsersReusables.NavigateElements(LoginValidate.DefaultFooter, SystemAdminConstants.SystemAdmin, SystemAdminConstants.SystemAdmin, LoginValidate.DefaultFooter, driver, LoginValidate.Inbox);
            UsersReusables.NavigateElements(LoginValidate.DefaultFooter, SystemAdminConstants.Users, SystemAdminConstants.Users, UserValidations.UserPageLoad, driver, UserConstants.UserSearch);
            UsersReusables.NavigateElements(UserValidations.UserPageLoad, UserConstants.CreateUser, UserConstants.CreateUser, UserValidations.UserFooter, driver, UserConstants.AddNewUser);
        }

        public static String ReturnRandom()
        {
            int randomNumber = random.Next();
            return randomNumber.ToString(); 
        }


        public void UserTestCases()
        {
            UsersReusables = new UsersReusables(driver);
            foreach(var ItemOne in UserSuites.ParamValOne)
            {
                foreach (var ItemTwo in UserSuites.ParamValOne)
                {
                    foreach (var ItemThree in UserSuites.ParamValOne)
                    {
                        foreach (var ItemFour in UserSuites.ParamValOne)
                        {
                            foreach (var ItemFive in UserSuites.ParamValOne)
                            {
                                foreach (var ItemSix in UserSuites.ParamValOne)
                                {
                                    foreach (var ItemSeven in UserSuites.ParamValOne)
                                    {
                                        ++Count;
                                        ReportEngine.Count = Count;
                                        UserResult = UsersReusables.UserRegistrationCompulsoryFields(ItemOne, ItemTwo, ItemThree, ItemFour, ItemFive, ItemSix, ItemSeven);
                                        ReportEngine.ReportEngineGlobal(4, UserReadPath, UserWritePath, UserResult);
                                        new Base.Base(driver).UserRegisrationFailed(UserValidations.RegistrationFailedPanels, UserValidations.CloseFailedPanel);
                                        UsersReusables.ReclickCreate(SystemAdminConstants.Users, UserConstants.CreateUser, UserConstants.CreateUser, UserValidations.UserFooter, driver, UserConstants.AddNewUser);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void UserSuitesRunAll()
        {
            new UserSuites(driver).UserNavigate();
            new UserSuites(driver).UserTestCases();
        }

        public void SearchUserObject()
        {
            new SearchUsers(driver).LoginUSerPage();
            foreach(var SearchValue1 in UserSuites.SearchParamsObjects)
            {
                foreach (var SearchValue2 in UserSuites.SearchParamsValues)
                {
                    //new SearchUsers(driver).SearchRecordSingleID(SearchValue1, SearchValue2);
                }
            }
        }
    }
}
