using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppZoneTestProjects.Functional.Settings.Interface.SystemAdmin.Users;
using AppZoneTestProjects.Functional.Reusables.Interface.SystemAdmin;
using AppZoneTestProjects.Functional.Suits.SystemAdmin;

namespace AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin
{
    public class UserValidations
    {
        public static String UserFooter                 = UserValidation.Default.UserFooter;
        public static String HeaderText                 = UserValidation.Default.HeaderText;
        public static String RegistrationFailedPanels   = UserValidation.Default.RegistrationFailedPanels;
        public static String RegistrationFailedResponse = UserValidation.Default.RegistrationFailedResponse;
        public static String UserPageLoad               = UserValidation.Default.UserPageLoad;
        public static String CloseFailedPanel           = UserValidation.Default.CloseFailedPanel;
    }

    public class UserConstants
    {
        public static String FirstName                 = UserElements.Default.FirstName;
        public static String LastName                  = UserElements.Default.LastName;
        public static String Phone                     = UserElements.Default.Phone;
        public static String Designation               = UserElements.Default.Designation;
        public static String Email                     = UserElements.Default.Email;
        public static String EmployeeNo                = UserElements.Default.EmployeeNo;
        public static String UserName                  = UserElements.Default.UserName;
        public static String UserRole                  = UserElements.Default.UserRole;
        public static String GrandSuperAdminPrivileges = UserElements.Default.GrandSuperAdminPrivileges;
        public static String GrantApprovalRights       = UserElements.Default.GrantApprovalRights;
        public static String SaveButton                = UserElements.Default.SaveButton;
        public static String CreateUser                = UserElements.Default.CreateUser;
        public static String UserReset                 = UserElements.Default.Reset;
        public static String SearchUser                = UserElements.Default.SearchUser;
        public static String UserListView              = UserElements.Default.UserListView;
        public static String SelectValue               = "Testing";
        public static String UserSearch                = "User Search";
        public static String AddNewUser                = "Add New User";
        public static String UserRoleText              = "SuperAdmin";
    }

    
    public class UserVariables
    {
        public static String Placeholder;
        public static String FirstName   = "Kehinde";
        public static String LastName  = "Adeoya";
        public static String Phone = "08023472436";
        public static String Email   = "kadeoya@appzonegroup.com";
        public static String EmployeeNo  = "020";
        public static String Designation = "Software QA";
        public static String UserName = new UsersReusables().GenerateUsername();
        //public static String UserName = UserSuites.ReturnRandom();

        public static String UserWrongParameter  = "123456789012";
        public static String UserEmptyParameter   = "";
        public static String UserSpecialCharacter = "$%&*@<>";
        public static String UserSpecialCharacterInt    = "4.";
        public static String UserSpecialCharacterString = "@%^&*#string";
        public static String UserSpaceCharacter = "123456789";
        public static String UserStringNumber= "1234567890a";      
    }
}
