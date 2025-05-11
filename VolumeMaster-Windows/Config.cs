using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

public class Config
{

    static string defaultComport = "COM4";
    static string defaultBaudrate = "9600";
    static string defaultBytesize = "8";
    static string defaultParity = "N";
    static string defaultStopbits = "2";
    static string defaultVm = "N";
    static string defaultVmVersion = "banana";
    public string currentVm = defaultVm;
    public string yamlMap = "";
    public string yamlButtonMap = "";


    [YamlMember(Alias = "comport", ApplyNamingConventions = false), DefaultValue("COM4")]
    public string comport { get; set; } = defaultComport;

    [YamlMember(Alias = "baudrate", ApplyNamingConventions = false), DefaultValue("9600")]
    public string baudrate { get; set; } = defaultBaudrate;

    [YamlMember(Alias = "bytesize", ApplyNamingConventions = false), DefaultValue("16")]
    public string bytesize { get; set; } = defaultBytesize;

    [YamlMember(Alias = "parity", ApplyNamingConventions = false), DefaultValue("N")]
    public string parity { get; set; } = defaultParity;

    [YamlMember(Alias = "stopbits", ApplyNamingConventions = false), DefaultValue("2")]
    public string stopbits { get; set; } = defaultStopbits;

    [YamlMember(Alias = "VM", ApplyNamingConventions = false), DefaultValue("N")]
    public string vm { get; set; } = defaultVm;

    [YamlMember(Alias = "VM-Version", ApplyNamingConventions = false), DefaultValue("banana")]
    public string vmversion { get; set; } = defaultVmVersion;

    public Dictionary<string, AppsString>? Mappings { get; set; }

    public class AppsString
    {
        public string Applications { get; set; }
        public string VM { get; set; }


    }

    public Dictionary<string, string>? Buttons { get; set; }



}