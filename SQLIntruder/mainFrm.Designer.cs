namespace SQLIntruder
{
    partial class mainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hostNamelbl = new System.Windows.Forms.Label();
            this.OnlinePCLstv = new System.Windows.Forms.ListView();
            this.IPAddrCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScannedNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PortTxt = new System.Windows.Forms.NumericUpDown();
            this.DatabaseCombo = new System.Windows.Forms.ComboBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginNameTxt = new System.Windows.Forms.TextBox();
            this.SelectedIPTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.CmdCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ExecCmdBtn = new System.Windows.Forms.Button();
            this.BatchExecRdo = new System.Windows.Forms.RadioButton();
            this.SingleExecRdo = new System.Windows.Forms.RadioButton();
            this.FeedBackTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ScanBtn = new System.Windows.Forms.Button();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.ScanprogressBar = new System.Windows.Forms.ProgressBar();
            this.CancelScanBtn = new System.Windows.Forms.Button();
            this.ProcLbl = new System.Windows.Forms.Label();
            this.ClearResultBtn = new System.Windows.Forms.Button();
            this.CopyResultBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmdExecLbl = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CmdExecStatusLstv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.ExecuteCMDBGW = new System.ComponentModel.BackgroundWorker();
            this.label18 = new System.Windows.Forms.Label();
            this.NewVersionChk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortTxt)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前网络状态:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(129, 28);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(29, 12);
            this.statusLbl.TabIndex = 2;
            this.statusLbl.Text = "未知";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "本机当前IP地址:";
            // 
            // IPlbl
            // 
            this.IPlbl.AutoSize = true;
            this.IPlbl.Location = new System.Drawing.Point(129, 62);
            this.IPlbl.Name = "IPlbl";
            this.IPlbl.Size = new System.Drawing.Size(29, 12);
            this.IPlbl.TabIndex = 4;
            this.IPlbl.Text = "未知";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "计算机名:";
            // 
            // hostNamelbl
            // 
            this.hostNamelbl.AutoSize = true;
            this.hostNamelbl.Location = new System.Drawing.Point(129, 95);
            this.hostNamelbl.Name = "hostNamelbl";
            this.hostNamelbl.Size = new System.Drawing.Size(29, 12);
            this.hostNamelbl.TabIndex = 6;
            this.hostNamelbl.Text = "未知";
            // 
            // OnlinePCLstv
            // 
            this.OnlinePCLstv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IPAddrCol,
            this.ScannedNameCol});
            this.OnlinePCLstv.FullRowSelect = true;
            this.OnlinePCLstv.Location = new System.Drawing.Point(12, 177);
            this.OnlinePCLstv.MultiSelect = false;
            this.OnlinePCLstv.Name = "OnlinePCLstv";
            this.OnlinePCLstv.Size = new System.Drawing.Size(562, 208);
            this.OnlinePCLstv.TabIndex = 7;
            this.OnlinePCLstv.UseCompatibleStateImageBehavior = false;
            this.OnlinePCLstv.View = System.Windows.Forms.View.Details;
            this.OnlinePCLstv.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnlinePCLstv_ItemSelectionChanged);
            // 
            // IPAddrCol
            // 
            this.IPAddrCol.Text = "IP 地址(IPV4)";
            this.IPAddrCol.Width = 142;
            // 
            // ScannedNameCol
            // 
            this.ScannedNameCol.Text = "计算机名";
            this.ScannedNameCol.Width = 346;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.statusLbl);
            this.groupBox1.Controls.Add(this.hostNamelbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IPlbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(487, 90);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(69, 23);
            this.RefreshBtn.TabIndex = 13;
            this.RefreshBtn.Text = "状态刷新";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "当前在线计算机:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PortTxt);
            this.groupBox2.Controls.Add(this.DatabaseCombo);
            this.groupBox2.Controls.Add(this.PasswordTxt);
            this.groupBox2.Controls.Add(this.LoginNameTxt);
            this.groupBox2.Controls.Add(this.SelectedIPTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 222);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "链接数据库";
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(92, 75);
            this.PortTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(154, 21);
            this.PortTxt.TabIndex = 24;
            this.PortTxt.Value = new decimal(new int[] {
            1433,
            0,
            0,
            0});
            // 
            // DatabaseCombo
            // 
            this.DatabaseCombo.FormattingEnabled = true;
            this.DatabaseCombo.Items.AddRange(new object[] {
            "master",
            "tempdb",
            "model",
            "msdb"});
            this.DatabaseCombo.Location = new System.Drawing.Point(92, 188);
            this.DatabaseCombo.Name = "DatabaseCombo";
            this.DatabaseCombo.Size = new System.Drawing.Size(154, 20);
            this.DatabaseCombo.TabIndex = 18;
            this.DatabaseCombo.Text = "master";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(92, 150);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(154, 21);
            this.PasswordTxt.TabIndex = 14;
            // 
            // LoginNameTxt
            // 
            this.LoginNameTxt.Location = new System.Drawing.Point(92, 112);
            this.LoginNameTxt.Name = "LoginNameTxt";
            this.LoginNameTxt.Size = new System.Drawing.Size(154, 21);
            this.LoginNameTxt.TabIndex = 13;
            this.LoginNameTxt.Text = "sa";
            // 
            // SelectedIPTxt
            // 
            this.SelectedIPTxt.Location = new System.Drawing.Point(92, 36);
            this.SelectedIPTxt.Name = "SelectedIPTxt";
            this.SelectedIPTxt.Size = new System.Drawing.Size(154, 21);
            this.SelectedIPTxt.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "端口:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "选定IP地址:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "登入数据库:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "密码:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "登录名:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.HelpBtn);
            this.groupBox3.Controls.Add(this.CmdCombo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ExecCmdBtn);
            this.groupBox3.Controls.Add(this.BatchExecRdo);
            this.groupBox3.Controls.Add(this.SingleExecRdo);
            this.groupBox3.Location = new System.Drawing.Point(281, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 222);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "远程CMD命令执行";
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(17, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 45);
            this.label15.TabIndex = 23;
            this.label15.Text = "请不要执行耗费时间太久的cmd命令，否则会导致超时，默认执行命令的超时为30 Sec";
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(17, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 36);
            this.label14.TabIndex = 22;
            this.label14.Text = "列表框里已经包含了常用的命令，如定时关机，启动信使服务，启动telnet服务，以及查看关闭进程等等，请谨慎使用";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(17, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(245, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = "例如 shutdown -s -t 10 && ping www.qq.com";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(17, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "如果要输入多个命令，请用两个取地址符连接";
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(211, 32);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(76, 22);
            this.HelpBtn.TabIndex = 19;
            this.HelpBtn.Text = "该选哪个？";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // CmdCombo
            // 
            this.CmdCombo.FormattingEnabled = true;
            this.CmdCombo.Items.AddRange(new object[] {
            "Ping 127.0.0.1",
            "sc config Messenger start= AUTO && net start Messenger",
            "sc config tlntSvr start= AUTO && net start tlntSvr",
            "net start Messenger",
            "shutdown -s -t 360 -c \"Comments\"",
            "net send \"192.168.1.200\" \"Messages\"",
            "Tasklist",
            "Taskkill /f /im ProcessName.exe",
            "ntsd -c q -pn ProcessName.exe",
            "ntsd -c q -p PID(eg.4562)",
            "net share admin$",
            "attrib +s +h +r \"G:\" /S /D"});
            this.CmdCombo.Location = new System.Drawing.Point(19, 151);
            this.CmdCombo.Name = "CmdCombo";
            this.CmdCombo.Size = new System.Drawing.Size(265, 20);
            this.CmdCombo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(17, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "输入要执行的cmd命令";
            // 
            // ExecCmdBtn
            // 
            this.ExecCmdBtn.Location = new System.Drawing.Point(201, 186);
            this.ExecCmdBtn.Name = "ExecCmdBtn";
            this.ExecCmdBtn.Size = new System.Drawing.Size(83, 23);
            this.ExecCmdBtn.TabIndex = 13;
            this.ExecCmdBtn.Text = "执行命令";
            this.ExecCmdBtn.UseVisualStyleBackColor = true;
            this.ExecCmdBtn.Click += new System.EventHandler(this.ExecCmdBtn_Click);
            // 
            // BatchExecRdo
            // 
            this.BatchExecRdo.AutoSize = true;
            this.BatchExecRdo.Location = new System.Drawing.Point(115, 35);
            this.BatchExecRdo.Name = "BatchExecRdo";
            this.BatchExecRdo.Size = new System.Drawing.Size(71, 16);
            this.BatchExecRdo.TabIndex = 1;
            this.BatchExecRdo.Text = "批量执行";
            this.BatchExecRdo.UseVisualStyleBackColor = true;
            this.BatchExecRdo.CheckedChanged += new System.EventHandler(this.BatchExecRdo_CheckedChanged);
            // 
            // SingleExecRdo
            // 
            this.SingleExecRdo.AutoSize = true;
            this.SingleExecRdo.Checked = true;
            this.SingleExecRdo.Location = new System.Drawing.Point(19, 35);
            this.SingleExecRdo.Name = "SingleExecRdo";
            this.SingleExecRdo.Size = new System.Drawing.Size(71, 16);
            this.SingleExecRdo.TabIndex = 0;
            this.SingleExecRdo.TabStop = true;
            this.SingleExecRdo.Text = "单个执行";
            this.SingleExecRdo.UseVisualStyleBackColor = true;
            this.SingleExecRdo.CheckedChanged += new System.EventHandler(this.SingleExecRdo_CheckedChanged);
            // 
            // FeedBackTxt
            // 
            this.FeedBackTxt.Location = new System.Drawing.Point(582, 27);
            this.FeedBackTxt.Multiline = true;
            this.FeedBackTxt.Name = "FeedBackTxt";
            this.FeedBackTxt.ReadOnly = true;
            this.FeedBackTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FeedBackTxt.Size = new System.Drawing.Size(638, 358);
            this.FeedBackTxt.TabIndex = 17;
            this.FeedBackTxt.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(580, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "反馈:";
            // 
            // ScanBtn
            // 
            this.ScanBtn.Location = new System.Drawing.Point(440, 146);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(65, 25);
            this.ScanBtn.TabIndex = 12;
            this.ScanBtn.Text = "扫描";
            this.ScanBtn.UseVisualStyleBackColor = true;
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // ScanprogressBar
            // 
            this.ScanprogressBar.Location = new System.Drawing.Point(111, 148);
            this.ScanprogressBar.Maximum = 255;
            this.ScanprogressBar.Name = "ScanprogressBar";
            this.ScanprogressBar.Size = new System.Drawing.Size(323, 23);
            this.ScanprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ScanprogressBar.TabIndex = 13;
            // 
            // CancelScanBtn
            // 
            this.CancelScanBtn.Enabled = false;
            this.CancelScanBtn.Location = new System.Drawing.Point(511, 146);
            this.CancelScanBtn.Name = "CancelScanBtn";
            this.CancelScanBtn.Size = new System.Drawing.Size(65, 25);
            this.CancelScanBtn.TabIndex = 14;
            this.CancelScanBtn.Text = "取消扫描";
            this.CancelScanBtn.UseVisualStyleBackColor = true;
            this.CancelScanBtn.Click += new System.EventHandler(this.CancelScanBtn_Click);
            // 
            // ProcLbl
            // 
            this.ProcLbl.AutoSize = true;
            this.ProcLbl.Location = new System.Drawing.Point(12, 640);
            this.ProcLbl.Name = "ProcLbl";
            this.ProcLbl.Size = new System.Drawing.Size(0, 12);
            this.ProcLbl.TabIndex = 15;
            this.ProcLbl.Visible = false;
            // 
            // ClearResultBtn
            // 
            this.ClearResultBtn.Location = new System.Drawing.Point(1137, 391);
            this.ClearResultBtn.Name = "ClearResultBtn";
            this.ClearResultBtn.Size = new System.Drawing.Size(83, 23);
            this.ClearResultBtn.TabIndex = 20;
            this.ClearResultBtn.Text = "清空";
            this.ClearResultBtn.UseVisualStyleBackColor = true;
            this.ClearResultBtn.Click += new System.EventHandler(this.ClearResultBtn_Click);
            // 
            // CopyResultBtn
            // 
            this.CopyResultBtn.Location = new System.Drawing.Point(1048, 391);
            this.CopyResultBtn.Name = "CopyResultBtn";
            this.CopyResultBtn.Size = new System.Drawing.Size(83, 23);
            this.CopyResultBtn.TabIndex = 21;
            this.CopyResultBtn.Text = "复制结果";
            this.CopyResultBtn.UseVisualStyleBackColor = true;
            this.CopyResultBtn.Click += new System.EventHandler(this.CopyResultBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmdExecLbl);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.CmdExecStatusLstv);
            this.groupBox4.Location = new System.Drawing.Point(582, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(638, 208);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "命令执行状态";
            // 
            // CmdExecLbl
            // 
            this.CmdExecLbl.AutoSize = true;
            this.CmdExecLbl.Location = new System.Drawing.Point(57, 172);
            this.CmdExecLbl.Name = "CmdExecLbl";
            this.CmdExecLbl.Size = new System.Drawing.Size(47, 12);
            this.CmdExecLbl.TabIndex = 4;
            this.CmdExecLbl.Text = "就绪...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "当前:";
            // 
            // CmdExecStatusLstv
            // 
            this.CmdExecStatusLstv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.CmdExecStatusLstv.FullRowSelect = true;
            this.CmdExecStatusLstv.Location = new System.Drawing.Point(18, 31);
            this.CmdExecStatusLstv.Name = "CmdExecStatusLstv";
            this.CmdExecStatusLstv.Size = new System.Drawing.Size(596, 126);
            this.CmdExecStatusLstv.TabIndex = 0;
            this.CmdExecStatusLstv.UseCompatibleStateImageBehavior = false;
            this.CmdExecStatusLstv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "计算机名";
            this.columnHeader1.Width = 226;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP地址";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "执行情况";
            this.columnHeader3.Width = 160;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(394, 640);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(845, 12);
            this.label16.TabIndex = 14;
            this.label16.Text = "如果需要对某一特定计算机进行数据库操作，详情请在百度上搜索“SQL 查询分析器”，即你的计算机不需要安装SQL server也可以连接到远程计算机的数据库";
            // 
            // ExecuteCMDBGW
            // 
            this.ExecuteCMDBGW.WorkerSupportsCancellation = true;
            this.ExecuteCMDBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ExecuteCMDBGW_DoWork);
            this.ExecuteCMDBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ExecuteCMDBGW_RunWorkerCompleted);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(580, 396);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(305, 12);
            this.label18.TabIndex = 14;
            this.label18.Text = "中国开发者联盟软件技术股份有限公司（所有权利保留）";
            // 
            // NewVersionChk
            // 
            this.NewVersionChk.AutoSize = true;
            this.NewVersionChk.Checked = true;
            this.NewVersionChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewVersionChk.Location = new System.Drawing.Point(468, 391);
            this.NewVersionChk.Name = "NewVersionChk";
            this.NewVersionChk.Size = new System.Drawing.Size(108, 16);
            this.NewVersionChk.TabIndex = 23;
            this.NewVersionChk.Text = "版本是SQL 2008";
            this.NewVersionChk.UseVisualStyleBackColor = true;
            this.NewVersionChk.CheckedChanged += new System.EventHandler(this.NewVersionChk_CheckedChanged);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 659);
            this.Controls.Add(this.NewVersionChk);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CopyResultBtn);
            this.Controls.Add(this.ClearResultBtn);
            this.Controls.Add(this.ProcLbl);
            this.Controls.Add(this.CancelScanBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FeedBackTxt);
            this.Controls.Add(this.ScanprogressBar);
            this.Controls.Add(this.ScanBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OnlinePCLstv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL批量cmd命令执行, 适用操作系统（Win10以下版本），服务器 SQL server .此软件当前为测试状态，暂不外传";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortTxt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IPlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hostNamelbl;
        private System.Windows.Forms.ListView OnlinePCLstv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader IPAddrCol;
        private System.Windows.Forms.ColumnHeader ScannedNameCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox LoginNameTxt;
        private System.Windows.Forms.TextBox SelectedIPTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ScanBtn;
        private System.Windows.Forms.Button ExecCmdBtn;
        private System.Windows.Forms.RadioButton BatchExecRdo;
        private System.Windows.Forms.RadioButton SingleExecRdo;
        private System.Windows.Forms.TextBox FeedBackTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button RefreshBtn;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ProgressBar ScanprogressBar;
        private System.Windows.Forms.Button CancelScanBtn;
        private System.Windows.Forms.Label ProcLbl;
        private System.Windows.Forms.ComboBox DatabaseCombo;
        private System.Windows.Forms.ComboBox CmdCombo;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ClearResultBtn;
        private System.Windows.Forms.Button CopyResultBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CmdExecLbl;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView CmdExecStatusLstv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.ComponentModel.BackgroundWorker ExecuteCMDBGW;
        private System.Windows.Forms.NumericUpDown PortTxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox NewVersionChk;
    }
}

