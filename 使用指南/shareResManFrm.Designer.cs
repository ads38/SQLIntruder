namespace 使用指南
{
    partial class shareResManFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shareResManFrm));
            this.resultLstv = new System.Windows.Forms.ListView();
            this.shareNameHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderPathHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.captionHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultLstv
            // 
            this.resultLstv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.shareNameHead,
            this.folderPathHead,
            this.descripHead,
            this.captionHead,
            this.statusHead});
            this.resultLstv.FullRowSelect = true;
            this.resultLstv.GridLines = true;
            this.resultLstv.Location = new System.Drawing.Point(12, 33);
            this.resultLstv.Name = "resultLstv";
            this.resultLstv.Size = new System.Drawing.Size(677, 284);
            this.resultLstv.TabIndex = 1;
            this.resultLstv.UseCompatibleStateImageBehavior = false;
            this.resultLstv.View = System.Windows.Forms.View.Details;
            // 
            // shareNameHead
            // 
            this.shareNameHead.Text = "共享名";
            this.shareNameHead.Width = 88;
            // 
            // folderPathHead
            // 
            this.folderPathHead.Text = "文件夹路径";
            this.folderPathHead.Width = 109;
            // 
            // descripHead
            // 
            this.descripHead.Text = "描述";
            this.descripHead.Width = 119;
            // 
            // captionHead
            // 
            this.captionHead.Text = "字段";
            this.captionHead.Width = 125;
            // 
            // statusHead
            // 
            this.statusHead.Text = "状态";
            this.statusHead.Width = 83;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(614, 323);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "刷新";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "在下方查看已共享资源：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 265);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "远程执行";
            // 
            // shareResManFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.resultLstv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "shareResManFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "小型共享资源管理器";
            this.Load += new System.EventHandler(this.shareResManFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView resultLstv;
        private System.Windows.Forms.ColumnHeader shareNameHead;
        private System.Windows.Forms.ColumnHeader folderPathHead;
        private System.Windows.Forms.ColumnHeader descripHead;
        private System.Windows.Forms.ColumnHeader captionHead;
        private System.Windows.Forms.ColumnHeader statusHead;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}