﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klons1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("character set=UTF8;data source=localhost;initial catalog=D:\\A1-docs\\c_net\\Klons\\K" +
            "lonsF\\DB\\klons_p.fdb;user id=aivars;Password=parole")]
        public string ConnectionStringF {
            get {
                return ((string)(this["ConnectionStringF"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("character set=UTF8;data source=localhost;initial catalog=D:\\A1-docs\\c_net\\Klons\\K" +
            "lonsA\\DB\\klonsa_p.fdb;user id=aivars;Password=parole")]
        public string ConnectionStringA {
            get {
                return ((string)(this["ConnectionStringA"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("character set=UTF8;data source=localhost;initial catalog=D:\\A1-docs\\c_net\\Klons\\K" +
            "lonsP\\DB\\klonsp_p.fdb;user id=aivars;Password=parole")]
        public string ConnectionStringP {
            get {
                return ((string)(this["ConnectionStringP"]));
            }
        }
    }
}
