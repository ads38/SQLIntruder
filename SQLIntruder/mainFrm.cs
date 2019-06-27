using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

using System.Collections.Generic;

namespace SQLIntruder
{
    public partial class mainFrm : Form
    {
        private IPSrvProvider ips;
        private Ping ping;
        private string result;
        private bool IsCancelCilcked;//指示是否取消
        private bool IsWireConn;//本地链接是否断开
        private string CMDExecStatus;//指示执行命令的状态
        private bool IsBatchExec;   //是否批量执行
        private bool IsNewVer;      //SQL server 是不是新版本
        /// <summary>
        /// 存放已经扫描到的IP地址
        /// </summary>
        private List<string> ScannedIP;
        /// <summary>
        /// 命令最终是否执行成功
        /// </summary>
        private bool IsSucessful;
        public mainFrm()
        {
            InitializeComponent();
            ips = new IPSrvProvider();
            ping = new Ping();
            ScannedIP = new List<string>();
            CheckForIllegalCrossThreadCalls = false;
            IsCancelCilcked = false;
            IsWireConn = true;
            IsSucessful = false;
            IsBatchExec = false;
            IsNewVer = true;
        }

        //窗体加载
        private void mainFrm_Load(object sender, EventArgs e)
        {
            if (ips.IsConnected() == true)
            {
                statusLbl.Text = ("已经联网！！");
                IPlbl.Text = ips.GetLocalIP();
                hostNamelbl.Text = ips.GetLocalhostName();
            }
            else
            {
                statusLbl.Text = ("请求超时，或者断开了网络连接");
                IPlbl.Text = ips.GetLocalIP();
                hostNamelbl.Text = ips.GetLocalhostName();
            }
        }
        //状态刷新
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            mainFrm_Load(sender, e);
            if (ips.GetLocalIP() != "127.0.0.1")
                IsWireConn = true;
            else
            {
                IsWireConn = false;
                OnlinePCLstv.Items.Clear();
                SelectedIPTxt.Clear();
            }

        }
        //开始扫描
        private void ScanBtn_Click(object sender, EventArgs e)
        {
            bgw.RunWorkerAsync();//开始ping
            IsCancelCilcked = false;    //置为false，重新报告进度
            OnlinePCLstv.Items.Clear();//清空列表框
            ProcLbl.Visible = true;
            //清空存放的ip地址组
            ScannedIP.Clear();
        }
        //后台线程执行
        private void bgw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //根据本地ip地址获取局域网计算机列表
            //取 192.168.1. ip地址段
            ScanBtn.Enabled = false;
            CancelScanBtn.Enabled = true;//激活终止扫描按钮
            string[] splitedIP = ips.GetSplitedIP(ips.GetLocalIP());
            //192.168.1.  
            string IPblock = splitedIP[0] + "." + splitedIP[1] + "." + splitedIP[2] + ".";
            if (ips.GetLocalIP() == "127.0.0.1")
            {
                MessageBox.Show(this, "发生Ping异常,请检查您的网络连接,查看网线是否意外断开,或者禁用了本地连接等." + "\r\n" +
                                  "如果遇到网络延迟值极高的问题,请联系网络管理员."
                      , "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsWireConn = false;
                ScanprogressBar.Value = 0;
                return;
            }
            //从1到255逐个ping
            for (int i = 1; i <= 255; i++)
            {
                ListViewItem items = new ListViewItem();//列表项
                if (bgw.CancellationPending)    //如果CancelAsync()则取消操作
                    return;
                try
                {
                    if (ping.Send(IPblock + i.ToString(), 6).Status == IPStatus.Success)
                    {
                        result = IPblock + i.ToString();
                        items = OnlinePCLstv.Items.Add(result);
                        //计算机名无法获取的情况
                        try
                        {
                            items.SubItems.Add(ips.GetRemoteHostNameByIP(result));
                        }
                        catch (Exception) { items.SubItems.Add("无法获取计算机名"); }
                        items.EnsureVisible();
                    }
                    bgw.ReportProgress(i);

                }
                catch (Exception)/*但是在扫描的时候可能会被断开网络连接，当断开时，提示*/
                {
                    //提示错误
                    MessageBox.Show(this, "发生Ping异常,请检查您的网络连接,查看网线是否意外断开,或者禁用了本地连接等." + "\r\n" +
                                    "如果遇到网络延迟值极高的问题,请联系网络管理员."
                        , "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ScanprogressBar.Value = 0;
                    //网线断开
                    IsWireConn = false;
                    mainFrm_Load(sender, e);
                    SelectedIPTxt.Clear();
                    return;

                }

                ProcLbl.Text = i.ToString();
            }
        }
        //进度报告
        private void bgw_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (IsCancelCilcked)
                ScanprogressBar.Value = 0;
            else
                ScanprogressBar.Value = e.ProgressPercentage;
        }

