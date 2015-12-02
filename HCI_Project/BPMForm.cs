using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Project
{
    public partial class BPMForm : Form
    {
        public double BPM;
        public BPMForm(double bpm)
        {
            InitializeComponent();
            this.numericUpDown1.Value = (decimal)bpm;
            this.BPM = bpm;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            this.BPM = (double)this.numericUpDown1.Value;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
