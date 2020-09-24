using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Delivery = true;
            frmBasket frmBasket = new frmBasket();
            frmBasket.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Delivery = false;
            frmBasket frmBasket = new frmBasket();
            frmBasket.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;
            timer1.Start();
            lblVersion.Text = "v" + version;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
