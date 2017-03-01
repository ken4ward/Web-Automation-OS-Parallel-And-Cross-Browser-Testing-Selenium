using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppZoneTestProjects.Functional.Settings.Login;

namespace AppZoneTestProjects.Functional.Constants.Login
{
    public class LoginConstants
    {
        public static String TargetServerURL                   = LoginElements.Default.DejaVuURL;
        public static String DejaVuInstitutionCodeTextboxField = LoginElements.Default.DejaVuInstitutionCodeTextbox;
        public static String DejaVuUsernameTextboxField        = LoginElements.Default.DejaVuUsernameTextbox;
        public static String DejaVuTestPasswordField           = LoginElements.Default.DejaVuPasswordTextbox;
        public static String DejaVuLoginButton                 = LoginElements.Default.DejaVuLoginButton;
        public static String DejavuFalseLoginOKButton          = LoginElements.Default.DejavuFalseLoginOKButton;
        public static String DejavuFalseLoginForm              = LoginElements.Default.DejavuFalseLoginForm;
        public static String FailedLoginButton                 = LoginElements.Default.FailedLoginButton;

        public static String DejaVuLoginUsername   = "kadeoya";
        public static String DejaVutLoginPassword  = "111111";
        public static String DejaVuInstitutionCode = "4";

        public static String DejaVutWrongParameter  = "1234567890";
        public static String DejaVuEmptyParameter   = "";
        public static String DejaVuSpecialCharacter = "$%&*@<>";

        public static String DejaVuSpecialCharacterWithInt    = "4.";
        public static String DejaVuSpecialCharacterWithString = "@%^&*#string";
        public static String DejaVuSpaceCharacter             = "123  abc";
    }

    public class LoginValidate
    {
        public static String ImageValidatePageLoad   = LoginValidation.Default.ImageValidatePageLoad;
        public static String LoginSuccessfulValidate = LoginValidation.Default.LoginSuccessfulValidate;
        public static String FailedLoginPanel        = LoginValidation.Default.FailedLoginPanel;
        public static String ChangePassword          = LoginValidation.Default.ChangePassword;
        public static String DefaultFooter           = LoginValidation.Default.DefaultFooter;
        public static String Inbox                   = "Inbox";
    }

    public class TradeportMultiBrowserURLs
    {
        public static String TargetServerURL = LoginElements.Default.DejaVuURL;
        public static String SeleniumHubURL  = LoginElements.Default.SeleniumHubURL;
    }  
}
