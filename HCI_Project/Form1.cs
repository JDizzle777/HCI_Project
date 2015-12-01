﻿using System;
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
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\JD\Documents\Visual Studio 2015\Projects\HCI_Project\sounds\ChineseSnare.wav";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\JD\Documents\Visual Studio 2015\Projects\HCI_Project\sounds\Stock808.wav";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\JD\Documents\Visual Studio 2015\Projects\HCI_Project\sounds\COMPANYKick.wav";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\JD\Documents\Visual Studio 2015\Projects\HCI_Project\sounds\COMPANYHat.wav";
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
