using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace QrCode_Generator
{
    public partial class Form1 : Form
    {
        private Color lightModule = Color.FromArgb(220, 45, 187, 219); // Forground color
        private Color darkModule = Color.FromArgb(170, 20, 34, 250);  // Background color
        private bool suspendCheckBox = false;
        private bool suspendRadioButtons = false;

        public Form1()
        {
            InitializeComponent();
            qrCodeGraphicControl.DarkBrush = new SolidBrush(darkModule);
            qrCodeGraphicControl.LightBrush = new SolidBrush(lightModule);
            qrCodeGraphicControl1.Text = textBoxInput.Text;
            ContrastCal();
        }

        #region Random Code Generator

        private int RandomNumber(int maxNumber)
        {
            byte[] b = new byte[4];
            new RNGCryptoServiceProvider().GetBytes(b);
            int seed = (b[0] & 0x7f) << 24 | b[1] << 16 | b[2] << 8 | b[3];
            Random num = new Random(seed);
            return num.Next(1, maxNumber);
        }

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToUpper();
            return builder.ToString();
        }

        public string GetClientID()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(2, true));
            builder.Append(RandomNumber(100000));
            builder.Append(RandomString(1, false));
            return builder.ToString();
        }

        private void GenerateID()
        {
            lblClientID.Text = "CT" + "-" + GetClientID();
            qrCodeGraphicControl.Text = lblClientID.Text;

            BitMatrix qrMatrix = qrCodeGraphicControl.GetQrMatrix(); //Qr bit matrix for input string.

            qrCodeGraphicControl.Lock();  //Lock class.
            qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.M;  //It won't encode and repaint.
            qrCodeGraphicControl.QuietZoneModule = QuietZoneModules.Zero;
            qrMatrix = qrCodeGraphicControl.GetQrMatrix(); //Qr bit matrix for input string.
            qrCodeGraphicControl.UnLock();
        }

        #endregion Random Code Generator

        #region Methods

        private void OnTimerEvent(object sender, EventArgs e)
        {
            GenerateID();
            timer1.Enabled = false;
        }

        /// <summary>
        /// Form load events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Automatic generateID Timer
            Timer t = new Timer();
            t.Interval = 5000;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
            cboErrorCorrectionLevel.SelectedIndex = 1;           
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            qrCodeGraphicControl1.Text = textBoxInput.Text;
        }

        /// <summary>
        /// Displays the contrast ratio for the dark and light brushes.
        /// </summary>
        private void ContrastCal()
        {
            SolidBrush darkModuleBrush = qrCodeGraphicControl.DarkBrush as SolidBrush;
            SolidBrush lightModuleBrush = qrCodeGraphicControl.LightBrush as SolidBrush;
            Color darkmodule = darkModuleBrush == null ? darkModule : darkModuleBrush.Color;
            Color lightmodule = lightModuleBrush == null ? lightModule : lightModuleBrush.Color;

            Contrast ctrast = ColorContrast.GetContrast(new FormColor(lightmodule), new FormColor(darkmodule));
            lblContrast.Text = ctrast.Ratio.ToString();            
        }

        private void UpdateSelectedQuietZone()
        {
            suspendRadioButtons = true;

            if (this.qrCodeGraphicControl.QuietZoneModule.Equals(radioZero))
            {
                this.radioZero.IsChecked = true;
            }
            else if (this.qrCodeGraphicControl.QuietZoneModule.Equals(radioTwo))
            {
                this.radioTwo.IsChecked = true;
            }
            else if (this.qrCodeGraphicControl.QuietZoneModule.Equals(radioFour))
            {
                this.radioFour.IsChecked = true;
            }

            if (this.qrCodeGraphicControl1.QuietZoneModule.Equals(radioZero1))
            {
                this.radioZero1.IsChecked = true;
            }
            else if (this.qrCodeGraphicControl1.QuietZoneModule.Equals(radioTwo1))
            {
                this.radioTwo1.IsChecked = true;
            }
            else if (this.qrCodeGraphicControl1.QuietZoneModule.Equals(radioFour1))
            {
                this.radioFour1.IsChecked = true;
            }

            suspendRadioButtons = false;
        }

        #endregion Methods

        #region Event Handler

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// Randomized QrCode generator foreground color
        /// </summary>
        /// <param name="sender">Event handler to foreground color </param>
        /// <param name="e"></param>
        private void BtnDarkBrush1_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            SolidBrush brush = qrCodeGraphicControl.DarkBrush as SolidBrush;
            colordlg.Color = brush == null ? darkModule : brush.Color;

            if (colordlg.ShowDialog() == DialogResult.OK)
            {
                qrCodeGraphicControl.DarkBrush = new SolidBrush(colordlg.Color);
                darkModule = colordlg.Color;
                ContrastCal();
            }

        }

        /// <summary>
        /// Radomized QrCode generator background color
        /// </summary>
        /// <param name="sender">Event handler for background color</param>
        /// <param name="e"></param>
        private void BtnLightBrush1_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            SolidBrush brush = qrCodeGraphicControl.LightBrush as SolidBrush;
            colordlg.Color = brush == null ? lightModule : brush.Color;

            if (colordlg.ShowDialog() == DialogResult.OK)
            {
                qrCodeGraphicControl.DarkBrush = new SolidBrush(colordlg.Color);
                lightModule = colordlg.Color;
                ContrastCal();
            }
        }

        /// <summary>
        /// Click to randomize the code generated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generate_Click(object sender, EventArgs e)
        {
            GenerateID();
        }

        /// <summary>
        /// User initated QrCode generator foreground color
        /// </summary>
        /// <param name="sender">Event handler to foreground color </param>
        /// <param name="e"></param>
        private void BtnDarkBrush2_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            SolidBrush brush = qrCodeGraphicControl1.DarkBrush as SolidBrush;
            colordlg.Color = brush == null ? darkModule : brush.Color;

            if (colordlg.ShowDialog() == DialogResult.OK)
            {
                qrCodeGraphicControl.DarkBrush = new SolidBrush(colordlg.Color);
                darkModule = colordlg.Color;
                ContrastCal();
            }
        }

        /// <summary>
        /// User initated QrCode generator background color
        /// </summary>
        /// <param name="sender">Event handler for background color</param>
        /// <param name="e"></param>
        private void BtnLightBrush2_Click(object sender, EventArgs e)
        {
            ColorDialog colordlg = new ColorDialog();
            SolidBrush brush = qrCodeGraphicControl1.LightBrush as SolidBrush;
            colordlg.Color = brush == null ? lightModule : brush.Color;

            if (colordlg.ShowDialog() == DialogResult.OK)
            {
                qrCodeGraphicControl.DarkBrush = new SolidBrush(colordlg.Color);
                lightModule = colordlg.Color;
                ContrastCal();
            }
        }

        /// <summary>
        /// Exit Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void ErrorCorrectionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string errorCorrection = cboErrorCorrectionLevel.Text;

            if (errorCorrection == "L")
            {
                this.qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.L;
            }
            else if (errorCorrection == "M")
            {
                this.qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.M;
            }
            else if (errorCorrection == "Q")
            {
                this.qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.Q;
            }
            else if (errorCorrection == "H")
            {
                this.qrCodeGraphicControl.ErrorCorrectLevel = ErrorCorrectionLevel.H;
            }

            string errorCorrection1 = cboErrorCorrectionLevel1.Text;

            if (errorCorrection1 == "L")
            {
                this.qrCodeGraphicControl1.ErrorCorrectLevel = ErrorCorrectionLevel.L;
            }
            else if (errorCorrection1 == "M")
            {
                this.qrCodeGraphicControl1.ErrorCorrectLevel = ErrorCorrectionLevel.M;
            }
            else if (errorCorrection1 == "Q")
            {
                this.qrCodeGraphicControl1.ErrorCorrectLevel = ErrorCorrectionLevel.Q;
            }
            else if (errorCorrection1 == "H")
            {
                this.qrCodeGraphicControl1.ErrorCorrectLevel = ErrorCorrectionLevel.H;
            }
        }

        private void QuietZoneModule_ToogleStateChanged(object sender, StateChangedEventArgs e)
        {
           if(e.ToggleState != Telerik.WinControls.Enumerations.ToggleState.On || suspendRadioButtons)
           {
               return;
           }

            if (sender == this.radioZero)
            {
                this.qrCodeGraphicControl.QuietZoneModule = QuietZoneModules.Zero;
            }
            else if (sender == this.radioTwo)
            {
                this.qrCodeGraphicControl.QuietZoneModule = QuietZoneModules.Two;
            }
            else if (sender == this.radioFour)
            {
                this.qrCodeGraphicControl.QuietZoneModule = QuietZoneModules.Four;
            }

            if (sender == this.radioZero1)
            {
                this.qrCodeGraphicControl1.QuietZoneModule = QuietZoneModules.Zero;
            }
            else if (sender == this.radioTwo1)
            {
                this.qrCodeGraphicControl1.QuietZoneModule = QuietZoneModules.Two;
            }
            else if (sender == this.radioFour1)
            {
                this.qrCodeGraphicControl1.QuietZoneModule = QuietZoneModules.Four;
            }
        }
        #endregion Event Handler
                
        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"PNG (*.png)|*.png|Bitmap (*.bmp)|*.bmp|Encapsuled PostScript (*.eps)|*.eps|SVG (*.svg)|*.svg";
            saveFileDialog.FileName = Path.GetFileName(GetFileNameProposal());
            saveFileDialog.DefaultExt = "png";

            if(saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (saveFileDialog.FileName.EndsWith("eps"))
            {
                BitMatrix matrix = qrCodeGraphicControl.GetQrMatrix();

                // Initialize the EPS renderer
                var renderer = new EncapsulatedPostScriptRenderer(
                    new FixedModuleSize(6, QuietZoneModules.Two), // Modules size is 6/72th inch (72 points = 1 inch)
                    new FormColor(Color.Black), new FormColor(Color.White));

                using (var file = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                {
                    renderer.WriteToStream(matrix, file);
                }
            }
            else if (saveFileDialog.FileName.EndsWith("svg"))
            {
                BitMatrix matrix = qrCodeGraphicControl.GetQrMatrix();

                // Initialize the EPS renderer
                var renderer = new SVGRenderer(
                     new FixedModuleSize(6, QuietZoneModules.Two), // Modules size is 6/72th inch (72 points = 1 inch)
                    new FormColor(Color.FromArgb(150, 200, 200, 210)), new FormColor(Color.FromArgb(200, 255, 155, 0)));

                using(var file = File.OpenWrite(saveFileDialog.FileName))
                {
                    renderer.WriteToStream(matrix, file, false);
                }
            }
            else
            {
                GraphicsRenderer gRender = new GraphicsRenderer(new FixedModuleSize(30, QuietZoneModules.Four));
                BitMatrix matrix = qrCodeGraphicControl1.GetQrMatrix();
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    gRender.WriteToStream(matrix, ImageFormat.Png, stream, new Point(600, 600));
                }
            }

        }

        private string GetFileNameProposal()
        {
            if (QRCodeGeneratorPage.SelectedTab.Text.Contains(tbUIPage.Text))
            {
               return textBoxInput.Text.Length > 10 ? textBoxInput.Text.Substring(0, 10) : textBoxInput.Text;      
            }
            else
            {
               return lblClientID.Text.Length > 10 ? lblClientID.Text.Substring(0, 10) : lblClientID.Text;
            }      
        }
     
    }
}