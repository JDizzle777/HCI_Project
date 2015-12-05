using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;

namespace HCI_Project
{
    public partial class Drum_Pad_Form : Form
    {
        // paths to audio files
        string button1Path = @"C:\Users\JD\Documents\Visual Studio 2015\Projects\HCI_Project\sounds\COMPANYShaker.wav";
        string button2Path = @"C:\Users\JD\Documents\Visual Studio 2015\Projects\HCI_Project\sounds\Stock808.wav";
        string button3Path = @"C:\Users\JD\Documents\Visual Studio 2015\Projects\HCI_Project\sounds\StockKick.wav";
        string button4Path = @"C:\Users\JD\Documents\Visual Studio 2015\Projects\HCI_Project\sounds\ChineseSnare.wav";

        // default beats per minute
        double BPM = 80.0;
        public bool metOn = false;

        public Drum_Pad_Form()
        {
            InitializeComponent();
            turnOffMet.Checked = true;
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void turnOnMet_Click(object sender, EventArgs e)
        {
            this.metOn = true;
            turnOnMet.Checked = true;
            turnOffMet.Checked = false;
        }

        private void turnOffMet_Click(object sender, EventArgs e)
        {
            this.metOn = false;
            turnOnMet.Checked = false;
            turnOffMet.Checked = true;
        }

        private void Drum_Pad_Form_Load(object sender, EventArgs e)
        {

        }

        private void recordButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Player1.Play();
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = button1Path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Player2.Play();
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = button2Path;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Player3.Play();
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = button3Path;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Player4.Play();
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = button4Path;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Q))
            {
                button1.PerformClick();
            }
            if (keyData == (Keys.W))
            {
                button2.PerformClick();
            }
            if (keyData == (Keys.A))
            {
                button3.PerformClick();
            }
            if (keyData == (Keys.S))
            {
                button4.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void mnuBPM_Click(object sender, EventArgs e)
        {
            BPMForm popup = new BPMForm(BPM);
            DialogResult dialogResult = popup.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                this.BPM = popup.BPM;
            }
            popup.Dispose();
        }

        private void serialConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Please connect your Arduino drum pad to the computer and try again.", "Cannot Find Arduino Drum Pad", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            int temp = 0;
            if (indata != "" && indata != null)
                temp = Convert.ToInt32(indata);

            if (temp > 0)
            {
                setLabel3(indata);
                doButton1Click(true);            
            }
            indata = null;
        }

        delegate void doButton1ClickCallback(bool b);
        private void doButton1Click(bool b)
        {
            if (this.button1.InvokeRequired)
                this.Invoke(new doButton1ClickCallback(doButton1Click), new object[] { b });

            else
                this.button1.PerformClick();
        }

        delegate void setLabel3Callback(string s);
        private void setLabel3(string s)
        {
            if (this.button1.InvokeRequired)
                this.Invoke(new setLabel3Callback(setLabel3), new object[] { s });

           
               // this.label3.Text = s;
        }
    }

    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(3, 5, ClientSize.Width-7, ClientSize.Height-9);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
