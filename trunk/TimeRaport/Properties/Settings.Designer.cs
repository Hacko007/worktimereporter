﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hackovic.TimeReport.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=|DataDirectory|\\TimeLogDB.sdf")]
        public string TimeLogDBConnectionString {
            get {
                return ((string)(this["TimeLogDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<Root>\r\n\t<Holiday><Date>2008-12-31 00:00" +
            ":00</Date><Name>Nyårsafton</Name><Info></Info><TimeToWork>0</TimeToWork></Holida" +
            "y>\r\n\t<Holiday><Date>2009-01-01 00:00:00</Date><Name>Nyårsdagen</Name><Info></Inf" +
            "o><TimeToWork>0</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-01-05 00:00:00</Dat" +
            "e><Name>Trettondagsafton</Name><Info></Info><TimeToWork>4</TimeToWork></Holiday>" +
            "\r\n\t<Holiday><Date>2009-01-06 00:00:00</Date><Name>Trettondag jul</Name><Info></I" +
            "nfo><TimeToWork>0</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-04-09 00:00:00</D" +
            "ate><Name>Skärtorsdag</Name><Info></Info><TimeToWork>4</TimeToWork></Holiday>\r\n\t" +
            "<Holiday><Date>2009-04-10 00:00:00</Date><Name>Långfredagen</Name><Info></Info><" +
            "TimeToWork>0</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-04-13 00:00:00</Date><" +
            "Name>Annandag påsk</Name><Info></Info><TimeToWork>0</TimeToWork></Holiday>\r\n\t<Ho" +
            "liday><Date>2009-04-30 00:00:00</Date><Name>Valborgsmässoafton</Name><Info></Inf" +
            "o><TimeToWork>4</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-05-01 00:00:00</Dat" +
            "e><Name>Första Maj</Name><Info></Info><TimeToWork>0</TimeToWork></Holiday>\r\n\t<Ho" +
            "liday><Date>2009-05-21 00:00:00</Date><Name>Kristi himmelsfärdsdag</Name><Info><" +
            "/Info><TimeToWork>0</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-05-30 00:00:00<" +
            "/Date><Name>Pingstafton</Name><Info></Info><TimeToWork>0</TimeToWork></Holiday>\r" +
            "\n\t<Holiday><Date>2009-05-31 00:00:00</Date><Name>Pingstdagen</Name><Info></Info>" +
            "<TimeToWork>0</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-06-06 00:00:00</Date>" +
            "<Name>Sveriges nationaldag</Name><Info></Info><TimeToWork>0</TimeToWork></Holida" +
            "y>\r\n\t<Holiday><Date>2009-06-18 00:00:00</Date><Name>Dag före midsommarafton</Nam" +
            "e><Info></Info><TimeToWork>4</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-06-19 " +
            "00:00:00</Date><Name>Dag före midsommarafton</Name><Info></Info><TimeToWork>0</T" +
            "imeToWork></Holiday>\r\n\t<Holiday><Date>2009-06-20 00:00:00</Date><Name>Midsommard" +
            "agen</Name><Info></Info><TimeToWork>0</TimeToWork></Holiday>\r\n\t<Holiday><Date>20" +
            "09-10-30 00:00:00</Date><Name>Dag före alla helgons dag</Name><Info></Info><Time" +
            "ToWork>4</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-10-31 00:00:00</Date><Name" +
            ">Alla helgons dag</Name><Info></Info><TimeToWork>0</TimeToWork></Holiday>\r\n\t<Hol" +
            "iday><Date>2009-12-24 00:00:00</Date><Name>Julafton</Name><Info></Info><TimeToWo" +
            "rk>0</TimeToWork></Holiday>\r\n\t<Holiday><Date>2009-12-25 00:00:00</Date><Name>Jul" +
            "dagen</Name><Info></Info><TimeToWork>0</TimeToWork></Holiday>\r\n\t<Holiday><Date>2" +
            "009-12-26 00:00:00</Date><Name>Annandag jul</Name><Info></Info><TimeToWork>0</Ti" +
            "meToWork></Holiday>\r\n</Root>\r\n")]
        public string Holidays {
            get {
                return ((string)(this["Holidays"]));
            }
            set {
                this["Holidays"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
    }
}
