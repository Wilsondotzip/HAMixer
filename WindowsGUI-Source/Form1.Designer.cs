namespace HAM_Windows
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hamIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxBaudrate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBytesize = new System.Windows.Forms.TextBox();
            this.textBoxParity = new System.Windows.Forms.TextBox();
            this.textBoxStopbits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.idSelect = new System.Windows.Forms.NumericUpDown();
            this.openConfigDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VMbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.buttonAppSelect = new System.Windows.Forms.Button();
            this.buttonVMSelect = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // hamIcon
            // 
            this.hamIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.hamIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("hamIcon.Icon")));
            this.hamIcon.Text = "HAM";
            this.hamIcon.Visible = true;
            this.hamIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // loadConfigFileToolStripMenuItem
            // 
            this.loadConfigFileToolStripMenuItem.Name = "loadConfigFileToolStripMenuItem";
            this.loadConfigFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loadConfigFileToolStripMenuItem.Text = "Load Config File";
            this.loadConfigFileToolStripMenuItem.Click += new System.EventHandler(this.loadConfigFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "Documentation";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // textBoxBaudrate
            // 
            this.textBoxBaudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.textBoxBaudrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBaudrate.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBaudrate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxBaudrate.Location = new System.Drawing.Point(190, 68);
            this.textBoxBaudrate.Name = "textBoxBaudrate";
            this.textBoxBaudrate.Size = new System.Drawing.Size(120, 16);
            this.textBoxBaudrate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(62, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(60, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baudrate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(60, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bytesize:";
            // 
            // textBoxBytesize
            // 
            this.textBoxBytesize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.textBoxBytesize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBytesize.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBytesize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxBytesize.Location = new System.Drawing.Point(190, 96);
            this.textBoxBytesize.Name = "textBoxBytesize";
            this.textBoxBytesize.Size = new System.Drawing.Size(120, 16);
            this.textBoxBytesize.TabIndex = 8;
            // 
            // textBoxParity
            // 
            this.textBoxParity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.textBoxParity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParity.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxParity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxParity.Location = new System.Drawing.Point(190, 125);
            this.textBoxParity.Name = "textBoxParity";
            this.textBoxParity.Size = new System.Drawing.Size(120, 16);
            this.textBoxParity.TabIndex = 9;
            // 
            // textBoxStopbits
            // 
            this.textBoxStopbits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.textBoxStopbits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStopbits.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStopbits.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxStopbits.Location = new System.Drawing.Point(190, 154);
            this.textBoxStopbits.Name = "textBoxStopbits";
            this.textBoxStopbits.Size = new System.Drawing.Size(120, 16);
            this.textBoxStopbits.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(60, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(60, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stopbits:";
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(225, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 30);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save All";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Location = new System.Drawing.Point(58, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 82);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // idSelect
            // 
            this.idSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.idSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idSelect.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.idSelect.Location = new System.Drawing.Point(238, 290);
            this.idSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idSelect.Name = "idSelect";
            this.idSelect.Size = new System.Drawing.Size(72, 23);
            this.idSelect.TabIndex = 15;
            this.idSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idSelect.ValueChanged += new System.EventHandler(this.idSelect_ValueChanged);
            // 
            // openConfigDialog
            // 
            this.openConfigDialog.FileName = "openConfigDialog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(60, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Controller:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(62, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "VoiceMeeter:";
            // 
            // VMbutton
            // 
            this.VMbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.VMbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VMbutton.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VMbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VMbutton.Location = new System.Drawing.Point(190, 212);
            this.VMbutton.Name = "VMbutton";
            this.VMbutton.Size = new System.Drawing.Size(120, 25);
            this.VMbutton.TabIndex = 18;
            this.VMbutton.Text = "Disabled";
            this.VMbutton.UseVisualStyleBackColor = false;
            this.VMbutton.Click += new System.EventHandler(this.VMbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(62, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Version:";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.textBoxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVersion.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxVersion.Location = new System.Drawing.Point(190, 245);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(122, 16);
            this.textBoxVersion.TabIndex = 20;
            // 
            // buttonAppSelect
            // 
            this.buttonAppSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.buttonAppSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAppSelect.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAppSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAppSelect.Location = new System.Drawing.Point(-2, 320);
            this.buttonAppSelect.Name = "buttonAppSelect";
            this.buttonAppSelect.Size = new System.Drawing.Size(54, 25);
            this.buttonAppSelect.TabIndex = 21;
            this.buttonAppSelect.Text = "Apps";
            this.buttonAppSelect.UseVisualStyleBackColor = false;
            this.buttonAppSelect.Click += new System.EventHandler(this.buttonAppSelect_Click);
            // 
            // buttonVMSelect
            // 
            this.buttonVMSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.buttonVMSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVMSelect.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVMSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVMSelect.Location = new System.Drawing.Point(-2, 351);
            this.buttonVMSelect.Name = "buttonVMSelect";
            this.buttonVMSelect.Size = new System.Drawing.Size(54, 25);
            this.buttonVMSelect.TabIndex = 22;
            this.buttonVMSelect.Text = "VM";
            this.buttonVMSelect.UseVisualStyleBackColor = false;
            this.buttonVMSelect.Click += new System.EventHandler(this.buttonVMSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.buttonVMSelect);
            this.Controls.Add(this.buttonAppSelect);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VMbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idSelect);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStopbits);
            this.Controls.Add(this.textBoxParity);
            this.Controls.Add(this.textBoxBytesize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBaudrate);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HAM Controller ";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragLeave += new System.EventHandler(this.Form1_Resize);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon hamIcon;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ComboBox comboBox1;
        private TextBox textBoxBaudrate;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxBytesize;
        private TextBox textBoxParity;
        private TextBox textBoxStopbits;
        private Label label4;
        private Label label5;
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