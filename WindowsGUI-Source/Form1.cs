using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Runtime.Serialization;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using System.Drawing;
using System.Windows.Forms;
using HAM_Windows.Properties;
namespace HAM_Windows;

public partial class Form1 : Form
{
    Dictionary<string, string> mapped = new();
    Process backEndScript;
    
    static string defaultComport = "COM4";
    static string defaultBaudrate = "9600";
    static string defaultBytesize = "8";
    static string defaultParity = "N";
    static string defaultStopbits = "2";
    
    public class Config
    {
        [YamlMember(Alias = "comport", ApplyNamingConventions = false), DefaultValue("COM4")]
        public string comport { get; set; }= defaultComport;
        
        [YamlMember(Alias = "baudrate", ApplyNamingConventions = false), DefaultValue("9600")]
        public string baudrate { get; set; }= defaultBaudrate;
        
        [YamlMember(Alias = "bytesize", ApplyNamingConventions = false), DefaultValue("16")]
        public string bytesize { get; set; }= defaultBytesize;
        
        [YamlMember(Alias = "parity", ApplyNamingConventions = false), DefaultValue("N")]
        public string parity { get; set; }= defaultParity;
        
        [YamlMember(Alias = "stopbits", ApplyNamingConventions = false), DefaultValue("2")]
        public string stopbits { get; set; }= defaultStopbits;


        public Dictionary<string, AppsString>? Mappings { get; set; }

        public class AppsString
        { 
            public string Applications { get; set; }
        }
    }


    public Form1()
    {

        Location = new Point((Screen.PrimaryScreen.Bounds.Width - 350), (Screen.PrimaryScreen.Bounds.Height - 505));
        InitializeComponent();
        this.hamIcon.Icon = Properties.Resources.iconred;

        Thread wd = new Thread(new ThreadStart(watchDog)); // Ant said this is dumb
        wd.Start(); // Ant said this is dumb 
        //do an initial port scan
        //var ports = SerialPort.GetPortNames();
        //backEndScript = Process.Start(@"HAM.exe");
    }


