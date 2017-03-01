using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AppZoneTestProjects.Functional.Reusables.Login;
using AppZoneTestProjects.Functional.Constants.Login;
using AppZoneTestProjects.Functional.Base;
using AppZoneTestProjects.Functional.Utils.Login;
using AppZoneTestProjects.Properties;
using AppZoneTestProjects.Functional.Reports;

namespace AppZoneTestProjects.Functional.Suits.Login
{
    public class LoginSuites : Base.Base
    {
        public LoginReusables LoginReusables;
        public LoginSuites() { }
        public LoginSuites(IWebDriver driver) : base(driver) { }

        public static int Count = 0;
        public static int Counting = 0;
        public static String[] lines = { };

        public static String LoginReadPath = Resources.LoginLogCounter;
        public static String LoginWritePath = Resources.LoginReport;
        public static String LoginResult = "";
        public static int Divisor = 0;
        public static int[] Counter = {};

        public static String[] ParametersValuesOne = { LoginConstants.DejaVuEmptyParameter, LoginConstants.DejaVutWrongParameter, LoginConstants.DejaVuInstitutionCode };
        public static String[] ParametersValuesTwo = { LoginConstants.DejaVuSpecialCharacter, LoginConstants.DejaVuSpecialCharacterWithInt, LoginConstants.DejaVuLoginUsername };
        public static String[] ParametersValuesThree = { LoginConstants.DejaVuSpecialCharacterWithString, LoginConstants.DejaVuSpaceCharacter, LoginConstants.DejaVutLoginPassword };
        
        public void DejavuSuiteForLogin()
        {
            LoginReusables = new LoginReusables(driver);

            foreach(string valueOne in LoginSuites.ParametersValuesOne)
            {
                foreach (string valueTwo in LoginSuites.ParametersValuesTwo)
                {
                    foreach (string valueThree in LoginSuites.ParametersValuesThree)
                    {
                        ++Count;
                        ReportEngine.Count = Count;
                        LoginResult = LoginReusables.DejaVutLogin(valueOne, valueTwo, valueThree);
                        ReportEngine.ReportEngineGlobal(1, LoginReadPath, LoginWritePath, LoginResult);
                        new Base.Base(driver).LoginFailed(LoginValidate.FailedLoginPanel, LoginConstants.FailedLoginButton);
                    }
                }
            } 
        }
    }
}
