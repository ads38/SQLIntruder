using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Windows.Forms;
namespace SQLIntruder
{
    /// <summary>
    /// 局域网扫描服务类，封装类，不能被继承
    /// </summary>
    sealed class LANScanner
    {
        private string LocalIP;
        private IPSrvProvider ipsrv;
        private Ping ping;
        public string result;
        private  int ScanProgress;
        private BackgroundWorker bgw;
          
        /// <summary>
        /// 初始化封装类 LANScanner
        /// </summary>
        /// <param name="_localip">本机IP地址</param>
        public LANScanner(string _localip)
        {
            ipsrv = new IPSrvProvider();
             
            
            LocalIP = _localip;
            ScanProgress = 0;
            //后台操作执行
            bgw = new BackgroundWorker();
            //属性设置
            bgw.WorkerSupportsCancellation = true;//允许退出
            bgw.WorkerReportsProgress = true;//允许报告情况
            //注册事件
            bgw.DoWork += Bgw_DoWork;
            bgw.ProgressChanged += Bgw_ProgressChanged;
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ScanProgress = e.ProgressPercentage;
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Scan(sender);
        }

        private void Scan(object obj)
        {
          
                lstv.Items.Add(result);
                bgw.ReportProgress(i);
            }
        }

        public void StartScan(ListView v)
        {

            bgw.RunWorkerAsync(v);
            
        }
        public void CancelScan()
        {
            bgw.CancelAsync();
        }

        public int GetProgress()
        {
            return ScanProgress;
        }
    }
}
