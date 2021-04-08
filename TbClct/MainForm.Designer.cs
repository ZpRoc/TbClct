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
            this.toolStripMenuItemFileOps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGetFN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDataOps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPlotFit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImgOps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImgBasis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOther = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSpmBruker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMainConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSysCfg = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBoxFileOps = new System.Windows.Forms.GroupBox();
            this.groupBoxDataOps = new System.Windows.Forms.GroupBox();
            this.buttonPlotFit = new System.Windows.Forms.Button();
            this.buttonSpmBruker = new System.Windows.Forms.Button();
            this.groupBoxImgOps = new System.Windows.Forms.GroupBox();
            this.buttonImgBasis = new System.Windows.Forms.Button();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBoxFileOps.SuspendLayout();
            this.groupBoxDataOps.SuspendLayout();
            this.groupBoxImgOps.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
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
            this.menuStripMain.Size = new System.Drawing.Size(359, 29);
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
            this.toolStripMenuItemMainTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileOps,
            this.toolStripMenuItemDataOps,
            this.toolStripMenuItemImgOps,
            this.toolStripMenuItemOther});
            this.toolStripMenuItemMainTools.Name = "toolStripMenuItemMainTools";
            this.toolStripMenuItemMainTools.Size = new System.Drawing.Size(58, 25);
            this.toolStripMenuItemMainTools.Text = "工具";
            // 
            // toolStripMenuItemFileOps
            // 
            this.toolStripMenuItemFileOps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGetFN});
            this.toolStripMenuItemFileOps.Image = global::TbClct.Properties.Resources.file;
            this.toolStripMenuItemFileOps.Name = "toolStripMenuItemFileOps";
            this.toolStripMenuItemFileOps.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemFileOps.Text = "文件操作";
            // 
            // toolStripMenuItemGetFN
            // 
            this.toolStripMenuItemGetFN.Image = global::TbClct.Properties.Resources.filename;
            this.toolStripMenuItemGetFN.Name = "toolStripMenuItemGetFN";
            this.toolStripMenuItemGetFN.Size = new System.Drawing.Size(170, 26);
            this.toolStripMenuItemGetFN.Text = "获取文件名";
            this.toolStripMenuItemGetFN.Click += new System.EventHandler(this.toolStripMenuItemGetFN_Click);
            // 
            // toolStripMenuItemDataOps
            // 
            this.toolStripMenuItemDataOps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPlotFit});
            this.toolStripMenuItemDataOps.Image = global::TbClct.Properties.Resources.data;
            this.toolStripMenuItemDataOps.Name = "toolStripMenuItemDataOps";
            this.toolStripMenuItemDataOps.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemDataOps.Text = "数据操作";
            // 
            // toolStripMenuItemPlotFit
            // 
            this.toolStripMenuItemPlotFit.Image = global::TbClct.Properties.Resources.plot;
            this.toolStripMenuItemPlotFit.Name = "toolStripMenuItemPlotFit";
            this.toolStripMenuItemPlotFit.Size = new System.Drawing.Size(188, 26);
            this.toolStripMenuItemPlotFit.Text = "散点绘制拟合";
            this.toolStripMenuItemPlotFit.Click += new System.EventHandler(this.toolStripMenuItemPlotFit_Click);
            // 
            // toolStripMenuItemImgOps
            // 
            this.toolStripMenuItemImgOps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemImgBasis});
            this.toolStripMenuItemImgOps.Image = global::TbClct.Properties.Resources.image;
            this.toolStripMenuItemImgOps.Name = "toolStripMenuItemImgOps";
            this.toolStripMenuItemImgOps.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemImgOps.Text = "图像处理";
            // 
            // toolStripMenuItemImgBasis
            // 
            this.toolStripMenuItemImgBasis.Name = "toolStripMenuItemImgBasis";
            this.toolStripMenuItemImgBasis.Size = new System.Drawing.Size(188, 26);
            this.toolStripMenuItemImgBasis.Text = "图像基础处理";
            this.toolStripMenuItemImgBasis.Click += new System.EventHandler(this.toolStripMenuItemImgBasis_Click);
            // 
            // toolStripMenuItemOther
            // 
            this.toolStripMenuItemOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSpmBruker});
            this.toolStripMenuItemOther.Name = "toolStripMenuItemOther";
            this.toolStripMenuItemOther.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemOther.Text = "其他";
            // 
            // toolStripMenuItemSpmBruker
            // 
            this.toolStripMenuItemSpmBruker.Name = "toolStripMenuItemSpmBruker";
            this.toolStripMenuItemSpmBruker.Size = new System.Drawing.Size(188, 26);
            this.toolStripMenuItemSpmBruker.Text = "SPM (Bruker)";
            this.toolStripMenuItemSpmBruker.Click += new System.EventHandler(this.toolStripMenuItemSpmBruker_Click);
            // 
            // toolStripMenuItemMainConfig
            // 
            this.toolStripMenuItemMainConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSysCfg});
            this.toolStripMenuItemMainConfig.Name = "toolStripMenuItemMainConfig";
            this.toolStripMenuItemMainConfig.Size = new System.Drawing.Size(58, 25);
            this.toolStripMenuItemMainConfig.Text = "设置";
            // 
            // toolStripMenuItemSysCfg
            // 
            this.toolStripMenuItemSysCfg.Image = global::TbClct.Properties.Resources.config;
            this.toolStripMenuItemSysCfg.Name = "toolStripMenuItemSysCfg";
            this.toolStripMenuItemSysCfg.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemSysCfg.Text = "系统设置";
            this.toolStripMenuItemSysCfg.Click += new System.EventHandler(this.toolStripMenuItemSysCfg_Click);
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
            this.statusStripMain.Location = new System.Drawing.Point(0, 497);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(359, 24);
            this.statusStripMain.TabIndex = 9;
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
            this.toolStripStatusLabelSpace1.Size = new System.Drawing.Size(41, 19);
            this.toolStripStatusLabelSpace1.Text = "    ";
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
            this.buttonGetFN.Location = new System.Drawing.Point(12, 29);
            this.buttonGetFN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonGetFN.Name = "buttonGetFN";
            this.buttonGetFN.Size = new System.Drawing.Size(150, 30);
            this.buttonGetFN.TabIndex = 11;
            this.buttonGetFN.Text = "获取文件名";
            this.buttonGetFN.UseVisualStyleBackColor = true;
            this.buttonGetFN.Click += new System.EventHandler(this.buttonGetFN_Click);
            // 
            // groupBoxFileOps
            // 
            this.groupBoxFileOps.Controls.Add(this.buttonGetFN);
            this.groupBoxFileOps.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxFileOps.Location = new System.Drawing.Point(12, 32);
            this.groupBoxFileOps.Name = "groupBoxFileOps";
            this.groupBoxFileOps.Size = new System.Drawing.Size(335, 110);
            this.groupBoxFileOps.TabIndex = 1;
            this.groupBoxFileOps.TabStop = false;
            this.groupBoxFileOps.Text = "文件操作";
            // 
            // groupBoxDataOps
            // 
            this.groupBoxDataOps.Controls.Add(this.buttonPlotFit);
            this.groupBoxDataOps.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxDataOps.Location = new System.Drawing.Point(12, 148);
            this.groupBoxDataOps.Name = "groupBoxDataOps";
            this.groupBoxDataOps.Size = new System.Drawing.Size(335, 110);
            this.groupBoxDataOps.TabIndex = 2;
            this.groupBoxDataOps.TabStop = false;
            this.groupBoxDataOps.Text = "数据操作";
            // 
            // buttonPlotFit
            // 
            this.buttonPlotFit.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.buttonPlotFit.Location = new System.Drawing.Point(12, 29);
            this.buttonPlotFit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonPlotFit.Name = "buttonPlotFit";
            this.buttonPlotFit.Size = new System.Drawing.Size(150, 30);
            this.buttonPlotFit.TabIndex = 21;
            this.buttonPlotFit.Text = "散点绘制拟合";
            this.buttonPlotFit.UseVisualStyleBackColor = true;
            this.buttonPlotFit.Click += new System.EventHandler(this.buttonPlotFit_Click);
            // 
            // buttonSpmBruker
            // 
            this.buttonSpmBruker.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.buttonSpmBruker.Location = new System.Drawing.Point(12, 29);
            this.buttonSpmBruker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSpmBruker.Name = "buttonSpmBruker";
            this.buttonSpmBruker.Size = new System.Drawing.Size(150, 30);
            this.buttonSpmBruker.TabIndex = 41;
            this.buttonSpmBruker.Text = "SPM (Bruker)";
            this.buttonSpmBruker.UseVisualStyleBackColor = true;
            this.buttonSpmBruker.Click += new System.EventHandler(this.buttonSpmBruker_Click);
            // 
            // groupBoxImgOps
            // 
            this.groupBoxImgOps.Controls.Add(this.buttonImgBasis);
            this.groupBoxImgOps.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxImgOps.Location = new System.Drawing.Point(12, 264);
            this.groupBoxImgOps.Name = "groupBoxImgOps";
            this.groupBoxImgOps.Size = new System.Drawing.Size(335, 110);
            this.groupBoxImgOps.TabIndex = 3;
            this.groupBoxImgOps.TabStop = false;
            this.groupBoxImgOps.Text = "图像处理";
            // 
            // buttonImgBasis
            // 
            this.buttonImgBasis.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.buttonImgBasis.Location = new System.Drawing.Point(12, 29);
            this.buttonImgBasis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonImgBasis.Name = "buttonImgBasis";
            this.buttonImgBasis.Size = new System.Drawing.Size(150, 30);
            this.buttonImgBasis.TabIndex = 31;
            this.buttonImgBasis.Text = "图像处理基础";
            this.buttonImgBasis.UseVisualStyleBackColor = true;
            this.buttonImgBasis.Click += new System.EventHandler(this.buttonImgBasis_Click);
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Controls.Add(this.buttonSpmBruker);
            this.groupBoxOther.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxOther.Location = new System.Drawing.Point(12, 380);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(335, 110);
            this.groupBoxOther.TabIndex = 4;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "其它";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 521);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.groupBoxImgOps);
            this.Controls.Add(this.groupBoxDataOps);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.groupBoxFileOps);
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(375, 560);
            this.MinimumSize = new System.Drawing.Size(375, 560);
            this.Name = "MainForm";
            this.Text = "Toolbox Collection";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxFileOps.ResumeLayout(false);
            this.groupBoxDataOps.ResumeLayout(false);
            this.groupBoxImgOps.ResumeLayout(false);
            this.groupBoxOther.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBoxFileOps;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileOps;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDataOps;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGetFN;
        private System.Windows.Forms.GroupBox groupBoxDataOps;
        private System.Windows.Forms.Button buttonSpmBruker;
        private System.Windows.Forms.GroupBox groupBoxImgOps;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImgOps;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlotFit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOther;
        private System.Windows.Forms.Button buttonPlotFit;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.Button buttonImgBasis;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImgBasis;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSpmBruker;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSysCfg;
    }
}