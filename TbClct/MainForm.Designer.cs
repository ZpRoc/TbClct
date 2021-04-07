namespace TbClct
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorFile1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMainTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMainConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMainActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpace1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.buttonGetFN = new System.Windows.Forms.Button();
            this.groupBoxFN = new System.Windows.Forms.GroupBox();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBoxFN.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMainFile,
            this.toolStripMenuItemMainTools,
            this.toolStripMenuItemMainConfig,
            this.toolStripMenuItemMainActivate,
            this.toolStripMenuItemMainHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(384, 29);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "菜单栏";
            // 
            // toolStripMenuItemMainFile
            // 
            this.toolStripMenuItemMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparatorFile1,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemMainFile.Name = "toolStripMenuItemMainFile";
            this.toolStripMenuItemMainFile.Size = new System.Drawing.Size(58, 25);
            this.toolStripMenuItemMainFile.Text = "文件";
            // 
            // toolStripSeparatorFile1
            // 
            this.toolStripSeparatorFile1.Name = "toolStripSeparatorFile1";
            this.toolStripSeparatorFile1.Size = new System.Drawing.Size(113, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Image = global::TbClct.Properties.Resources.exit;
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItemExit.Text = "退出";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemMainTools
            // 
            this.toolStripMenuItemMainTools.Name = "toolStripMenuItemMainTools";
            this.toolStripMenuItemMainTools.Size = new System.Drawing.Size(58, 25);
            this.toolStripMenuItemMainTools.Text = "工具";
            // 
            // toolStripMenuItemMainConfig
            // 
            this.toolStripMenuItemMainConfig.Name = "toolStripMenuItemMainConfig";
            this.toolStripMenuItemMainConfig.Size = new System.Drawing.Size(58, 25);
            this.toolStripMenuItemMainConfig.Text = "设置";
            // 
            // toolStripMenuItemMainActivate
            // 
            this.toolStripMenuItemMainActivate.Name = "toolStripMenuItemMainActivate";
            this.toolStripMenuItemMainActivate.Size = new System.Drawing.Size(58, 25);
            this.toolStripMenuItemMainActivate.Text = "激活";
            // 
            // toolStripMenuItemMainHelp
            // 
            this.toolStripMenuItemMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemMainHelp.Name = "toolStripMenuItemMainHelp";
            this.toolStripMenuItemMainHelp.Size = new System.Drawing.Size(58, 25);
            this.toolStripMenuItemMainHelp.Text = "帮助";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Image = global::TbClct.Properties.Resources.help;
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemHelp.Text = "查看帮助";
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.toolStripMenuItemHelp_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Image = global::TbClct.Properties.Resources.about;
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemAbout.Text = "关于";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime,
            this.toolStripStatusLabelSpace1,
            this.toolStripProgressBarMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 537);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(384, 24);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "工具栏";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(161, 19);
            this.toolStripStatusLabelTime.Tag = "yyyy-MM-dd hh:mm:ss";
            this.toolStripStatusLabelTime.Text = "yyyy-MM-dd hh:mm:ss";
            // 
            // toolStripStatusLabelSpace1
            // 
            this.toolStripStatusLabelSpace1.Name = "toolStripStatusLabelSpace1";
            this.toolStripStatusLabelSpace1.Size = new System.Drawing.Size(73, 19);
            this.toolStripStatusLabelSpace1.Text = "        ";
            // 
            // toolStripProgressBarMain
            // 
            this.toolStripProgressBarMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBarMain.Name = "toolStripProgressBarMain";
            this.toolStripProgressBarMain.Size = new System.Drawing.Size(128, 18);
            this.toolStripProgressBarMain.Step = 1;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // buttonGetFN
            // 
            this.buttonGetFN.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.buttonGetFN.Location = new System.Drawing.Point(15, 30);
            this.buttonGetFN.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGetFN.Name = "buttonGetFN";
            this.buttonGetFN.Size = new System.Drawing.Size(128, 30);
            this.buttonGetFN.TabIndex = 2;
            this.buttonGetFN.Text = "获取文件名";
            this.buttonGetFN.UseVisualStyleBackColor = true;
            this.buttonGetFN.Click += new System.EventHandler(this.buttonGetFN_Click);
            // 
            // groupBoxFN
            // 
            this.groupBoxFN.Controls.Add(this.buttonGetFN);
            this.groupBoxFN.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxFN.Location = new System.Drawing.Point(12, 36);
            this.groupBoxFN.Name = "groupBoxFN";
            this.groupBoxFN.Size = new System.Drawing.Size(360, 212);
            this.groupBoxFN.TabIndex = 4;
            this.groupBoxFN.TabStop = false;
            this.groupBoxFN.Text = "文件操作";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.groupBoxFN);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Toolbox Collection";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxFN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMainFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMainTools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMainConfig;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMainActivate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMainHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpace1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonGetFN;
        private System.Windows.Forms.GroupBox groupBoxFN;
    }
}