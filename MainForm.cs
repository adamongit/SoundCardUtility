using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace SoundCardUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnScan.Text = "Scan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            
            for (int n = 0; n < NAudio.Wave.WaveOut.DeviceCount; n++)
            {
                label1.Text +=
                    String.Format("{0}:{1}", n, NAudio.Wave.WaveOut.GetCapabilities(n).ProductName)
                    + Environment.NewLine;
            }

            btnScan.Text = "Rescan";
        }
       
    }
}
