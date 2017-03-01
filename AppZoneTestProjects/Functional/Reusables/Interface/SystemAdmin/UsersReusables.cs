using System;
using System.IO;
using System.Text;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppZoneTestProjects.Functional.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Utils.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Constants.Login;
using System.Collections.Generic;

namespace AppZoneTestProjects.Functional.Reusables.Interface.SystemAdmin
{
    public class UsersReusables : Base.Base
    {
        public UsersReusables() { }
        public UsersReusables(IWebDriver driver) : base(driver) { }

        public static String[] lines = { };
        public UserValidate UserValidate;
        public String ExpectedResult, ActualResult, Status, Output;
        public static int counter;
        public IWebElement ValidateLogin, ValidateElelmentVisible;
        public static String ReturnedObject;

        public static String Firstname, Lastname, Phone, Email, EmployeeNo, Designation, UserName;

        public String UserRegistrationCompulsoryFields(String Firstname, String Lastname, String Phone, String Email, String EmployeeNo, String Designation, String UserName)
        {
            UsersReusables.Firstname   = Firstname;
            UsersReusables.Lastname    = Lastname;
            UsersReusables.Phone       = Phone;
            UsersReusables.Email       = Email;
            UsersReusables.EmployeeNo  = EmployeeNo;
            UsersReusables.Designation = Designation;
            UsersReusables.UserName    = UserName;

            driver.FindElement(By.CssSelector(UserConstants.FirstName)).Clear();
            driver.FindElement(By.CssSelector(UserConstants.FirstName)).SendKeys(UsersReusables.Firstname);

            driver.FindElement(By.CssSelector(UserConstants.LastName)).Clear();
            driver.FindElement(By.CssSelector(UserConstants.LastName)).SendKeys(UsersReusables.Lastname);

            driver.FindElement(By.CssSelector(UserConstants.Phone)).Clear();
            driver.FindElement(By.CssSelector(UserConstants.Phone)).SendKeys(UsersReusables.Phone);

            driver.FindElement(By.CssSelector(UserConstants.Email)).Clear();
            driver.FindElement(By.CssSelector(UserConstants.Email)).SendKeys(UsersReusables.Email);

            driver.FindElement(By.CssSelector(UserConstants.EmployeeNo)).Clear();
            driver.FindElement(By.CssSelector(UserConstants.EmployeeNo)).SendKeys(UsersReusables.EmployeeNo);

            driver.FindElement(By.CssSelector(UserConstants.Designation)).Clear();
            driver.FindElement(By.CssSelector(UserConstants.Designation)).SendKeys(UsersReusables.Designation);

            //new Base.Base(driver).DropDownElements(UserConstants.UserRole, 3, UserConstants.UserRoleText);
            IList<IWebElement> DropDownPath = driver.FindElements(By.CssSelector(UserConstants.UserRole));
            for (int i = 0; i < DropDownPath.Count; ++i)
            {
                if (DropDownPath.Count == 3)
                {
                    new UserValidate(driver).WaitElementVisible(DropDownPath[2].ToString());
                    driver.FindElement(By.CssSelector(DropDownPath[2].ToString())).Click();
                    IWebElement ele = driver.FindElement(By.CssSelector("#s2id_autogen3_search"));
                    SelectElement DropDown = new SelectElement(ele);
                    DropDown.SelectByText("SuperAdmin");
                }
            } 
            
            driver.FindElement(By.CssSelector(UserConstants.UserName)).Clear();
            driver.FindElement(By.CssSelector(UserConstants.UserName)).SendKeys(UsersReusables.UserName);

            //driver.FindElement(By.CssSelector("#HasApprovalRight"));

            driver.FindElement(By.CssSelector(UserConstants.SaveButton)).Click();

            if (Firstname != UserConstants.FirstName && Lastname != UserConstants.LastName
                && Phone != UserConstants.Phone && Email != UserConstants.Email
                && EmployeeNo != UserConstants.EmployeeNo && Designation != UserConstants.Designation && UserName != UserConstants.UserName)
            {
                ExpectedResult = "Login Failed"; ActualResult = ExpectedResult; Status = "Passed";
                Output = ExpectedResult + "  " + ActualResult + "  " + Status;
            }

            if (Firstname == UserConstants.FirstName && Lastname == UserConstants.LastName
                && Phone == UserConstants.Phone && Email == UserConstants.Email
                && EmployeeNo == UserConstants.EmployeeNo && Designation == UserConstants.Designation && UserName == UserConstants.UserName)
            {
                ExpectedResult = "Login successful"; ActualResult = ExpectedResult; Status = "Passed";
                Output = ExpectedResult + "  " + ActualResult + "  " + Status;
            }

            ReturnedObject = UsersReusables.Firstname + "  " + UsersReusables.Lastname + "  " + UsersReusables.Phone + "  " + UsersReusables.Email + "  " + UsersReusables.EmployeeNo + "  " + UsersReusables.Designation + "  " + UsersReusables.UserName;
            return ReturnedObject + "  " + Output;
        }

        public void UserRegistrationOptionalFields()
        {
            SelectElement SelectUserRole = new SelectElement(driver.FindElement(By.CssSelector(UserConstants.UserRole)));
            SelectUserRole.DeselectAll();
            SelectUserRole.SelectByValue(UserConstants.SelectValue);

            driver.FindElement(By.CssSelector(UserConstants.GrantApprovalRights)).Click();

            driver.FindElement(By.CssSelector(UserConstants.GrandSuperAdminPrivileges)).Click();
        }

        public void UsersNavigate(String Navigate)
        {
            driver.FindElement(By.CssSelector(Navigate)).Click();
        }

        public void NavigateElements(String PageLoad, String ElementVisible, String ClickElement, String ActualPage, IWebDriver driver, String AssertText)
        {
            UserValidate = new UserValidate(driver);
            UserValidate.WaitPageLoad(PageLoad);
            UserValidate.WaitElementVisible(ElementVisible);
            new UsersReusables(driver).UsersNavigate(ClickElement);
            UserValidate.WaitPageLoad(ActualPage);
            UserValidate.PageContainsText(driver, AssertText);
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public string GenerateUsername()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }

        public void ReclickCreate(String ClickUserLink, String ElementVisible, String ClickElement, String ActualPage, IWebDriver driver, String AssertText)
        {
            UserValidate = new UserValidate(driver);
            new UsersReusables(driver).UsersNavigate(ClickUserLink);
            UserValidate.WaitElementVisible(ElementVisible);
            new UsersReusables(driver).UsersNavigate(ClickElement);
            UserValidate.WaitPageLoad(ActualPage);
            UserValidate.PageContainsText(driver, AssertText);
        }
    }
}
