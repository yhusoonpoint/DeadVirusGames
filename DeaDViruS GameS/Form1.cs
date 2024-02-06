using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace DeaDViruS_GameS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {

                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;

            }

        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = Properties.Resources.TMP;
                notifyIcon1.BalloonTipText = "YOUR FORM IS MINIMIZED HERE. DOUBLE CLICK LOGO TO MAXIMAZE";
                notifyIcon1.ShowBalloonTip(2000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "YOUR FORM IS MAXIMAZED";
                notifyIcon1.ShowBalloonTip(2000);
            }
        
        }
        private void openfile(string open, byte[] opner)
        {
            string locationToSavePdf = Path.Combine(Path.GetTempPath(), open);
            File.WriteAllBytes(locationToSavePdf, opner);
            Process.Start(locationToSavePdf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            openfile("barbie.exe", Properties.Resources.barbie);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            openfile("RPGGame.exe", Properties.Resources.RPGGame);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            openfile("RACING.exe", Properties.Resources.RACING);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            openfile("freshgame.exe", Properties.Resources.freshgame);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            openfile("DK.exe", Properties.Resources.DK);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            openfile("falling rocks.exe", Properties.Resources.falling_rocks);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            openfile("randddd.exe", Properties.Resources.randddd);
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
