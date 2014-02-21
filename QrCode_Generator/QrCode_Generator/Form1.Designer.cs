namespace QrCode_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.qrCodeGraphicControl = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFour = new Telerik.WinControls.UI.RadRadioButton();
            this.radioTwo = new Telerik.WinControls.UI.RadRadioButton();
            this.radioZero = new Telerik.WinControls.UI.RadRadioButton();
            this.cboErrorCorrectionLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLightBrush1 = new System.Windows.Forms.Button();
            this.btnDarkBrush1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.QRCodeGeneratorPage = new System.Windows.Forms.TabControl();
            this.tbRandomPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lblContrast = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tbUIPage = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.qrCodeGraphicControl1 = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboErrorCorrectionLevel1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lightBrush1 = new System.Windows.Forms.Button();
            this.darkBrush1 = new System.Windows.Forms.Button();
            this.radioFour1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radioTwo1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radioZero1 = new Telerik.WinControls.UI.RadRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioZero)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.QRCodeGeneratorPage.SuspendLayout();
            this.tbRandomPage.SuspendLayout();
            this.tbUIPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioFour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioTwo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioZero1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrCodeGraphicControl
            // 
            this.qrCodeGraphicControl.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.H;
            this.qrCodeGraphicControl.Location = new System.Drawing.Point(6, 6);
            this.qrCodeGraphicControl.Name = "qrCodeGraphicControl";
            this.qrCodeGraphicControl.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Zero;
            this.qrCodeGraphicControl.Size = new System.Drawing.Size(189, 191);
            this.qrCodeGraphicControl.TabIndex = 0;
            this.qrCodeGraphicControl.Text = "qrCodeGraphicControl1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFour);
            this.groupBox1.Controls.Add(this.radioTwo);
            this.groupBox1.Controls.Add(this.radioZero);
            this.groupBox1.Controls.Add(this.cboErrorCorrectionLevel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLightBrush1);
            this.groupBox1.Controls.Add(this.btnDarkBrush1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(230, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radioFour
            // 
            this.radioFour.Location = new System.Drawing.Point(225, 48);
            this.radioFour.Name = "radioFour";
            this.radioFour.Size = new System.Drawing.Size(43, 18);
            this.radioFour.TabIndex = 8;
            this.radioFour.Text = "Four";
            this.radioFour.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.QuietZoneModule_ToogleStateChanged);
            // 
            // radioTwo
            // 
            this.radioTwo.Location = new System.Drawing.Point(178, 48);
            this.radioTwo.Name = "radioTwo";
            this.radioTwo.Size = new System.Drawing.Size(41, 18);
            this.radioTwo.TabIndex = 8;
            this.radioTwo.Text = "Two";
            this.radioTwo.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.QuietZoneModule_ToogleStateChanged);
            // 
            // radioZero
            // 
            this.radioZero.Location = new System.Drawing.Point(129, 48);
            this.radioZero.Name = "radioZero";
            this.radioZero.Size = new System.Drawing.Size(43, 18);
            this.radioZero.TabIndex = 8;
            this.radioZero.Text = "Zero";
            this.radioZero.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.QuietZoneModule_ToogleStateChanged);
            // 
            // cboErrorCorrectionLevel
            // 
            this.cboErrorCorrectionLevel.FormattingEnabled = true;
            this.cboErrorCorrectionLevel.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.cboErrorCorrectionLevel.Location = new System.Drawing.Point(129, 18);
            this.cboErrorCorrectionLevel.Name = "cboErrorCorrectionLevel";
            this.cboErrorCorrectionLevel.Size = new System.Drawing.Size(150, 21);
            this.cboErrorCorrectionLevel.TabIndex = 7;
            this.cboErrorCorrectionLevel.SelectedIndexChanged += new System.EventHandler(this.ErrorCorrectionLevel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Foreground Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Background Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quiet Zone Module:";
            // 
            // btnLightBrush1
            // 
            this.btnLightBrush1.Location = new System.Drawing.Point(126, 107);
            this.btnLightBrush1.Name = "btnLightBrush1";
            this.btnLightBrush1.Size = new System.Drawing.Size(153, 29);
            this.btnLightBrush1.TabIndex = 3;
            this.btnLightBrush1.Text = "Foreground Brush";
            this.btnLightBrush1.UseVisualStyleBackColor = true;
            this.btnLightBrush1.Click += new System.EventHandler(this.BtnLightBrush1_Click);
            // 
            // btnDarkBrush1
            // 
            this.btnDarkBrush1.Location = new System.Drawing.Point(126, 72);
            this.btnDarkBrush1.Name = "btnDarkBrush1";
            this.btnDarkBrush1.Size = new System.Drawing.Size(153, 29);
            this.btnDarkBrush1.TabIndex = 3;
            this.btnDarkBrush1.Text = "Background Brush";
            this.btnDarkBrush1.UseVisualStyleBackColor = true;
            this.btnDarkBrush1.Click += new System.EventHandler(this.BtnDarkBrush1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Error Correction Levels:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "&Save";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Generate_Click);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(8, 200);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(72, 18);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.Text = "00000000";
            // 
            // QRCodeGeneratorPage
            // 
            this.QRCodeGeneratorPage.Controls.Add(this.tbRandomPage);
            this.QRCodeGeneratorPage.Controls.Add(this.tbUIPage);
            this.QRCodeGeneratorPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QRCodeGeneratorPage.Location = new System.Drawing.Point(0, 0);
            this.QRCodeGeneratorPage.Name = "QRCodeGeneratorPage";
            this.QRCodeGeneratorPage.SelectedIndex = 0;
            this.QRCodeGeneratorPage.Size = new System.Drawing.Size(534, 271);
            this.QRCodeGeneratorPage.TabIndex = 5;
            // 
            // tbRandomPage
            // 
            this.tbRandomPage.Controls.Add(this.qrCodeGraphicControl);
            this.tbRandomPage.Controls.Add(this.label8);
            this.tbRandomPage.Controls.Add(this.lblContrast);
            this.tbRandomPage.Controls.Add(this.lblClientID);
            this.tbRandomPage.Controls.Add(this.groupBox1);
            this.tbRandomPage.Controls.Add(this.button4);
            this.tbRandomPage.Controls.Add(this.button3);
            this.tbRandomPage.Location = new System.Drawing.Point(4, 22);
            this.tbRandomPage.Name = "tbRandomPage";
            this.tbRandomPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbRandomPage.Size = new System.Drawing.Size(526, 245);
            this.tbRandomPage.TabIndex = 0;
            this.tbRandomPage.Text = "Randomized";
            this.tbRandomPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Contrast Level:";
            // 
            // lblContrast
            // 
            this.lblContrast.AutoSize = true;
            this.lblContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrast.ForeColor = System.Drawing.Color.Green;
            this.lblContrast.Location = new System.Drawing.Point(324, 160);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(36, 17);
            this.lblContrast.TabIndex = 4;
            this.lblContrast.Text = "0.00";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbUIPage
            // 
            this.tbUIPage.Controls.Add(this.btnSave);
            this.tbUIPage.Controls.Add(this.label11);
            this.tbUIPage.Controls.Add(this.label12);
            this.tbUIPage.Controls.Add(this.textBoxInput);
            this.tbUIPage.Controls.Add(this.qrCodeGraphicControl1);
            this.tbUIPage.Controls.Add(this.groupBox2);
            this.tbUIPage.Controls.Add(this.label5);
            this.tbUIPage.Location = new System.Drawing.Point(4, 22);
            this.tbUIPage.Name = "tbUIPage";
            this.tbUIPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbUIPage.Size = new System.Drawing.Size(526, 245);
            this.tbUIPage.TabIndex = 1;
            this.tbUIPage.Text = "User Input";
            this.tbUIPage.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(443, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Contrast Level:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(320, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "0.00";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(42, 219);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(185, 20);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.Text = "Change me to see what happens.";
            this.textBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // qrCodeGraphicControl1
            // 
            this.qrCodeGraphicControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.H;
            this.qrCodeGraphicControl1.Location = new System.Drawing.Point(6, 6);
            this.qrCodeGraphicControl1.Name = "qrCodeGraphicControl1";
            this.qrCodeGraphicControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Zero;
            this.qrCodeGraphicControl1.Size = new System.Drawing.Size(189, 191);
            this.qrCodeGraphicControl1.TabIndex = 3;
            this.qrCodeGraphicControl1.Text = "qrCodeGraphicControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboErrorCorrectionLevel1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lightBrush1);
            this.groupBox2.Controls.Add(this.darkBrush1);
            this.groupBox2.Controls.Add(this.radioFour1);
            this.groupBox2.Controls.Add(this.radioTwo1);
            this.groupBox2.Controls.Add(this.radioZero1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(230, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // cboErrorCorrectionLevel1
            // 
            this.cboErrorCorrectionLevel1.FormattingEnabled = true;
            this.cboErrorCorrectionLevel1.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.cboErrorCorrectionLevel1.Location = new System.Drawing.Point(129, 18);
            this.cboErrorCorrectionLevel1.Name = "cboErrorCorrectionLevel1";
            this.cboErrorCorrectionLevel1.Size = new System.Drawing.Size(150, 21);
            this.cboErrorCorrectionLevel1.TabIndex = 11;
            this.cboErrorCorrectionLevel1.SelectedIndexChanged += new System.EventHandler(this.ErrorCorrectionLevel_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Foreground Color:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Background Color:";
            // 
            // lightBrush1
            // 
            this.lightBrush1.Location = new System.Drawing.Point(129, 111);
            this.lightBrush1.Name = "lightBrush1";
            this.lightBrush1.Size = new System.Drawing.Size(152, 29);
            this.lightBrush1.TabIndex = 7;
            this.lightBrush1.Text = "Foreground Brush";
            this.lightBrush1.UseVisualStyleBackColor = true;
            this.lightBrush1.Click += new System.EventHandler(this.BtnLightBrush2_Click);
            // 
            // darkBrush1
            // 
            this.darkBrush1.Location = new System.Drawing.Point(129, 76);
            this.darkBrush1.Name = "darkBrush1";
            this.darkBrush1.Size = new System.Drawing.Size(152, 29);
            this.darkBrush1.TabIndex = 8;
            this.darkBrush1.Text = "Background Brush";
            this.darkBrush1.UseVisualStyleBackColor = true;
            this.darkBrush1.Click += new System.EventHandler(this.BtnDarkBrush2_Click);
            // 
            // radioFour1
            // 
            this.radioFour1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioFour1.Location = new System.Drawing.Point(234, 49);
            this.radioFour1.Name = "radioFour1";
            // 
            // 
            // 
            this.radioFour1.RootElement.ControlBounds = new System.Drawing.Rectangle(234, 49, 110, 18);
            this.radioFour1.RootElement.StretchHorizontally = true;
            this.radioFour1.RootElement.StretchVertically = true;
            this.radioFour1.Size = new System.Drawing.Size(46, 17);
            this.radioFour1.TabIndex = 6;
            this.radioFour1.TabStop = true;
            this.radioFour1.Text = "Four";
            this.radioFour1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.QuietZoneModule_ToogleStateChanged);
            // 
            // radioTwo1
            // 
            this.radioTwo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioTwo1.Location = new System.Drawing.Point(182, 49);
            this.radioTwo1.Name = "radioTwo1";
            // 
            // 
            // 
            this.radioTwo1.RootElement.ControlBounds = new System.Drawing.Rectangle(182, 49, 110, 18);
            this.radioTwo1.RootElement.StretchHorizontally = true;
            this.radioTwo1.RootElement.StretchVertically = true;
            this.radioTwo1.Size = new System.Drawing.Size(46, 17);
            this.radioTwo1.TabIndex = 6;
            this.radioTwo1.TabStop = true;
            this.radioTwo1.Text = "Two";
            this.radioTwo1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.QuietZoneModule_ToogleStateChanged);
            // 
            // radioZero1
            // 
            this.radioZero1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioZero1.Location = new System.Drawing.Point(129, 49);
            this.radioZero1.Name = "radioZero1";
            // 
            // 
            // 
            this.radioZero1.RootElement.ControlBounds = new System.Drawing.Rectangle(129, 49, 110, 18);
            this.radioZero1.RootElement.StretchHorizontally = true;
            this.radioZero1.RootElement.StretchVertically = true;
            this.radioZero1.Size = new System.Drawing.Size(47, 17);
            this.radioZero1.TabIndex = 6;
            this.radioZero1.TabStop = true;
            this.radioZero1.Text = "Zero";
            this.radioZero1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.QuietZoneModule_ToogleStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quiet Zone Module:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Error Correction Levels:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Text";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QRCodeGeneratorPage);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 271);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "QRCode Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioZero)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.QRCodeGeneratorPage.ResumeLayout(false);
            this.tbRandomPage.ResumeLayout(false);
            this.tbRandomPage.PerformLayout();
            this.tbUIPage.ResumeLayout(false);
            this.tbUIPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioFour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioTwo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioZero1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl qrCodeGraphicControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDarkBrush1;
        private System.Windows.Forms.TabControl QRCodeGeneratorPage;
        private System.Windows.Forms.TabPage tbRandomPage;
        private System.Windows.Forms.TabPage tbUIPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxInput;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl qrCodeGraphicControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLightBrush1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button lightBrush1;
        private System.Windows.Forms.Button darkBrush1;
        private System.Windows.Forms.ComboBox cboErrorCorrectionLevel;
        private Telerik.WinControls.UI.RadRadioButton radioFour;
        private Telerik.WinControls.UI.RadRadioButton radioTwo;
        private Telerik.WinControls.UI.RadRadioButton radioZero;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboErrorCorrectionLevel1;
        private Telerik.WinControls.UI.RadRadioButton radioFour1;
        private Telerik.WinControls.UI.RadRadioButton radioTwo1;
        private Telerik.WinControls.UI.RadRadioButton radioZero1;
    }
}

