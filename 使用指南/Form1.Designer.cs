namespace 使用指南
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.procportBtn = new System.Windows.Forms.Button();
            this.shareResBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "网络连接";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(559, 91);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "状态大致如下";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(573, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "  因此请保证网络一直是畅通的状态，如果执行命令的过程中网线意外断开，则远程命令执行失败";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "  如果断开就无法执行命令了，可能会有以下的对话框出现";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "  使用本程序需要 .net framework 4.0 或更高版本，操作系统建议在Win10以下。除此之外还要有较好的网络环境，至少您的计算机要连接到局域网（即" +
    "您的设备至少网线是连接状态）";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "失败原因";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "源代码并不完美，肯定存在着缺陷，后续有可能公开";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(405, 404);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(413, 192);
            this.label5.TabIndex = 0;
            this.label5.Text = "1.网络被断开\r\n\r\n\r\n2.目标计算机的MSSQLSERVER服务未开启，或者sqlserver的版本问题\r\n\r\n\r\n3.您的登录名，密码，端口，数据库名可能存" +
    "在一个或多个错误，请仔细检查\r\n\r\n\r\n4.防火墙意外拦截\r\n\r\n\r\n5.扫描到的可能是网关地址，无法执行命令\r\n\r\n\r\n6.尝试关闭本机的杀毒软件";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox5);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.procportBtn);
            this.tabPage3.Controls.Add(this.shareResBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "常用小功能";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "小小常用功能...:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(378, 474);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Unknown Function(Standing by)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // procportBtn
            // 
            this.procportBtn.Location = new System.Drawing.Point(396, 57);
            this.procportBtn.Name = "procportBtn";
            this.procportBtn.Size = new System.Drawing.Size(250, 23);
            this.procportBtn.TabIndex = 1;
            this.procportBtn.Text = "进程端口查看(&P)...";
            this.procportBtn.UseVisualStyleBackColor = true;
            // 
            // shareResBtn
            // 
            this.shareResBtn.Location = new System.Drawing.Point(396, 28);
            this.shareResBtn.Name = "shareResBtn";
            this.shareResBtn.Size = new System.Drawing.Size(250, 23);
            this.shareResBtn.TabIndex = 0;
            this.shareResBtn.Text = "共享资源管理(&S)...";
            this.shareResBtn.UseVisualStyleBackColor = true;
            this.shareResBtn.Click += new System.EventHandler(this.shareResBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "中国开发者联盟软件技术股份有限公司(版权所有)";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(609, 515);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "退出";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(380, 116);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(288, 359);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 543);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL 远程cmd命令执行程序 使用指南 后续可能还有更多功能，敬请期待！";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button procportBtn;
        private System.Windows.Forms.Button shareResBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

