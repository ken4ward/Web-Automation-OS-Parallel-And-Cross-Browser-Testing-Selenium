﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppZoneTestProjects.Functional.Reports.Settings.Interface.SystemAdmin.Users {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class UserValidation : global::System.Configuration.ApplicationSettingsBase {
        
        private static UserValidation defaultInstance = ((UserValidation)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UserValidation())));
        
        public static UserValidation Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#UserAddUI > footer")]
        public string UserFooter {
            get {
                return ((string)(this["UserFooter"]));
            }
            set {
                this["UserFooter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#UserAddUI > div > header > h2")]
        public string HeaderText {
            get {
                return ((string)(this["HeaderText"]));
            }
            set {
                this["HeaderText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#bigBoxColor3 > p")]
        public string RegistrationFailedResponse {
            get {
                return ((string)(this["RegistrationFailedResponse"]));
            }
            set {
                this["RegistrationFailedResponse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#Users_wrapper > div.dt-toolbar-footer")]
        public string UserPageLoad {
            get {
                return ((string)(this["UserPageLoad"]));
            }
            set {
                this["UserPageLoad"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#bigBox1")]
        public string RegistrationFailedPanels {
            get {
                return ((string)(this["RegistrationFailedPanels"]));
            }
            set {
                this["RegistrationFailedPanels"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#botClose1")]
        public string CloseFailedPanel {
            get {
                return ((string)(this["CloseFailedPanel"]));
            }
            set {
                this["CloseFailedPanel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Setting {
            get {
                return ((string)(this["Setting"]));
            }
            set {
                this["Setting"] = value;
            }
        }
    }
}
