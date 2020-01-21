namespace FlashRecovery
{
    partial class FlashRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashRecovery));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.operateMenuStrip = new System.Windows.Forms.MenuStrip();
            this.operateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBtn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundImagePanel = new UCControl.Process.PanelExt();
            this.contentLabel = new System.Windows.Forms.Label();
            this.headlineLabel = new System.Windows.Forms.Label();
            this.centerOpenBtn = new System.Windows.Forms.Button();
            this.centerNewBtn = new System.Windows.Forms.Button();
            this.exeTabControl = new System.Windows.Forms.TabControl();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.connStatusImage = new System.Windows.Forms.ToolStripLabel();
            this.connStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.versionNo = new System.Windows.Forms.ToolStripLabel();
            this.versionLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deviceIdLabel = new System.Windows.Forms.ToolStripLabel();
            this.deviceIdTextLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.configToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newTask = new System.Windows.Forms.ToolStripButton();
            this.openTask = new System.Windows.Forms.ToolStripButton();
            this.titlePanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.operateMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.backgroundImagePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.topToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(167)))));
            this.titlePanel.Controls.Add(this.minBtn);
            this.titlePanel.Controls.Add(this.maxBtn);
            this.titlePanel.Controls.Add(this.toolsPanel);
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1214, 30);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDoubleClick);
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // minBtn
            // 
            this.minBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minBtn.BackgroundImage")));
            this.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Location = new System.Drawing.Point(1124, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(30, 30);
            this.minBtn.TabIndex = 4;
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maxBtn.BackgroundImage")));
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxBtn.FlatAppearance.BorderSize = 0;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Location = new System.Drawing.Point(1154, 0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(30, 30);
            this.maxBtn.TabIndex = 3;
            this.maxBtn.UseVisualStyleBackColor = true;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(167)))));
            this.toolsPanel.Controls.Add(this.operateMenuStrip);
            this.toolsPanel.Location = new System.Drawing.Point(400, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(370, 30);
            this.toolsPanel.TabIndex = 2;
            // 
            // operateMenuStrip
            // 
            this.operateMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(167)))));
            this.operateMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operateMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operateToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.operateMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.operateMenuStrip.Name = "operateMenuStrip";
            this.operateMenuStrip.Size = new System.Drawing.Size(370, 30);
            this.operateMenuStrip.TabIndex = 0;
            this.operateMenuStrip.Text = "menuStrip1";
            // 
            // operateToolStripMenuItem
            // 
            this.operateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBtn,
            this.openBtn,
            this.deleteBtn,
            this.closeBtn2});
            this.operateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.operateToolStripMenuItem.Image = global::FlashRecovery.Properties.Resources.文件;
            this.operateToolStripMenuItem.Name = "operateToolStripMenuItem";
            this.operateToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.operateToolStripMenuItem.Text = "文件";
            // 
            // newBtn
            // 
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(152, 22);
            this.newBtn.Text = "新建";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(152, 22);
            this.openBtn.Text = "打开";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(152, 22);
            this.deleteBtn.Text = "关闭";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // closeBtn2
            // 
            this.closeBtn2.Name = "closeBtn2";
            this.closeBtn2.Size = new System.Drawing.Size(124, 22);
            this.closeBtn2.Text = "退出";
            this.closeBtn2.Click += new System.EventHandler(this.closeBtn2_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorBtn});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Image = global::FlashRecovery.Properties.Resources.工具;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.toolsToolStripMenuItem.Text = "工具";
            // 
            // calculatorBtn
            // 
            this.calculatorBtn.Name = "calculatorBtn";
            this.calculatorBtn.Size = new System.Drawing.Size(112, 22);
            this.calculatorBtn.Text = "计算器";
            this.calculatorBtn.Click += new System.EventHandler(this.calculatorBtn_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.windowToolStripMenuItem.Image = global::FlashRecovery.Properties.Resources.窗口;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.windowToolStripMenuItem.Text = "窗口";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Image = global::FlashRecovery.Properties.Resources.帮助;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::FlashRecovery.Properties.Resources.关闭;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(1184, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "XXX系统";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDoubleClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.backgroundImagePanel);
            this.panel1.Controls.Add(this.exeTabControl);
            this.panel1.Controls.Add(this.bottomPanel);
            this.panel1.Controls.Add(this.topToolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 818);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // backgroundImagePanel
            // 
            this.backgroundImagePanel.BackColor = System.Drawing.Color.White;
            this.backgroundImagePanel.BackgroundImage = global::FlashRecovery.Properties.Resources.bg_02;
            this.backgroundImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundImagePanel.ConerRadius = 24;
            this.backgroundImagePanel.Controls.Add(this.contentLabel);
            this.backgroundImagePanel.Controls.Add(this.headlineLabel);
            this.backgroundImagePanel.Controls.Add(this.centerOpenBtn);
            this.backgroundImagePanel.Controls.Add(this.centerNewBtn);
            this.backgroundImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundImagePanel.FillColor = System.Drawing.Color.Transparent;
            this.backgroundImagePanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backgroundImagePanel.IsRadius = false;
            this.backgroundImagePanel.IsShowRect = false;
            this.backgroundImagePanel.Location = new System.Drawing.Point(0, 25);
            this.backgroundImagePanel.Name = "backgroundImagePanel";
            this.backgroundImagePanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.backgroundImagePanel.RectWidth = 1;
            this.backgroundImagePanel.Size = new System.Drawing.Size(1212, 763);
            this.backgroundImagePanel.TabIndex = 0;
            this.backgroundImagePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.backgroundImagePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.backgroundImagePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // contentLabel
            // 
            this.contentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contentLabel.BackColor = System.Drawing.Color.Transparent;
            this.contentLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.contentLabel.Location = new System.Drawing.Point(534, 475);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(440, 67);
            this.contentLabel.TabIndex = 0;
            this.contentLabel.Text = "产品功能简介....";
            // 
            // headlineLabel
            // 
            this.headlineLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.headlineLabel.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(167)))));
            this.headlineLabel.Location = new System.Drawing.Point(531, 154);
            this.headlineLabel.Name = "headlineLabel";
            this.headlineLabel.Size = new System.Drawing.Size(150, 42);
            this.headlineLabel.TabIndex = 0;
            this.headlineLabel.Text = "XXX系统";
            // 
            // centerOpenBtn
            // 
            this.centerOpenBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.centerOpenBtn.BackColor = System.Drawing.Color.Transparent;
            this.centerOpenBtn.BackgroundImage = global::FlashRecovery.Properties.Resources.打开文件;
            this.centerOpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.centerOpenBtn.FlatAppearance.BorderSize = 0;
            this.centerOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centerOpenBtn.ForeColor = System.Drawing.Color.Transparent;
            this.centerOpenBtn.Location = new System.Drawing.Point(640, 220);
            this.centerOpenBtn.Name = "centerOpenBtn";
            this.centerOpenBtn.Size = new System.Drawing.Size(190, 220);
            this.centerOpenBtn.TabIndex = 0;
            this.centerOpenBtn.UseVisualStyleBackColor = false;
            this.centerOpenBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // centerNewBtn
            // 
            this.centerNewBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.centerNewBtn.BackColor = System.Drawing.Color.Transparent;
            this.centerNewBtn.BackgroundImage = global::FlashRecovery.Properties.Resources.新建任务;
            this.centerNewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.centerNewBtn.FlatAppearance.BorderSize = 0;
            this.centerNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centerNewBtn.ForeColor = System.Drawing.Color.Transparent;
            this.centerNewBtn.Location = new System.Drawing.Point(360, 220);
            this.centerNewBtn.Name = "centerNewBtn";
            this.centerNewBtn.Size = new System.Drawing.Size(190, 220);
            this.centerNewBtn.TabIndex = 1;
            this.centerNewBtn.UseVisualStyleBackColor = false;
            this.centerNewBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // exeTabControl
            // 
            this.exeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exeTabControl.Location = new System.Drawing.Point(0, 25);
            this.exeTabControl.Name = "exeTabControl";
            this.exeTabControl.SelectedIndex = 0;
            this.exeTabControl.Size = new System.Drawing.Size(1212, 763);
            this.exeTabControl.TabIndex = 3;
            this.exeTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.copyRightLabel);
            this.bottomPanel.Controls.Add(this.bottomToolStrip);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 788);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1212, 28);
            this.bottomPanel.TabIndex = 2;
            this.bottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottomPanel_MouseDown);
            this.bottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bottomPanel_MouseMove);
            this.bottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bottomPanel_MouseUp);
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.copyRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.copyRightLabel.Location = new System.Drawing.Point(540, 8);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(102, 12);
            this.copyRightLabel.TabIndex = 1;
            this.copyRightLabel.Text = "XXX公司 版权所有";
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connStatusImage,
            this.connStatus,
            this.toolStripSeparator1,
            this.versionNo,
            this.versionLabel,
            this.toolStripSeparator2,
            this.deviceIdLabel,
            this.deviceIdTextLabel,
            this.toolStripSeparator4});
            this.bottomToolStrip.Location = new System.Drawing.Point(0, 0);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bottomToolStrip.Size = new System.Drawing.Size(1212, 25);
            this.bottomToolStrip.TabIndex = 0;
            this.bottomToolStrip.Text = "toolStrip1";
            // 
            // connStatusImage
            // 
            this.connStatusImage.Image = global::FlashRecovery.Properties.Resources.未连接设备;
            this.connStatusImage.Name = "connStatusImage";
            this.connStatusImage.Size = new System.Drawing.Size(16, 22);
            // 
            // connStatus
            // 
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(68, 22);
            this.connStatus.Text = "未连接设备";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // versionNo
            // 
            this.versionNo.Name = "versionNo";
            this.versionNo.Size = new System.Drawing.Size(45, 22);
            this.versionNo.Text = "1.0.0.0";
            // 
            // versionLabel
            // 
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(36, 22);
            this.versionLabel.Text = "版本 ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // deviceIdLabel
            // 
            this.deviceIdLabel.Name = "deviceIdLabel";
            this.deviceIdLabel.Size = new System.Drawing.Size(64, 22);
            this.deviceIdLabel.Text = "00000000";
            // 
            // deviceIdTextLabel
            // 
            this.deviceIdTextLabel.Name = "deviceIdTextLabel";
            this.deviceIdTextLabel.Size = new System.Drawing.Size(45, 22);
            this.deviceIdTextLabel.Text = "设备ID";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // topToolStrip
            // 
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripButton,
            this.toolStripSeparator3,
            this.newTask,
            this.openTask});
            this.topToolStrip.Location = new System.Drawing.Point(0, 0);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(1212, 25);
            this.topToolStrip.TabIndex = 1;
            this.topToolStrip.Text = "toolStrip1";
            // 
            // configToolStripButton
            // 
            this.configToolStripButton.Image = global::FlashRecovery.Properties.Resources.配置;
            this.configToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configToolStripButton.Name = "configToolStripButton";
            this.configToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.configToolStripButton.Text = "配置";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // newTask
            // 
            this.newTask.Image = global::FlashRecovery.Properties.Resources.新建;
            this.newTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTask.Name = "newTask";
            this.newTask.Size = new System.Drawing.Size(52, 22);
            this.newTask.Text = "新建";
            this.newTask.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // openTask
            // 
            this.openTask.Image = global::FlashRecovery.Properties.Resources.打开;
            this.openTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTask.Name = "openTask";
            this.openTask.Size = new System.Drawing.Size(52, 22);
            this.openTask.Text = "打开";
            this.openTask.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // FlashRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 848);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.operateMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlashRecovery";
            this.Text = "RH-6803 Flash存储介质数据恢复系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FlashRecovery_FormClosed);
            this.Load += new System.EventHandler(this.FlashRecovery_Load);
            this.Resize += new System.EventHandler(this.FlashRecovery_Resize);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.operateMenuStrip.ResumeLayout(false);
            this.operateMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.backgroundImagePanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.MenuStrip operateMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem operateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBtn;
        private System.Windows.Forms.ToolStripMenuItem openBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteBtn;
        private System.Windows.Forms.ToolStripMenuItem closeBtn2;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorBtn;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripButton newTask;
        private System.Windows.Forms.ToolStripButton openTask;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TabControl exeTabControl;
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.ToolStripLabel connStatusImage;
        private System.Windows.Forms.ToolStripLabel connStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel versionNo;
        private System.Windows.Forms.ToolStripLabel versionLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button centerNewBtn;
        private System.Windows.Forms.Button centerOpenBtn;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton configToolStripButton;
        private System.Windows.Forms.Label headlineLabel;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.ToolStripLabel deviceIdLabel;
        private System.Windows.Forms.ToolStripLabel deviceIdTextLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label copyRightLabel;
        private UCControl.Process.PanelExt backgroundImagePanel;
    }
}

