using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Resources;

namespace WindowsFormsApplication1
{
    public partial class Spammer : Form
    {
        public Spammer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F8))
            {
                button1.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F9))
            {
                button2.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label3.Text = "Status: Inactive";
 /*           progressBar1.Style = ProgressBarStyle.Marquee; 
            progressBar1.MarqueeAnimationSpeed = 0; 
            progressBar1.Value = 0; */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label3.Text = "Status: Active";
 //           progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_speed.Text = trackBar1.Value + " ms";
            timer1.Interval = trackBar1.Value;
        }

        private void displayTime()
        {
            label1.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_speed_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            displayTime();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 test = new Form2();
            test.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
