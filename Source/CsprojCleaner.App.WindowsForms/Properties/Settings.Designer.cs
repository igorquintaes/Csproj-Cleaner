﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsprojCleaner.App.WindowsForms.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection FileFolderPaths {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["FileFolderPaths"]));
            }
            set {
                this["FileFolderPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection LogFolderPaths {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LogFolderPaths"]));
            }
            set {
                this["LogFolderPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection AllowedExtensions {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AllowedExtensions"]));
            }
            set {
                this["AllowedExtensions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Nothing")]
        public global::CsprojCleaner.Domain.Enums.NonExistentFilesAction NonExistentFilesAction {
            get {
                return ((global::CsprojCleaner.Domain.Enums.NonExistentFilesAction)(this["NonExistentFilesAction"]));
            }
            set {
                this["NonExistentFilesAction"] = value;
            }
        }
    }
}
