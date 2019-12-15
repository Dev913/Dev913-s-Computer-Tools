using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Dev913_s_Computer_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/f");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r");
        }
        private void metroTile4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Administrative Tools");
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "\\Users\\jeffp\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\System Tools");
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Process.Start("SystemSettings.exe");
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Process.Start("\\Windows\\System32");
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            {
                if (System.Environment.Is64BitOperatingSystem == true)
                {
                    metroTile3.Text = "x64";
                }
                else if (System.Environment.Is64BitOperatingSystem == false)
                {
                    metroTile3.Text = "x32";
                }
            }
        }
    }
}