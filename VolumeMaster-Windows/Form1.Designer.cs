namespace VolumeMaster_Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            hamIcon = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            loadConfigFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            label1 = new Label();
            saveButton = new Button();
            richTextBox1 = new RichTextBox();
            idSelect = new NumericUpDown();
            openConfigDialog = new OpenFileDialog();
            label6 = new Label();
            label7 = new Label();
            VMbutton = new Button();
            label8 = new Label();
            textBoxVersion = new TextBox();
            buttonAppSelect = new Button();
            buttonVMSelect = new Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idSelect).BeginInit();
            SuspendLayout();
            // 
            // hamIcon
            // 
            hamIcon.ContextMenuStrip = contextMenuStrip1;
            hamIcon.Icon = (Icon)resources.GetObject("hamIcon.Icon");
            hamIcon.Text = "VoiceMaster";
            hamIcon.Visible = true;
            hamIcon.MouseDoubleClick += hamIcon_MouseDoubleClick;
            hamIcon.MouseDown += notifyIcon1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { loadConfigFileToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(213, 100);
            // 
            // loadConfigFileToolStripMenuItem
            // 
            loadConfigFileToolStripMenuItem.Name = "loadConfigFileToolStripMenuItem";
            loadConfigFileToolStripMenuItem.Size = new Size(212, 32);
            loadConfigFileToolStripMenuItem.Text = "Load Config File";
            loadConfigFileToolStripMenuItem.Click += loadConfigFileToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(212, 32);
            toolStripMenuItem1.Text = "Documentation";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(212, 32);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.BackColor = Color.FromArgb(40, 41, 61);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Bahnschrift", 9.75F);
            comboBox1.ForeColor = SystemColors.ButtonFace;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(294, 54);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 32);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(112, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 5;
            label1.Text = "COM Port:";
            label1.Click += label1_Click;
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Bahnschrift", 12F);
            saveButton.ForeColor = SystemColors.ButtonFace;
            saveButton.Location = new Point(353, 513);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(121, 50);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save All";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(40, 41, 61);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Bahnschrift", 9.75F);
            richTextBox1.ForeColor = SystemColors.ButtonFace;
            richTextBox1.Location = new Point(112, 366);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(360, 137);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // idSelect
            // 
            idSelect.BackColor = Color.FromArgb(40, 41, 61);
            idSelect.BorderStyle = BorderStyle.None;
            idSelect.Font = new Font("Bahnschrift", 12F);
            idSelect.ForeColor = SystemColors.ButtonFace;
            idSelect.Location = new Point(369, 316);
            idSelect.Margin = new Padding(4, 5, 4, 5);
            idSelect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            idSelect.Name = "idSelect";
            idSelect.Size = new Size(103, 32);
            idSelect.TabIndex = 15;
            idSelect.TextAlign = HorizontalAlignment.Center;
            idSelect.Value = new decimal(new int[] { 1, 0, 0, 0 });
            idSelect.ValueChanged += idSelect_ValueChanged;
            // 
            // openConfigDialog
            // 
            openConfigDialog.FileName = "openConfigDialog";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(115, 316);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 29);
            label6.TabIndex = 16;
            label6.Text = "Controller:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(112, 181);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(149, 29);
            label7.TabIndex = 17;
            label7.Text = "VoiceMeeter:";
            // 
            // VMbutton
            // 
            VMbutton.BackColor = Color.FromArgb(27, 28, 39);
            VMbutton.FlatStyle = FlatStyle.Flat;
            VMbutton.Font = new Font("Bahnschrift", 9.5F);
            VMbutton.ForeColor = SystemColors.ButtonFace;
            VMbutton.Location = new Point(301, 177);
            VMbutton.Margin = new Padding(4, 5, 4, 5);
            VMbutton.Name = "VMbutton";
            VMbutton.Size = new Size(171, 42);
            VMbutton.TabIndex = 18;
            VMbutton.Text = "Disabled";
            VMbutton.UseVisualStyleBackColor = false;
            VMbutton.Click += VMbutton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(112, 227);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 29);
            label8.TabIndex = 19;
            label8.Text = "Version:";
            // 
            // textBoxVersion
            // 
            textBoxVersion.BackColor = Color.FromArgb(40, 41, 61);
            textBoxVersion.BorderStyle = BorderStyle.None;
            textBoxVersion.Font = new Font("Bahnschrift", 9.75F);
            textBoxVersion.ForeColor = SystemColors.ButtonFace;
            textBoxVersion.Location = new Point(294, 232);
            textBoxVersion.Margin = new Padding(4, 5, 4, 5);
            textBoxVersion.Name = "textBoxVersion";
            textBoxVersion.Size = new Size(174, 24);
            textBoxVersion.TabIndex = 20;
            // 
            // buttonAppSelect
            // 
            buttonAppSelect.BackColor = Color.FromArgb(40, 41, 61);
            buttonAppSelect.FlatStyle = FlatStyle.Popup;
            buttonAppSelect.Font = new Font("Bahnschrift", 9.5F);
            buttonAppSelect.ForeColor = SystemColors.ButtonFace;
            buttonAppSelect.Location = new Point(26, 366);
            buttonAppSelect.Margin = new Padding(4, 5, 4, 5);
            buttonAppSelect.Name = "buttonAppSelect";
            buttonAppSelect.Size = new Size(77, 42);
            buttonAppSelect.TabIndex = 21;
            buttonAppSelect.Text = "Apps";
            buttonAppSelect.UseVisualStyleBackColor = false;
            buttonAppSelect.Click += buttonAppSelect_Click;
            // 
            // buttonVMSelect
            // 
            buttonVMSelect.BackColor = Color.FromArgb(27, 28, 39);
            buttonVMSelect.FlatStyle = FlatStyle.Popup;
            buttonVMSelect.Font = new Font("Bahnschrift", 9.5F);
            buttonVMSelect.ForeColor = SystemColors.ButtonFace;
            buttonVMSelect.Location = new Point(26, 418);
            buttonVMSelect.Margin = new Padding(4, 5, 4, 5);
            buttonVMSelect.Name = "buttonVMSelect";
            buttonVMSelect.Size = new Size(77, 42);
            buttonVMSelect.TabIndex = 22;
            buttonVMSelect.Text = "VM";
            buttonVMSelect.UseVisualStyleBackColor = false;
            buttonVMSelect.Click += buttonVMSelect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(27, 28, 39);
            CausesValidation = false;
            ClientSize = new Size(550, 600);
            Controls.Add(buttonVMSelect);
            Controls.Add(buttonAppSelect);
            Controls.Add(textBoxVersion);
            Controls.Add(label8);
            Controls.Add(VMbutton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(idSelect);
            Controls.Add(richTextBox1);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(571, 833);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VolumeMaster";
            Deactivate += Form1_Deactivate;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            DragLeave += Form1_Resize;
            Resize += Form1_Resize;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)idSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private NotifyIcon hamIcon;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ComboBox comboBox1;
        private Label label1;
        private Button saveButton;
        private RichTextBox richTextBox1;
        private NumericUpDown idSelect;
        private ToolStripMenuItem loadConfigFileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private OpenFileDialog openConfigDialog;
        private Label label6;
        private Label label7;
        private Button VMbutton;
        private Label label8;
        private TextBox textBoxVersion;
        private Button buttonAppSelect;
        private Button buttonVMSelect;
    }
}