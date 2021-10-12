namespace GenshinAccount
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lvwAcct = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveCurr = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkAutoStartYS = new System.Windows.Forms.CheckBox();
            this.chkSkipTips = new System.Windows.Forms.CheckBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPathTag = new System.Windows.Forms.Label();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.chkMinimizeToNotifyArea = new System.Windows.Forms.CheckBox();
            this.txtStartParam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picHelpSatrtParam = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelpSatrtParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwAcct
            // 
            resources.ApplyResources(this.lvwAcct, "lvwAcct");
            this.lvwAcct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.lvwAcct.GridLines = true;
            this.lvwAcct.HideSelection = false;
            this.lvwAcct.MultiSelect = false;
            this.lvwAcct.Name = "lvwAcct";
            this.lvwAcct.UseCompatibleStateImageBehavior = false;
            this.lvwAcct.View = System.Windows.Forms.View.List;
            this.lvwAcct.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwAcct_MouseDoubleClick);
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            // 
            // btnSaveCurr
            // 
            resources.ApplyResources(this.btnSaveCurr, "btnSaveCurr");
            this.btnSaveCurr.Name = "btnSaveCurr";
            this.btnSaveCurr.UseVisualStyleBackColor = true;
            this.btnSaveCurr.Click += new System.EventHandler(this.btnSaveCurr_Click);
            // 
            // btnSwitch
            // 
            resources.ApplyResources(this.btnSwitch, "btnSwitch");
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkAutoStartYS
            // 
            resources.ApplyResources(this.chkAutoStartYS, "chkAutoStartYS");
            this.chkAutoStartYS.Name = "chkAutoStartYS";
            this.chkAutoStartYS.UseVisualStyleBackColor = true;
            // 
            // chkSkipTips
            // 
            resources.ApplyResources(this.chkSkipTips, "chkSkipTips");
            this.chkSkipTips.Name = "chkSkipTips";
            this.chkSkipTips.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            resources.ApplyResources(this.txtPath, "txtPath");
            this.txtPath.Name = "txtPath";
            // 
            // lblPathTag
            // 
            resources.ApplyResources(this.lblPathTag, "lblPathTag");
            this.lblPathTag.Name = "lblPathTag";
            // 
            // btnChoosePath
            // 
            resources.ApplyResources(this.btnChoosePath, "btnChoosePath");
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = global::GenshinAccount.Properties.Resources.hutao;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            resources.ApplyResources(this.显示主界面ToolStripMenuItem, "显示主界面ToolStripMenuItem");
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // chkMinimizeToNotifyArea
            // 
            resources.ApplyResources(this.chkMinimizeToNotifyArea, "chkMinimizeToNotifyArea");
            this.chkMinimizeToNotifyArea.Name = "chkMinimizeToNotifyArea";
            this.chkMinimizeToNotifyArea.UseVisualStyleBackColor = true;
            // 
            // txtStartParam
            // 
            resources.ApplyResources(this.txtStartParam, "txtStartParam");
            this.txtStartParam.Name = "txtStartParam";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // picHelpSatrtParam
            // 
            this.picHelpSatrtParam.Image = global::GenshinAccount.Properties.Resources.attention;
            resources.ApplyResources(this.picHelpSatrtParam, "picHelpSatrtParam");
            this.picHelpSatrtParam.Name = "picHelpSatrtParam";
            this.picHelpSatrtParam.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GenshinAccount.Properties.Resources.attention;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picHelpSatrtParam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStartParam);
            this.Controls.Add(this.chkMinimizeToNotifyArea);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPathTag);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.chkSkipTips);
            this.Controls.Add(this.chkAutoStartYS);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnSaveCurr);
            this.Controls.Add(this.lvwAcct);
            this.Icon = global::GenshinAccount.Properties.Resources.hutao;
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHelpSatrtParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwAcct;
        private System.Windows.Forms.Button btnSaveCurr;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chkAutoStartYS;
        private System.Windows.Forms.CheckBox chkSkipTips;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPathTag;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox chkMinimizeToNotifyArea;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtStartParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picHelpSatrtParam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

