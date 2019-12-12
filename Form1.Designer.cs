namespace PocExpRecoder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLiteConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CveDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cveNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VulnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VulnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VulnPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpOrPocAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionIllustrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Illustrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CveDataGridView)).BeginInit();
            this.DataGridcontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ConfigMenuItem
            // 
            this.ConfigMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SQLiteConfigToolStripMenuItem,
            this.UserConfigToolStripMenuItem});
            this.ConfigMenuItem.Name = "ConfigMenuItem";
            this.ConfigMenuItem.Size = new System.Drawing.Size(51, 24);
            this.ConfigMenuItem.Text = "设置";
            // 
            // SQLiteConfigToolStripMenuItem
            // 
            this.SQLiteConfigToolStripMenuItem.Name = "SQLiteConfigToolStripMenuItem";
            this.SQLiteConfigToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.SQLiteConfigToolStripMenuItem.Text = "SQLite文件配置";
            this.SQLiteConfigToolStripMenuItem.Click += new System.EventHandler(this.SQLiteConfigToolStripMenuItem_Click);
            // 
            // UserConfigToolStripMenuItem
            // 
            this.UserConfigToolStripMenuItem.Name = "UserConfigToolStripMenuItem";
            this.UserConfigToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.UserConfigToolStripMenuItem.Text = "用户配置";
            this.UserConfigToolStripMenuItem.Click += new System.EventHandler(this.UserConfigToolStripMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutStripMenuItem,
            this.VersionUpdateToolStripMenuItem,
            this.VersionToolStripMenuItem1,
            this.BugToolStripMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(73, 24);
            this.HelpMenuItem.Text = "帮助(H)";
            // 
            // AboutStripMenuItem
            // 
            this.AboutStripMenuItem.Name = "AboutStripMenuItem";
            this.AboutStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.AboutStripMenuItem.Text = "关于";
            this.AboutStripMenuItem.Click += new System.EventHandler(this.AboutStripMenuItem_Click);
            // 
            // VersionUpdateToolStripMenuItem
            // 
            this.VersionUpdateToolStripMenuItem.Name = "VersionUpdateToolStripMenuItem";
            this.VersionUpdateToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.VersionUpdateToolStripMenuItem.Text = "更新";
            this.VersionUpdateToolStripMenuItem.Click += new System.EventHandler(this.VersionUpdateToolStripMenuItem_Click);
            // 
            // VersionToolStripMenuItem1
            // 
            this.VersionToolStripMenuItem1.Name = "VersionToolStripMenuItem1";
            this.VersionToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.VersionToolStripMenuItem1.Text = "版本";
            this.VersionToolStripMenuItem1.Click += new System.EventHandler(this.VersionToolStripMenuItem1_Click);
            // 
            // BugToolStripMenuItem
            // 
            this.BugToolStripMenuItem.Name = "BugToolStripMenuItem";
            this.BugToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.BugToolStripMenuItem.Text = "意见反馈";
            this.BugToolStripMenuItem.Click += new System.EventHandler(this.BugToolStripMenuItem_Click);
            // 
            // CveDataGridView
            // 
            this.CveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cveNo,
            this.VulnName,
            this.VulnType,
            this.VulnPlatform,
            this.ExpOrPocAddr,
            this.VersionIllustrate,
            this.Illustrate,
            this.username,
            this.email});
            this.CveDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CveDataGridView.Location = new System.Drawing.Point(0, 28);
            this.CveDataGridView.Name = "CveDataGridView";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CveDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CveDataGridView.RowTemplate.Height = 27;
            this.CveDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CveDataGridView.Size = new System.Drawing.Size(1117, 621);
            this.CveDataGridView.TabIndex = 1;
            this.CveDataGridView.VirtualMode = true;
            this.CveDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CveDataGridView_CellContentClick);
            this.CveDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CveDataGridView_CellEndEdit);
            this.CveDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CveDataGridView_CellMouseDown);
            this.CveDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.CveDataGridView_DefaultValuesNeeded);
            this.CveDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CveDataGridView_RowsAdded);
            this.CveDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CveDataGridView_KeyDown);
            this.CveDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CveDataGridView_KeyPress);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 49.98067F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // cveNo
            // 
            this.cveNo.DataPropertyName = "cveNo";
            this.cveNo.FillWeight = 103.8487F;
            this.cveNo.HeaderText = "CVE编号";
            this.cveNo.Name = "cveNo";
            // 
            // VulnName
            // 
            this.VulnName.DataPropertyName = "VulnName";
            this.VulnName.FillWeight = 103.8487F;
            this.VulnName.HeaderText = "漏洞名称";
            this.VulnName.Name = "VulnName";
            // 
            // VulnType
            // 
            this.VulnType.DataPropertyName = "VulnType";
            this.VulnType.FillWeight = 103.8487F;
            this.VulnType.HeaderText = "漏洞类型";
            this.VulnType.Name = "VulnType";
            // 
            // VulnPlatform
            // 
            this.VulnPlatform.DataPropertyName = "VulnPlatform";
            this.VulnPlatform.FillWeight = 103.8487F;
            this.VulnPlatform.HeaderText = "复现平台";
            this.VulnPlatform.Name = "VulnPlatform";
            // 
            // ExpOrPocAddr
            // 
            this.ExpOrPocAddr.DataPropertyName = "ExpOrPocAddr";
            this.ExpOrPocAddr.FillWeight = 103.8487F;
            this.ExpOrPocAddr.HeaderText = "POC 链接";
            this.ExpOrPocAddr.Name = "ExpOrPocAddr";
            this.ExpOrPocAddr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VersionIllustrate
            // 
            this.VersionIllustrate.DataPropertyName = "VersionIllustrate";
            this.VersionIllustrate.FillWeight = 103.8487F;
            this.VersionIllustrate.HeaderText = "影响产品版本";
            this.VersionIllustrate.Name = "VersionIllustrate";
            // 
            // Illustrate
            // 
            this.Illustrate.DataPropertyName = "Illustrate";
            this.Illustrate.FillWeight = 103.8487F;
            this.Illustrate.HeaderText = "说明";
            this.Illustrate.Name = "Illustrate";
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.FillWeight = 103.8487F;
            this.username.HeaderText = "信息整理者";
            this.username.Name = "username";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 103.8487F;
            this.email.HeaderText = "邮箱";
            this.email.Name = "email";
            // 
            // DataGridcontextMenuStrip
            // 
            this.DataGridcontextMenuStrip.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridcontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DataGridcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.DataGridcontextMenuStrip.Name = "DataGridcontextMenuStrip";
            this.DataGridcontextMenuStrip.Size = new System.Drawing.Size(185, 48);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.删除ToolStripMenuItem.Text = "删除(Delete)";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.刷新ToolStripMenuItem.Text = "刷新(F5)";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 649);
            this.Controls.Add(this.CveDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CVE 信息登记工具 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CveDataGridView)).EndInit();
            this.DataGridcontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ConfigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLiteConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersionUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BugToolStripMenuItem;
        private System.Windows.Forms.DataGridView CveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VulnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VulnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VulnPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpOrPocAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionIllustrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Illustrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.ContextMenuStrip DataGridcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
    }
}

