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

namespace HCI_Project
{
    public partial class Drum_Pad_Form : Form
    {
        System.Media.SoundPlayer Player1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Player2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Player3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Player4 = new System.Media.SoundPlayer();


        public Drum_Pad_Form()
        {
            InitializeComponent();
            turnOffMet.Checked = true;
            /*
            Player1.SoundLocation = "C:\\Users\\conor\\Documents\\HCI_Sounds\\ChineseSnare.wav";
            Player1.Load();
            Player2.SoundLocation = "C:\\Users\\conor\\Documents\\HCI_Sounds\\Stock808.wav";
            Player2.Load();
            Player3.SoundLocation = "C:\\Users\\conor\\Documents\\HCI_Sounds\\COMPANYKick.wav";
            Player3.Load();
            Player4.SoundLocation = "C:\\Users\\conor\\Documents\\HCI_Sounds\\COMPANYHat.wav";
            Player4.Load();
            */
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
            turnOnMet.Checked = true;
            turnOffMet.Checked = false;
        }

        private void turnOffMet_Click(object sender, EventArgs e)
        {
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
            player.URL = @"C:\Users\conor\Documents\HCI_Sounds\COMPANYShaker.wav";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Player2.Play();
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\conor\Documents\HCI_Sounds\Stock808.wav";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Player3.Play();
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\conor\Documents\HCI_Sounds\COMPANYOpenhat.wav";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Player4.Play();
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\conor\Documents\HCI_Sounds\CP.wav";
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
