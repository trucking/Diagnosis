namespace Diagnosis_System
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.就诊人员档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建人员档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.就诊记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.药品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.就诊人员档案ToolStripMenuItem,
            this.就诊记录ToolStripMenuItem,
            this.药品管理ToolStripMenuItem,
            this.系统用户管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 就诊人员档案ToolStripMenuItem
            // 
            this.就诊人员档案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建人员档案ToolStripMenuItem,
            this.查找档案ToolStripMenuItem});
            this.就诊人员档案ToolStripMenuItem.Name = "就诊人员档案ToolStripMenuItem";
            this.就诊人员档案ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.就诊人员档案ToolStripMenuItem.Text = "就诊人员档案";
            // 
            // 新建人员档案ToolStripMenuItem
            // 
            this.新建人员档案ToolStripMenuItem.Name = "新建人员档案ToolStripMenuItem";
            this.新建人员档案ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建人员档案ToolStripMenuItem.Text = "新建人员档案";
            this.新建人员档案ToolStripMenuItem.Click += new System.EventHandler(this.新建人员档案ToolStripMenuItem_Click);
            // 
            // 查找档案ToolStripMenuItem
            // 
            this.查找档案ToolStripMenuItem.Name = "查找档案ToolStripMenuItem";
            this.查找档案ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查找档案ToolStripMenuItem.Text = "查找档案";
            // 
            // 就诊记录ToolStripMenuItem
            // 
            this.就诊记录ToolStripMenuItem.Name = "就诊记录ToolStripMenuItem";
            this.就诊记录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.就诊记录ToolStripMenuItem.Text = "就诊记录";
            // 
            // 药品管理ToolStripMenuItem
            // 
            this.药品管理ToolStripMenuItem.Name = "药品管理ToolStripMenuItem";
            this.药品管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.药品管理ToolStripMenuItem.Text = "药品管理";
            // 
            // 系统用户管理ToolStripMenuItem
            // 
            this.系统用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.修改用户ToolStripMenuItem,
            this.系统日志ToolStripMenuItem});
            this.系统用户管理ToolStripMenuItem.Name = "系统用户管理ToolStripMenuItem";
            this.系统用户管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.系统用户管理ToolStripMenuItem.Text = "系统用户管理";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 修改用户ToolStripMenuItem
            // 
            this.修改用户ToolStripMenuItem.Name = "修改用户ToolStripMenuItem";
            this.修改用户ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改用户ToolStripMenuItem.Text = "用户管理";
            this.修改用户ToolStripMenuItem.Click += new System.EventHandler(this.修改用户ToolStripMenuItem_Click);
            // 
            // 系统日志ToolStripMenuItem
            // 
            this.系统日志ToolStripMenuItem.Name = "系统日志ToolStripMenuItem";
            this.系统日志ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.系统日志ToolStripMenuItem.Text = "系统日志";
            this.系统日志ToolStripMenuItem.Click += new System.EventHandler(this.系统日志ToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "逯大夫诊所诊疗系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 就诊人员档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建人员档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 就诊记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 药品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统日志ToolStripMenuItem;
    }
}