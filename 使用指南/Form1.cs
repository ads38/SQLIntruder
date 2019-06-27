using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 使用指南
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void shareResBtn_Click(object sender, EventArgs e)
        {
            shareResManFrm f = new shareResManFrm();
            f.Show();
        }
    }
}