    private const int CP_DISABLE_CLOSE_BUTTON = 0x200;

    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
            return cp;
        }
    }


    private void Form1_Resize(object sender, EventArgs e)
    {
        //if the form is minimized  
        //hide it from the task bar  
        //and show the system tray icon (represented by the NotifyIcon control)  
        if (WindowState != FormWindowState.Minimized) return;
        Hide();
        WindowState = FormWindowState.Normal;
        hamIcon.Visible = true;

    }


    private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Show();
            Show();
            Activate();
        }
    }

  

    private async void watchDog()
    {
        int i = 0;
        int d = 0;
        while (true) 
        {
            await Task.Delay(3000);

            Process[] processes = Process.GetProcessesByName("HAM-Headless");
            if (processes.Length == 0)
            {
                this.hamIcon.Icon = Properties.Resources.iconred;
                if (i == 0) 
                { hamIcon.ShowBalloonTip(1000, "HAM Disconnected", "Oh shucks... Something's gone wrong - attempting to reconnect", ToolTipIcon.Warning); i = 1; }
                else { BackendControl(1);}
                
            }
            else
            {
                this.hamIcon.Icon = Properties.Resources.icongreen;
                if (i == 1) { i = 3; hamIcon.ShowBalloonTip(1000, "HAM Connected", "Good news we're back online", ToolTipIcon.None); } else if (i == 3) { i = 0; }
                d = 0;
            }
        }
       

    }
    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        loadConfig(@"config.yaml");
        BackendControl(1);
    }

    private void BackendControl(int code)
    {
        if (code == 1)
            backEndScript = Process.Start(@"HAM-Headless.exe");
        else
            foreach (var process in Process.GetProcessesByName("HAM-Headless"))
                process.Kill();
        
    }

    private void comboBox1_Click(object sender, EventArgs e)
    {
        // Display each port name to the console.
        comboBox1.Items.Clear();

        comboBox1.Items.AddRange(SerialPort.GetPortNames());
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        saveConfig();
        MessageBox.Show("config.yaml has been saved");
        this.hamIcon.Icon = Properties.Resources.icongreen;

    }

    private string? tryGetID(string key)
    {
        return mapped.TryGetValue(key, out string? value) ? value : "";
    }

    private void loadConfig(string path)
    {
        if (!File.Exists(path))
        {
            var newFile = File.Create(path);
            newFile.Close();
        }
        string text = File.ReadAllText(path); //read file
        richTextBox1.Text = text; //quick debug flash to know the file is being read

        //deserialize file
        var deserializer = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();
        Config deserialized = deserializer.Deserialize<Config>(text);

        if (deserialized == null)
        {
            deserialized = new Config();
        }

        //cleanly re map do a fresh dictionary
        mapped.Clear();
        if (deserialized.Mappings != null)
        {
            foreach (var (key, value) in deserialized.Mappings)
            {
                mapped.Add(key, value.Applications);

            }
        }
        else
        {
            mapped.Add("ID1", "");
        }

        //set the text box to a current
        try
        {
            richTextBox1.Text = mapped[$"ID{idSelect.Value}"];
        }
        catch
        {
            richTextBox1.Text = "";

        }
        //set input boxes to data that was saved in config
        comboBox1.Text = deserialized.comport != null ? deserialized.comport : defaultComport;
        textBoxBaudrate.Text = deserialized.baudrate != null ? deserialized.baudrate : defaultBaudrate;
        textBoxBytesize.Text = deserialized.bytesize != null ? deserialized.bytesize : defaultBytesize;
        textBoxParity.Text = deserialized.parity != null ? deserialized.parity : defaultParity;
        textBoxStopbits.Text = deserialized.stopbits != null ? deserialized.stopbits : defaultStopbits;

    }

    private void saveConfig()
    {
        BackendControl(0);
        SaveCurrentMap();

        var comport = comboBox1.Text;
        var baudrate = textBoxBaudrate.Text;
        var parity = textBoxParity.Text;
        var stopbits = textBoxStopbits.Text;
        var bytesize = textBoxBytesize.Text;

        var mappings = mapped.Aggregate("", (current, map) => current + $"    {map.Key}:\n        Applications: {map.Value}\n");
        
        Console.WriteLine(mappings);
        //config gen
        var yml = @$"
comport: {comport}
baudrate: {baudrate}
bytesize: {bytesize}
parity: {parity}
stopbits: {stopbits}

Mappings:
{mappings}

";
        
        Console.Write(yml);
        File.WriteAllText("config.yaml", yml);

        loadConfig(@"config.yaml");
        BackendControl(1);
    }

    private void idSelect_ValueChanged(object sender, EventArgs e)
    {
        richTextBox1.Text = mapped.TryGetValue($"ID{idSelect.Value}", out var stored) ? stored : "";
    }

    private void buttonSaveMap_Click(object sender, EventArgs e)
    {
        SaveCurrentMap();
    }

    private void SaveCurrentMap()
    {
        if (mapped.ContainsKey($"ID{idSelect.Value}"))
        {
            if (mapped[$"ID{idSelect.Value}"] == richTextBox1.Text) return;
            mapped.Remove($"ID{idSelect.Value}");
            mapped.Add($"ID{idSelect.Value}", richTextBox1.Text);
        }
        else
        {
            mapped.Add($"ID{idSelect.Value}", richTextBox1.Text);
        }
    }
    
    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "https://github.com/Wilsondotzip/HardwareApplicationMixer",
            UseShellExecute = true
        });
    }

    private void loadConfigFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openConfigDialog.ShowDialog() != DialogResult.OK) return;
        var configPath = openConfigDialog.FileName;
        MessageBox.Show("Loading config file from:  " + configPath);
        loadConfig(configPath);
        saveConfig();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        BackendControl(0);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void Form1_Deactivate(Object sender, EventArgs e)
    {
        Hide();

    }

}