        //终止扫描
        private void CancelScanBtn_Click(object sender, EventArgs e)
        {
            //禁用本按钮，启用扫描按钮
            CancelScanBtn.Enabled = false;
            ScanBtn.Enabled = true;
            bgw.CancelAsync();//取消后台操作
            //进度重置为0
            IsCancelCilcked = true;
        }

        private void bgw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ScanBtn.Enabled = true;
            CancelScanBtn.Enabled = false;
            ProcLbl.Visible = false;
        }

        private void OnlinePCLstv_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                SelectedIPTxt.Text = OnlinePCLstv.FocusedItem.SubItems[0].Text;
            }
            catch (Exception) {; }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                            this,
                                "单个执行：适用于每台计算机SQL服务器登录名，或者密码有不同的情况，需要一个一个点再执行命令" + "\r\n\r\n" +
                                "批量执行：适用于每台计算机的登录名，密码均相同，如果机房是这样的话，则选择这一项",
                                "帮我选择", MessageBoxButtons.OK, MessageBoxIcon.Information
                            );
        }

        //执行命令
        private void ExecCmdBtn_Click(object sender, EventArgs e)
        {
            CmdExecStatusLstv.Items.Clear();  //清空列表框
            ScannedIP.Clear();
            ExecCmdBtn.Enabled = false;
           
            //查看选项
            if (IsBatchExec == false)//单个执行
            {
                if (
                      SelectedIPTxt.Text.Trim() == "" ||
                      PortTxt.Text.Trim() == "" ||
                      LoginNameTxt.Text.Trim() == "" ||
                      DatabaseCombo.Text.Trim() == ""
                    )
                {
                    MessageBox.Show(this, "选定IP地址，端口，登录名，数据库不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExecCmdBtn.Enabled = true;
                    return;
                }
                ExecuteCMDBGW.RunWorkerAsync();
            }
            else /*是批量执行，必须等待扫描完毕！*/
            {
                //判断是否为空，但是批量执行可以不需要ip地址
                if (
                      PortTxt.Text.Trim() == "" ||
                      LoginNameTxt.Text.Trim() == "" ||
                      DatabaseCombo.Text.Trim() == ""
                    )
                {
                    MessageBox.Show(this, "端口，登录名，数据库不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExecCmdBtn.Enabled = true;
                   
                    return;
                }

                //判断是否在扫描
                if (bgw.IsBusy == true)
                {
                    MessageBox.Show(this, "一定要扫描完毕，再批量执行！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExecCmdBtn.Enabled = true;
                    return;
                }
                else /*不在扫描,或扫描已终止*/

                {
                    //查看列表是否为空,为空提示扫描
                    if (OnlinePCLstv.Items.Count <= 0)
                    {
                        MessageBox.Show(this, "在批量执行的条件下，应该先扫描到网内的计算机，再做操作", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ExecCmdBtn.Enabled = true;
                        return;
                    }
                    else
                    {
                        int count = OnlinePCLstv.Items.Count;
                        if (count <= 0)           //列表框中的个数,如果为0，请扫描
                        {
                            MessageBox.Show(this, "请先扫描，再进行批量执行", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ExecCmdBtn.Enabled = true;
                            return;
                        }
                        else                       //不为空，添加到List容器中
                        {
                            for (int i = 0; i < count; i++)
                                ScannedIP.Add(OnlinePCLstv.Items[i].Text);
                            ExecuteCMDBGW.RunWorkerAsync();
                        }
                    }

                    ExecCmdBtn.Enabled = true;
                }
            }

        }

        //清空反馈结果
        private void ClearResultBtn_Click(object sender, EventArgs e)
        {
            FeedBackTxt.Clear();
            FeedBackTxt.Focus();
        }
        //复制反馈结果
        private void CopyResultBtn_Click(object sender, EventArgs e)
        {
            FeedBackTxt.SelectAll();
            FeedBackTxt.Copy();
            MessageBox.Show(this, "已复制到剪贴板。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExecuteCMDBGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!IsBatchExec) //是单个执行的后台操作
            {
                SQLSrvProvider srv = new SQLSrvProvider(SelectedIPTxt.Text, LoginNameTxt.Text, PasswordTxt.Text, DatabaseCombo.Text, (int)PortTxt.Value);//参数构建
                CmdExecLbl.Text = "正在执行命令..." + " 正在处理的IP地址: " + SelectedIPTxt.Text;//提示
                IsSucessful = srv.ExecRemoteCMD(CmdCombo.Text,IsNewVer);//返回结果
                FeedBackTxt.Text = srv.GetSQLResult();
            }
            else //批量操作
            {
                int count = ScannedIP.Count;//扫描到的ip地址数
                SQLSrvProvider batch = null;
                ListViewItem execItems = new ListViewItem();
                for (int i = 0; i < count; i++)
                {
                    batch = new SQLSrvProvider(ScannedIP[i], LoginNameTxt.Text, PasswordTxt.Text, DatabaseCombo.Text, (int)PortTxt.Value);
                    CmdExecLbl.Text = "正在执行命令..." + " 正在处理的IP地址: " + ScannedIP[i];//提示
                    IsSucessful = batch.ExecRemoteCMD(CmdCombo.Text, IsNewVer);//返回结果
                    FeedBackTxt.Text = batch.GetSQLResult();
                    //判断每一次的结果
                    if (IsSucessful == true)//成功
                    {
                        execItems = CmdExecStatusLstv.Items.Add(ips.GetRemoteHostNameByIP((ScannedIP[i])));
                        execItems.SubItems.Add(ScannedIP[i]);
                        execItems.SubItems.Add("已成功执行！");
                        execItems.EnsureVisible();
                    }
                    else
                    {
                        try
                        {
                            execItems = CmdExecStatusLstv.Items.Add(ips.GetRemoteHostNameByIP((ScannedIP[i])));
                        }
                        catch (Exception) { execItems = CmdExecStatusLstv.Items.Add("计算机名获取失败"); ; }
                        execItems.SubItems.Add(ScannedIP[i]);
                        execItems.SubItems.Add("失败");
                        execItems.EnsureVisible();
                    }
                }
            }

        }

        private void ExecuteCMDBGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //创建列表项，以便添加到，列表框
            ListViewItem execItems = new ListViewItem();
            //IsSucessful 成功 或者 失败
            //成功
            //仅适用于“单个执行”
            if (!IsBatchExec)
            {
                if (IsSucessful == true)
                {
                    execItems = CmdExecStatusLstv.Items.Add(ips.GetRemoteHostNameByIP((SelectedIPTxt.Text)));
                    execItems.SubItems.Add(SelectedIPTxt.Text);
                    execItems.SubItems.Add("已成功执行！");
                    execItems.EnsureVisible();
                }
                else
                {
                    try
                    {
                        execItems = CmdExecStatusLstv.Items.Add(ips.GetRemoteHostNameByIP((SelectedIPTxt.Text)));
                    }
                    catch (Exception) { execItems = CmdExecStatusLstv.Items.Add("计算机名获取失败"); ; }
                    execItems.SubItems.Add(SelectedIPTxt.Text);
                    execItems.SubItems.Add("失败");
                    execItems.EnsureVisible();
                }
                CmdExecLbl.Text = "就绪...";
                ExecCmdBtn.Enabled = true;
            }
            CmdExecLbl.Text = "就绪...";
            ExecCmdBtn.Enabled = true;          //启用执行命令按钮
        }

        //批量执行，单选按钮,需要禁用控件
        private void BatchExecRdo_CheckedChanged(object sender, EventArgs e)
        {
            //IsBatchExec 置为 true
            IsBatchExec = true;
            DisableControls(new Control[] { groupBox2 });
        }
        //单个执行，单选按钮
        private void SingleExecRdo_CheckedChanged(object sender, EventArgs e)
        {
            //置为false
            IsBatchExec = false;
            EnableControls(new Control[] { groupBox2 });
        }


        /// <summary>
        /// 禁用控件
        /// </summary>
        /// <param name="ctrls">所需的控件数组</param>
        private void DisableControls(Control[] ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                ctrl.Enabled = false;
            }
        }
        /// <summary>
        /// 启用控件
        /// </summary>
        /// <param name="ctrls">所需的控件数组</param>
        private void EnableControls(Control[] ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                ctrl.Enabled = true;
            }
        }

        //勾选版本
        private void NewVersionChk_CheckedChanged(object sender, EventArgs e)
        {
            if (NewVersionChk.Checked == true)
                IsNewVer = true;
            else
                IsNewVer = false;

        }

        private void TerminateExecCmdBtn_Click(object sender, EventArgs e)
        {
            ExecuteCMDBGW.CancelAsync();
        }
    }
}
