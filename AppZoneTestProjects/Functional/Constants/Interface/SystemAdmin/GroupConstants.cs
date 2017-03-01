using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppZoneTestProjects.Functional.Settings.Interface.SystemAdmin.Groups;

namespace AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin
{
    public class GroupConstants
    {
        public static String GroupName          = GroupsElements.Default.GroupName;
        public static String GroupCode          = GroupsElements.Default.GroupCode;
        public static String GroupDescription   = GroupsElements.Default.GroupDescription;
        public static String Groups             = GroupsElements.Default.Groups;
        public static String GroupSearch        = GroupsElements.Default.GroupSearch;
        public static String GroupReset         = GroupsElements.Default.GroupReset;
        public static String GroupAdd           = GroupsElements.Default.GroupAdd;
        public static String GroupSave          = GroupsElements.Default.GroupSave;
        public static String GroupDevFunction   = GroupsElements.Default.GroupDevFunction;
        public static String GroupSysAdminFunc  = GroupsElements.Default.GroupSysAdminFunc;
        public static String GroupUserFunctions = GroupsElements.Default.GroupUserFunctions;
        public static String GroupAddFooter     = GroupsElements.Default.GroupAddFooter;
        public static String GroupFooter        = GroupsElements.Default.GroupFooter;

        public static String GroupAddAssert                  = "Add New User Role";
        public static String GroupSearchs                     = "User Role Search";

        public static String GroupNameRight                  = "Software QA";
        public static String GroupCodeRight                  = "020";
        public static String GroupDescriptionRight           = "This is the group created for Appzone Testers";

        public static String GroupWrongParameter             = "1234567890";
        public static String GroupEmptyParameter             = "";
        public static String GroupSpecialCharacter           = "$%&*@<>";

        public static String GroupSpecialCharacterWithInt    = "4.";
        public static String GroupSpecialCharacterWithString = "@%^&*#string";
        public static String GroupSpaceCharacter             = "123  abc";



    }
}
