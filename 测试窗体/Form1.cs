using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
namespace 测试窗体
{
    public partial class Form1 : Form
    {
        private BackgroundWorker bgw;
        private Ping p;
        private Ping p2;
        private Thread th;
        private Ping[] arr;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            bgw = new BackgroundWorker();
            p = new Ping();
            p2 = new Ping();
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;
            bgw.ProgressChanged += Bgw_ProgressChanged;
            bgw.DoWork += Bgw_DoWork;
            bgw.WorkerSupportsCancellation = true;
            bgw.WorkerReportsProgress = true;
            th = new Thread(calc);
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("wanle");
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            calc();
            Calc2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arr = Enumerable.Range(0, 2).Select(i => new Ping()).ToArray();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgw.RunWorkerAsync();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgw.CancelAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void calc()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (bgw.CancellationPending)
                {
                    return;
                }

                if (arr[0].Send("192.168.42." + i.ToString(), 10).Status == IPStatus.Success)
                {
                    MessageBox.Show("192.168.42." + i.ToString());
                }
                label1.Text = "192.168.42." + i.ToString();
                bgw.ReportProgress(i);
            }
        }

        private void Calc2()
        {
            for (int i = 51; i <= 100; i++)
            {
                if (bgw.CancellationPending)
                {
                    return;
                }

                if (arr[1].Send("192.168.42." + i.ToString(), 10).Status == IPStatus.Success)
                {
                    MessageBox.Show("192.168.42." + i.ToString());
                }
                label1.Text = "192.168.42." + i.ToString();
                bgw.ReportProgress(i);
            }
        }
    }
}
