using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AppZoneTestProjects.Functional.Base;
using AppZoneTestProjects.Functional.Constants.Login;
using System.IO;
using AppZoneTestProjects.Properties;
using AppZoneTestProjects.Functional.Reports;

namespace AppZoneTestProjects.Functional.Reusables.Login
{
    public class LoginReusables : Base.Base
    {
        public LoginReusables() { }
        public LoginReusables(IWebDriver driver) : base(driver) { }

        public String ExpectedResult, ActualResult, Status, Output;
        public bool visible = false;
        public IWebElement ValidateLogin, ValidateElelmentVisible;
        public String Login;
        public static String InstitutionCode;
        public static String LoginUsername;
        public static String LoginPassword;
        public static String ReturnObject;

        public static int Count = 0;
        public static int Counting = 0;
        public static String[] lines = { };
 
        public static String LoginReadPath = Resources.LoginLogCounter;
        public static String LoginWritePath = Resources.LoginReport;
        public static String LoginResult = "";

        public String DejaVutLogin(String InstitutionCode, String LoginUsername, String LoginPassword)
        {
            LoginReusables.InstitutionCode = InstitutionCode;
            LoginReusables.LoginUsername = LoginUsername;
            LoginReusables.LoginPassword = LoginPassword;

            driver.FindElement(By.Id(LoginConstants.DejaVuInstitutionCodeTextboxField)).Clear();
            driver.FindElement(By.Id(LoginConstants.DejaVuInstitutionCodeTextboxField)).SendKeys(Keys.Control + "a");
            driver.FindElement(By.Id(LoginConstants.DejaVuInstitutionCodeTextboxField)).SendKeys(LoginReusables.InstitutionCode);

            driver.FindElement(By.Id(LoginConstants.DejaVuUsernameTextboxField)).Clear();
            driver.FindElement(By.Id(LoginConstants.DejaVuUsernameTextboxField)).SendKeys(LoginReusables.LoginUsername);

            driver.FindElement(By.Id(LoginConstants.DejaVuTestPasswordField)).Clear();
            driver.FindElement(By.Id(LoginConstants.DejaVuTestPasswordField)).SendKeys(LoginReusables.LoginPassword);

            driver.FindElement(By.Id(LoginConstants.DejaVuLoginButton)).Click();

            if(InstitutionCode != LoginConstants.DejaVuInstitutionCode && LoginUsername != LoginConstants.DejaVuLoginUsername && LoginPassword != LoginConstants.DejaVutLoginPassword)
            {
                ExpectedResult = "Login Failed"; ActualResult = ExpectedResult; Status = "Passed";
                Output = ExpectedResult +"  " +ActualResult +"  " +Status;

                if (ValidateLogin == ValidateElelmentVisible)
                {
                    ExpectedResult = "Login Failed"; ActualResult = "Login successful"; Status = "Failed";
                    Output = ExpectedResult + "  " + ActualResult + "  " + Status;
                }
            }

            if (InstitutionCode == LoginConstants.DejaVuInstitutionCode && LoginUsername == LoginConstants.DejaVuLoginUsername && LoginPassword == LoginConstants.DejaVutLoginPassword)
            {
                ExpectedResult = "Login successful"; ActualResult = ExpectedResult; Status = "Passed";
                Output = ExpectedResult + "  " + ActualResult + "  " + Status;

                if (ValidateLogin != ValidateElelmentVisible)
                {
                    ExpectedResult = "Login Failed"; ActualResult = "Login successful"; Status = "Failed";
                    Output = ExpectedResult + "  " + ActualResult + "  " + Status;
                }
            }

            ReturnObject = LoginReusables.InstitutionCode + "  " + LoginReusables.LoginUsername + "  " + LoginReusables.LoginPassword +"  " +Output;
            return ReturnObject;
        }
    }
}
