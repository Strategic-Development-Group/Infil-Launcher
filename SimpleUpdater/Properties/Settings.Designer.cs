﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleUpdater.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1st-rrf.com/infil")]
        public string ChangelogURL {
            get {
                return ((string)(this["ChangelogURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://content.1st-rrf.com/modpack/Manifest.txt")]
        public string ManifestURL {
            get {
                return ((string)(this["ManifestURL"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int Builder_LastBuildNumber {
            get {
                return ((int)(this["Builder_LastBuildNumber"]));
            }
            set {
                this["Builder_LastBuildNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Builder_LastDirectory {
            get {
                return ((string)(this["Builder_LastDirectory"]));
            }
            set {
                this["Builder_LastDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Builder_LastURL {
            get {
                return ((string)(this["Builder_LastURL"]));
            }
            set {
                this["Builder_LastURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-nosplash -skipIntro")]
        public string ARMA_CustomCommandLine {
            get {
                return ((string)(this["ARMA_CustomCommandLine"]));
            }
            set {
                this["ARMA_CustomCommandLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ARMA_Executable {
            get {
                return ((string)(this["ARMA_Executable"]));
            }
            set {
                this["ARMA_Executable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ARMA_ModpackLocation {
            get {
                return ((string)(this["ARMA_ModpackLocation"]));
            }
            set {
                this["ARMA_ModpackLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ARMA_LastCommandLine {
            get {
                return ((string)(this["ARMA_LastCommandLine"]));
            }
            set {
                this["ARMA_LastCommandLine"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://content.1st-rrf.com/modpack/")]
        public string ContentURL {
            get {
                return ((string)(this["ContentURL"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TeamspeakPluginFolder {
            get {
                return ((string)(this["TeamspeakPluginFolder"]));
            }
            set {
                this["TeamspeakPluginFolder"] = value;
            }
        }
    }
}
