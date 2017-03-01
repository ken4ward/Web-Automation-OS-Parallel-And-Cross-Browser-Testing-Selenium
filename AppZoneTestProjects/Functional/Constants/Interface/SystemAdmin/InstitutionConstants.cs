using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppZoneTestProjects.Functional.Settings.Interface.SystemAdmin.Institution;

namespace AppZoneTestProjects.Functional.Constants.Interface.SystemAdmin
{
    public class InstitutionConstants
    {
        public static String InstitutionName       = InstitutionElements.Default.InstitutionName;
        public static String InstitutionAddress    = InstitutionElements.Default.InstitutionAddress;
        public static String InstitutionEmail      = InstitutionElements.Default.InstitutionEmail;
        public static String InstitutionPhone      = InstitutionElements.Default.InstitutionPhone;
        public static String InstitutionShortName  = InstitutionElements.Default.InstitutionShortName;
        public static String InstitutionSlogan     = InstitutionElements.Default.InstitutionSlogan;
        public static String InstitutionHQName     = InstitutionElements.Default.InstitutionDefaultBranchName;
        public static String InstitutionHQLocation = InstitutionElements.Default.InstitutionDefaultRegionName;
        public static String InstitutionSave       = InstitutionElements.Default.InstitutionSave;

        public static String InstituteAdminFirstName    = InstitutionElements.Default.InstituteAdminFirstName;
        public static String InstituteAdminLastName     = InstitutionElements.Default.InstituteAdminLastName;
        public static String InstituteAdminContactPhone = InstitutionElements.Default.InstituteAdminContactPhone;
        public static String InstituteAdminContactEmail = InstitutionElements.Default.InstituteAdminContactEmail;

        public static String InstituteName         = "Global Creation Inc.";
        public static String InstituteAddress      = "1, Global Mall, Ikeja, Lagos";
        public static String InstitutieEmail       = "ken4ward@yahoo.com";
        public static String InstitutePhone        = "08023472436";
        public static String InstituteShortName    = "Global-C";
        public static String InstituteSlogan       = "We keep flying";
        public static String InstituteHQName       = "Global Creation Inc., HQ";
        public static String InstituteHQLocation   = "50, Queens Street, Yaba, Lagos, Nigeria";

        public static String InstituteAdminFName = "Kehinde";
        public static String InstituteAdminLName = "Adeoya";
        public static String InstituteAdminPhone = "08023472436";
        public static String InstituteAdminEmail = "kadeoya@appzonegroup.com";

        public static String InstituteWrongParameter   = "1234567890";
        public static String InstituteEmptyParameter   = "";
        public static String InstituteSpecialCharacter = "$%&*@<>";

        public static String InstituteSpecialCharacterWithInt    = "4.";
        public static String InstituteSpecialCharacterWithString = "@%^&*#string";
        public static String InstituteSpaceCharacter             = "123  abc";
    }
}
