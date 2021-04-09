namespace TbClct.Tools.File.RenameFN
{
    partial class SubForm
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
            this.buttonUrl = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.splitContainerName = new System.Windows.Forms.SplitContainer();
            this.groupBoxReplace = new System.Windows.Forms.GroupBox();
            this.textBoxWith = new System.Windows.Forms.TextBox();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.labelReplace2 = new System.Windows.Forms.Label();
            this.labelReplace1 = new System.Windows.Forms.Label();
            this.groupBoxRemove = new System.Windows.Forms.GroupBox();
            this.numericUpDownRemoveTo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRemoveFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRemoveLastN = new System.Windows.Forms.NumericUpDown();
            this.textBoxRemoveString = new System.Windows.Forms.TextBox();
            this.numericUpDownRemoveFirstN = new System.Windows.Forms.NumericUpDown();
            this.labelRemove5 = new System.Windows.Forms.Label();
            this.labelRemove4 = new System.Windows.Forms.Label();
            this.labelRemove3 = new System.Windows.Forms.Label();
            this.labelRemove2 = new System.Windows.Forms.Label();
            this.labelRemove1 = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.numericUpDownAddAtPos = new System.Windows.Forms.NumericUpDown();
            this.labelAdd4 = new System.Windows.Forms.Label();
            this.textBoxAddInsert = new System.Windows.Forms.TextBox();
            this.labelAdd3 = new System.Windows.Forms.Label();
            this.textBoxAddSuffix = new System.Windows.Forms.TextBox();
            this.labelAdd2 = new System.Windows.Forms.Label();
            this.textBoxAddPrefix = new System.Windows.Forms.TextBox();
            this.labelAdd1 = new System.Windows.Forms.Label();
            this.groupBoxNumbering = new System.Windows.Forms.GroupBox();
            this.numericUpDownNumberingPad = new System.Windows.Forms.NumericUpDown();
            this.labelNumbering5 = new System.Windows.Forms.Label();
            this.numericUpDownNumberingStart = new System.Windows.Forms.NumericUpDown();
            this.labelNumbering3 = new System.Windows.Forms.Label();
            this.numericUpDownNumberingIncr = new System.Windows.Forms.NumericUpDown();
            this.labelNumbering4 = new System.Windows.Forms.Label();
            this.numericUpDownNumberingAtPos = new System.Windows.Forms.NumericUpDown();
            this.labelNumbering2 = new System.Windows.Forms.Label();
            this.comboBoxNumberingMode = new System.Windows.Forms.ComboBox();
            this.labelNumbering1 = new System.Windows.Forms.Label();
            this.groupBoxRunning = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.buttonRename = new System.Windows.Forms.Button();
            this.checkBoxFolders = new System.Windows.Forms.CheckBox();
            this.checkBoxFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxSubFolders = new System.Windows.Forms.CheckBox();
            this.labelRunningSelect = new System.Windows.Forms.Label();
            this.labelRunning = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerName)).BeginInit();
            this.splitContainerName.Panel1.SuspendLayout();
            this.splitContainerName.Panel2.SuspendLayout();
            this.splitContainerName.SuspendLayout();
            this.groupBoxReplace.SuspendLayout();
            this.groupBoxRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveLastN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveFirstN)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddAtPos)).BeginInit();
            this.groupBoxNumbering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingIncr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingAtPos)).BeginInit();
            this.groupBoxRunning.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Size = new System.Drawing.Size(962, 25);
            this.labelTitle.Text = "修 改 文 件 名";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.groupBoxRunning);
            this.panelMain.Controls.Add(this.groupBoxNumbering);
            this.panelMain.Controls.Add(this.groupBoxAdd);
            this.panelMain.Controls.Add(this.groupBoxRemove);
            this.panelMain.Controls.Add(this.groupBoxReplace);
            this.panelMain.Controls.Add(this.splitContainerName);
            this.panelMain.Controls.Add(this.buttonUrl);
            this.panelMain.Controls.Add(this.textBoxUrl);
            this.panelMain.Controls.Add(this.labelUrl);
            this.panelMain.Size = new System.Drawing.Size(962, 610);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(887, 668);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(791, 668);
            // 
            // buttonUrl
            // 
            this.buttonUrl.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUrl.Location = new System.Drawing.Point(907, 8);
            this.buttonUrl.Name = "buttonUrl";
            this.buttonUrl.Size = new System.Drawing.Size(45, 29);
            this.buttonUrl.TabIndex = 115;
            this.buttonUrl.Text = "...";
            this.buttonUrl.UseVisualStyleBackColor = true;
            this.buttonUrl.Click += new System.EventHandler(this.buttonUrl_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(112, 8);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(789, 29);
            this.textBoxUrl.TabIndex = 114;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelUrl.Location = new System.Drawing.Point(6, 12);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(100, 21);
            this.labelUrl.TabIndex = 113;
            this.labelUrl.Tag = "";
            this.labelUrl.Text = "选择文件夹";
            this.labelUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMain.Location = new System.Drawing.Point(0, 0);
            this.treeViewMain.Name = "treeViewMain";
            this.treeViewMain.Size = new System.Drawing.Size(250, 342);
            this.treeViewMain.TabIndex = 116;
            // 
            // splitContainerName
            // 
            this.splitContainerName.Location = new System.Drawing.Point(8, 45);
            this.splitContainerName.Name = "splitContainerName";
            // 
            // splitContainerName.Panel1
            // 
            this.splitContainerName.Panel1.Controls.Add(this.treeViewMain);
            // 
            // splitContainerName.Panel2
            // 
            this.splitContainerName.Panel2.Controls.Add(this.listViewMain);
            this.splitContainerName.Size = new System.Drawing.Size(944, 342);
            this.splitContainerName.SplitterDistance = 250;
            this.splitContainerName.TabIndex = 117;
            // 
            // groupBoxReplace
            // 
            this.groupBoxReplace.Controls.Add(this.textBoxWith);
            this.groupBoxReplace.Controls.Add(this.textBoxReplace);
            this.groupBoxReplace.Controls.Add(this.labelReplace2);
            this.groupBoxReplace.Controls.Add(this.labelReplace1);
            this.groupBoxReplace.Location = new System.Drawing.Point(8, 393);
            this.groupBoxReplace.Name = "groupBoxReplace";
            this.groupBoxReplace.Size = new System.Drawing.Size(148, 208);
            this.groupBoxReplace.TabIndex = 118;
            this.groupBoxReplace.TabStop = false;
            this.groupBoxReplace.Text = "Replace";
            // 
            // textBoxWith
            // 
            this.textBoxWith.Location = new System.Drawing.Point(10, 133);
            this.textBoxWith.Name = "textBoxWith";
            this.textBoxWith.Size = new System.Drawing.Size(128, 29);
            this.textBoxWith.TabIndex = 122;
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(10, 63);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(128, 29);
            this.textBoxReplace.TabIndex = 121;
            // 
            // labelReplace2
            // 
            this.labelReplace2.AutoSize = true;
            this.labelReplace2.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelReplace2.Location = new System.Drawing.Point(6, 102);
            this.labelReplace2.Name = "labelReplace2";
            this.labelReplace2.Size = new System.Drawing.Size(46, 21);
            this.labelReplace2.TabIndex = 115;
            this.labelReplace2.Tag = "";
            this.labelReplace2.Text = "With";
            this.labelReplace2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReplace1
            // 
            this.labelReplace1.AutoSize = true;
            this.labelReplace1.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelReplace1.Location = new System.Drawing.Point(6, 32);
            this.labelReplace1.Name = "labelReplace1";
            this.labelReplace1.Size = new System.Drawing.Size(73, 21);
            this.labelReplace1.TabIndex = 114;
            this.labelReplace1.Tag = "";
            this.labelReplace1.Text = "Replace";
            this.labelReplace1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxRemove
            // 
            this.groupBoxRemove.Controls.Add(this.numericUpDownRemoveTo);
            this.groupBoxRemove.Controls.Add(this.numericUpDownRemoveFrom);
            this.groupBoxRemove.Controls.Add(this.numericUpDownRemoveLastN);
            this.groupBoxRemove.Controls.Add(this.textBoxRemoveString);
            this.groupBoxRemove.Controls.Add(this.numericUpDownRemoveFirstN);
            this.groupBoxRemove.Controls.Add(this.labelRemove5);
            this.groupBoxRemove.Controls.Add(this.labelRemove4);
            this.groupBoxRemove.Controls.Add(this.labelRemove3);
            this.groupBoxRemove.Controls.Add(this.labelRemove2);
            this.groupBoxRemove.Controls.Add(this.labelRemove1);
            this.groupBoxRemove.Location = new System.Drawing.Point(162, 393);
            this.groupBoxRemove.Name = "groupBoxRemove";
            this.groupBoxRemove.Size = new System.Drawing.Size(195, 208);
            this.groupBoxRemove.TabIndex = 119;
            this.groupBoxRemove.TabStop = false;
            this.groupBoxRemove.Text = "Remove";
            // 
            // numericUpDownRemoveTo
            // 
            this.numericUpDownRemoveTo.Location = new System.Drawing.Point(84, 133);
            this.numericUpDownRemoveTo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownRemoveTo.Name = "numericUpDownRemoveTo";
            this.numericUpDownRemoveTo.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownRemoveTo.TabIndex = 132;
            this.numericUpDownRemoveTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownRemoveFrom
            // 
            this.numericUpDownRemoveFrom.Location = new System.Drawing.Point(84, 98);
            this.numericUpDownRemoveFrom.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownRemoveFrom.Name = "numericUpDownRemoveFrom";
            this.numericUpDownRemoveFrom.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownRemoveFrom.TabIndex = 131;
            this.numericUpDownRemoveFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownRemoveLastN
            // 
            this.numericUpDownRemoveLastN.Location = new System.Drawing.Point(84, 63);
            this.numericUpDownRemoveLastN.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownRemoveLastN.Name = "numericUpDownRemoveLastN";
            this.numericUpDownRemoveLastN.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownRemoveLastN.TabIndex = 130;
            this.numericUpDownRemoveLastN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRemoveString
            // 
            this.textBoxRemoveString.Location = new System.Drawing.Point(84, 168);
            this.textBoxRemoveString.Name = "textBoxRemoveString";
            this.textBoxRemoveString.Size = new System.Drawing.Size(100, 29);
            this.textBoxRemoveString.TabIndex = 123;
            this.textBoxRemoveString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownRemoveFirstN
            // 
            this.numericUpDownRemoveFirstN.Location = new System.Drawing.Point(84, 28);
            this.numericUpDownRemoveFirstN.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownRemoveFirstN.Name = "numericUpDownRemoveFirstN";
            this.numericUpDownRemoveFirstN.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownRemoveFirstN.TabIndex = 129;
            this.numericUpDownRemoveFirstN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRemove5
            // 
            this.labelRemove5.AutoSize = true;
            this.labelRemove5.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelRemove5.Location = new System.Drawing.Point(10, 172);
            this.labelRemove5.Name = "labelRemove5";
            this.labelRemove5.Size = new System.Drawing.Size(64, 21);
            this.labelRemove5.TabIndex = 127;
            this.labelRemove5.Tag = "";
            this.labelRemove5.Text = "String";
            this.labelRemove5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRemove4
            // 
            this.labelRemove4.AutoSize = true;
            this.labelRemove4.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelRemove4.Location = new System.Drawing.Point(28, 137);
            this.labelRemove4.Name = "labelRemove4";
            this.labelRemove4.Size = new System.Drawing.Size(28, 21);
            this.labelRemove4.TabIndex = 126;
            this.labelRemove4.Tag = "";
            this.labelRemove4.Text = "To";
            this.labelRemove4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRemove3
            // 
            this.labelRemove3.AutoSize = true;
            this.labelRemove3.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelRemove3.Location = new System.Drawing.Point(19, 102);
            this.labelRemove3.Name = "labelRemove3";
            this.labelRemove3.Size = new System.Drawing.Size(46, 21);
            this.labelRemove3.TabIndex = 125;
            this.labelRemove3.Tag = "";
            this.labelRemove3.Text = "From";
            this.labelRemove3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRemove2
            // 
            this.labelRemove2.AutoSize = true;
            this.labelRemove2.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelRemove2.Location = new System.Drawing.Point(10, 67);
            this.labelRemove2.Name = "labelRemove2";
            this.labelRemove2.Size = new System.Drawing.Size(64, 21);
            this.labelRemove2.TabIndex = 124;
            this.labelRemove2.Tag = "";
            this.labelRemove2.Text = "Last n";
            this.labelRemove2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRemove1
            // 
            this.labelRemove1.AutoSize = true;
            this.labelRemove1.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelRemove1.Location = new System.Drawing.Point(6, 32);
            this.labelRemove1.Name = "labelRemove1";
            this.labelRemove1.Size = new System.Drawing.Size(73, 21);
            this.labelRemove1.TabIndex = 123;
            this.labelRemove1.Tag = "";
            this.labelRemove1.Text = "First n";
            this.labelRemove1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.numericUpDownAddAtPos);
            this.groupBoxAdd.Controls.Add(this.labelAdd4);
            this.groupBoxAdd.Controls.Add(this.textBoxAddInsert);
            this.groupBoxAdd.Controls.Add(this.labelAdd3);
            this.groupBoxAdd.Controls.Add(this.textBoxAddSuffix);
            this.groupBoxAdd.Controls.Add(this.labelAdd2);
            this.groupBoxAdd.Controls.Add(this.textBoxAddPrefix);
            this.groupBoxAdd.Controls.Add(this.labelAdd1);
            this.groupBoxAdd.Location = new System.Drawing.Point(363, 393);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(186, 208);
            this.groupBoxAdd.TabIndex = 120;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add";
            // 
            // numericUpDownAddAtPos
            // 
            this.numericUpDownAddAtPos.Location = new System.Drawing.Point(75, 133);
            this.numericUpDownAddAtPos.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownAddAtPos.Name = "numericUpDownAddAtPos";
            this.numericUpDownAddAtPos.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownAddAtPos.TabIndex = 135;
            this.numericUpDownAddAtPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAdd4
            // 
            this.labelAdd4.AutoSize = true;
            this.labelAdd4.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelAdd4.Location = new System.Drawing.Point(6, 137);
            this.labelAdd4.Name = "labelAdd4";
            this.labelAdd4.Size = new System.Drawing.Size(64, 21);
            this.labelAdd4.TabIndex = 134;
            this.labelAdd4.Tag = "";
            this.labelAdd4.Text = "AsPos.";
            this.labelAdd4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAddInsert
            // 
            this.textBoxAddInsert.Location = new System.Drawing.Point(75, 98);
            this.textBoxAddInsert.Name = "textBoxAddInsert";
            this.textBoxAddInsert.Size = new System.Drawing.Size(100, 29);
            this.textBoxAddInsert.TabIndex = 138;
            this.textBoxAddInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAdd3
            // 
            this.labelAdd3.AutoSize = true;
            this.labelAdd3.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelAdd3.Location = new System.Drawing.Point(6, 102);
            this.labelAdd3.Name = "labelAdd3";
            this.labelAdd3.Size = new System.Drawing.Size(64, 21);
            this.labelAdd3.TabIndex = 139;
            this.labelAdd3.Tag = "";
            this.labelAdd3.Text = "Insert";
            this.labelAdd3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAddSuffix
            // 
            this.textBoxAddSuffix.Location = new System.Drawing.Point(75, 63);
            this.textBoxAddSuffix.Name = "textBoxAddSuffix";
            this.textBoxAddSuffix.Size = new System.Drawing.Size(100, 29);
            this.textBoxAddSuffix.TabIndex = 136;
            this.textBoxAddSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAdd2
            // 
            this.labelAdd2.AutoSize = true;
            this.labelAdd2.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelAdd2.Location = new System.Drawing.Point(6, 67);
            this.labelAdd2.Name = "labelAdd2";
            this.labelAdd2.Size = new System.Drawing.Size(64, 21);
            this.labelAdd2.TabIndex = 137;
            this.labelAdd2.Tag = "";
            this.labelAdd2.Text = "Suffix";
            this.labelAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAddPrefix
            // 
            this.textBoxAddPrefix.Location = new System.Drawing.Point(75, 28);
            this.textBoxAddPrefix.Name = "textBoxAddPrefix";
            this.textBoxAddPrefix.Size = new System.Drawing.Size(100, 29);
            this.textBoxAddPrefix.TabIndex = 134;
            this.textBoxAddPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAdd1
            // 
            this.labelAdd1.AutoSize = true;
            this.labelAdd1.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelAdd1.Location = new System.Drawing.Point(6, 32);
            this.labelAdd1.Name = "labelAdd1";
            this.labelAdd1.Size = new System.Drawing.Size(64, 21);
            this.labelAdd1.TabIndex = 135;
            this.labelAdd1.Tag = "";
            this.labelAdd1.Text = "Prefix";
            this.labelAdd1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxNumbering
            // 
            this.groupBoxNumbering.Controls.Add(this.numericUpDownNumberingPad);
            this.groupBoxNumbering.Controls.Add(this.labelNumbering5);
            this.groupBoxNumbering.Controls.Add(this.numericUpDownNumberingStart);
            this.groupBoxNumbering.Controls.Add(this.labelNumbering3);
            this.groupBoxNumbering.Controls.Add(this.numericUpDownNumberingIncr);
            this.groupBoxNumbering.Controls.Add(this.labelNumbering4);
            this.groupBoxNumbering.Controls.Add(this.numericUpDownNumberingAtPos);
            this.groupBoxNumbering.Controls.Add(this.labelNumbering2);
            this.groupBoxNumbering.Controls.Add(this.comboBoxNumberingMode);
            this.groupBoxNumbering.Controls.Add(this.labelNumbering1);
            this.groupBoxNumbering.Location = new System.Drawing.Point(555, 393);
            this.groupBoxNumbering.Name = "groupBoxNumbering";
            this.groupBoxNumbering.Size = new System.Drawing.Size(186, 208);
            this.groupBoxNumbering.TabIndex = 120;
            this.groupBoxNumbering.TabStop = false;
            this.groupBoxNumbering.Text = "Numbering";
            // 
            // numericUpDownNumberingPad
            // 
            this.numericUpDownNumberingPad.Location = new System.Drawing.Point(75, 168);
            this.numericUpDownNumberingPad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNumberingPad.Name = "numericUpDownNumberingPad";
            this.numericUpDownNumberingPad.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownNumberingPad.TabIndex = 143;
            this.numericUpDownNumberingPad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumbering5
            // 
            this.labelNumbering5.AutoSize = true;
            this.labelNumbering5.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelNumbering5.Location = new System.Drawing.Point(20, 172);
            this.labelNumbering5.Name = "labelNumbering5";
            this.labelNumbering5.Size = new System.Drawing.Size(37, 21);
            this.labelNumbering5.TabIndex = 142;
            this.labelNumbering5.Tag = "";
            this.labelNumbering5.Text = "Pad";
            this.labelNumbering5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownNumberingStart
            // 
            this.numericUpDownNumberingStart.Location = new System.Drawing.Point(75, 98);
            this.numericUpDownNumberingStart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNumberingStart.Name = "numericUpDownNumberingStart";
            this.numericUpDownNumberingStart.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownNumberingStart.TabIndex = 141;
            this.numericUpDownNumberingStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumbering3
            // 
            this.labelNumbering3.AutoSize = true;
            this.labelNumbering3.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelNumbering3.Location = new System.Drawing.Point(11, 102);
            this.labelNumbering3.Name = "labelNumbering3";
            this.labelNumbering3.Size = new System.Drawing.Size(55, 21);
            this.labelNumbering3.TabIndex = 140;
            this.labelNumbering3.Tag = "";
            this.labelNumbering3.Text = "Start";
            this.labelNumbering3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownNumberingIncr
            // 
            this.numericUpDownNumberingIncr.Location = new System.Drawing.Point(75, 133);
            this.numericUpDownNumberingIncr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNumberingIncr.Name = "numericUpDownNumberingIncr";
            this.numericUpDownNumberingIncr.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownNumberingIncr.TabIndex = 139;
            this.numericUpDownNumberingIncr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumbering4
            // 
            this.labelNumbering4.AutoSize = true;
            this.labelNumbering4.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelNumbering4.Location = new System.Drawing.Point(11, 137);
            this.labelNumbering4.Name = "labelNumbering4";
            this.labelNumbering4.Size = new System.Drawing.Size(55, 21);
            this.labelNumbering4.TabIndex = 138;
            this.labelNumbering4.Tag = "";
            this.labelNumbering4.Text = "Incr.";
            this.labelNumbering4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownNumberingAtPos
            // 
            this.numericUpDownNumberingAtPos.Location = new System.Drawing.Point(75, 63);
            this.numericUpDownNumberingAtPos.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNumberingAtPos.Name = "numericUpDownNumberingAtPos";
            this.numericUpDownNumberingAtPos.Size = new System.Drawing.Size(100, 29);
            this.numericUpDownNumberingAtPos.TabIndex = 137;
            this.numericUpDownNumberingAtPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumbering2
            // 
            this.labelNumbering2.AutoSize = true;
            this.labelNumbering2.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelNumbering2.Location = new System.Drawing.Point(6, 67);
            this.labelNumbering2.Name = "labelNumbering2";
            this.labelNumbering2.Size = new System.Drawing.Size(64, 21);
            this.labelNumbering2.TabIndex = 136;
            this.labelNumbering2.Tag = "";
            this.labelNumbering2.Text = "AtPos.";
            this.labelNumbering2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxNumberingMode
            // 
            this.comboBoxNumberingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberingMode.FormattingEnabled = true;
            this.comboBoxNumberingMode.Location = new System.Drawing.Point(75, 28);
            this.comboBoxNumberingMode.Name = "comboBoxNumberingMode";
            this.comboBoxNumberingMode.Size = new System.Drawing.Size(100, 29);
            this.comboBoxNumberingMode.TabIndex = 135;
            // 
            // labelNumbering1
            // 
            this.labelNumbering1.AutoSize = true;
            this.labelNumbering1.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelNumbering1.Location = new System.Drawing.Point(15, 32);
            this.labelNumbering1.Name = "labelNumbering1";
            this.labelNumbering1.Size = new System.Drawing.Size(46, 21);
            this.labelNumbering1.TabIndex = 134;
            this.labelNumbering1.Tag = "";
            this.labelNumbering1.Text = "Mode";
            this.labelNumbering1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxRunning
            // 
            this.groupBoxRunning.Controls.Add(this.labelRunning);
            this.groupBoxRunning.Controls.Add(this.labelRunningSelect);
            this.groupBoxRunning.Controls.Add(this.checkBoxSubFolders);
            this.groupBoxRunning.Controls.Add(this.checkBoxFiles);
            this.groupBoxRunning.Controls.Add(this.checkBoxFolders);
            this.groupBoxRunning.Controls.Add(this.buttonRename);
            this.groupBoxRunning.Location = new System.Drawing.Point(747, 393);
            this.groupBoxRunning.Name = "groupBoxRunning";
            this.groupBoxRunning.Size = new System.Drawing.Size(205, 208);
            this.groupBoxRunning.TabIndex = 144;
            this.groupBoxRunning.TabStop = false;
            this.groupBoxRunning.Text = "Running";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "选择文件夹";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // listViewMain
            // 
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(0, 0);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(690, 342);
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRename
            // 
            this.buttonRename.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRename.Location = new System.Drawing.Point(16, 168);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(174, 29);
            this.buttonRename.TabIndex = 1;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            // 
            // checkBoxFolders
            // 
            this.checkBoxFolders.AutoSize = true;
            this.checkBoxFolders.Checked = true;
            this.checkBoxFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFolders.Location = new System.Drawing.Point(20, 30);
            this.checkBoxFolders.Name = "checkBoxFolders";
            this.checkBoxFolders.Size = new System.Drawing.Size(92, 25);
            this.checkBoxFolders.TabIndex = 2;
            this.checkBoxFolders.Text = "Folders";
            this.checkBoxFolders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxFolders.UseVisualStyleBackColor = true;
            // 
            // checkBoxFiles
            // 
            this.checkBoxFiles.AutoSize = true;
            this.checkBoxFiles.Checked = true;
            this.checkBoxFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFiles.Location = new System.Drawing.Point(118, 30);
            this.checkBoxFiles.Name = "checkBoxFiles";
            this.checkBoxFiles.Size = new System.Drawing.Size(74, 25);
            this.checkBoxFiles.TabIndex = 3;
            this.checkBoxFiles.Text = "Files";
            this.checkBoxFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubFolders
            // 
            this.checkBoxSubFolders.AutoSize = true;
            this.checkBoxSubFolders.Location = new System.Drawing.Point(20, 65);
            this.checkBoxSubFolders.Name = "checkBoxSubFolders";
            this.checkBoxSubFolders.Size = new System.Drawing.Size(128, 25);
            this.checkBoxSubFolders.TabIndex = 4;
            this.checkBoxSubFolders.Text = "Sub-Folders";
            this.checkBoxSubFolders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSubFolders.UseVisualStyleBackColor = true;
            // 
            // labelRunningSelect
            // 
            this.labelRunningSelect.AutoSize = true;
            this.labelRunningSelect.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelRunningSelect.Location = new System.Drawing.Point(16, 102);
            this.labelRunningSelect.Name = "labelRunningSelect";
            this.labelRunningSelect.Size = new System.Drawing.Size(82, 21);
            this.labelRunningSelect.TabIndex = 140;
            this.labelRunningSelect.Tag = "Slt: ";
            this.labelRunningSelect.Text = "Slt: 0/0";
            this.labelRunningSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRunning
            // 
            this.labelRunning.AutoSize = true;
            this.labelRunning.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelRunning.Location = new System.Drawing.Point(16, 137);
            this.labelRunning.Name = "labelRunning";
            this.labelRunning.Size = new System.Drawing.Size(82, 21);
            this.labelRunning.TabIndex = 141;
            this.labelRunning.Tag = "Run: ";
            this.labelRunning.Text = "Run: 0/0";
            this.labelRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Name = "SubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改文件吗";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.splitContainerName.Panel1.ResumeLayout(false);
            this.splitContainerName.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerName)).EndInit();
            this.splitContainerName.ResumeLayout(false);
            this.groupBoxReplace.ResumeLayout(false);
            this.groupBoxReplace.PerformLayout();
            this.groupBoxRemove.ResumeLayout(false);
            this.groupBoxRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveLastN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveFirstN)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddAtPos)).EndInit();
            this.groupBoxNumbering.ResumeLayout(false);
            this.groupBoxNumbering.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingIncr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberingAtPos)).EndInit();
            this.groupBoxRunning.ResumeLayout(false);
            this.groupBoxRunning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.SplitContainer splitContainerName;
        private System.Windows.Forms.GroupBox groupBoxNumbering;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxRemove;
        private System.Windows.Forms.GroupBox groupBoxReplace;
        private System.Windows.Forms.Label labelReplace2;
        private System.Windows.Forms.Label labelReplace1;
        private System.Windows.Forms.TextBox textBoxWith;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label labelRemove2;
        private System.Windows.Forms.Label labelRemove1;
        private System.Windows.Forms.Label labelRemove5;
        private System.Windows.Forms.Label labelRemove4;
        private System.Windows.Forms.Label labelRemove3;
        private System.Windows.Forms.NumericUpDown numericUpDownRemoveTo;
        private System.Windows.Forms.NumericUpDown numericUpDownRemoveFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownRemoveLastN;
        private System.Windows.Forms.TextBox textBoxRemoveString;
        private System.Windows.Forms.NumericUpDown numericUpDownRemoveFirstN;
        private System.Windows.Forms.NumericUpDown numericUpDownAddAtPos;
        private System.Windows.Forms.Label labelAdd4;
        private System.Windows.Forms.TextBox textBoxAddInsert;
        private System.Windows.Forms.Label labelAdd3;
        private System.Windows.Forms.TextBox textBoxAddSuffix;
        private System.Windows.Forms.Label labelAdd2;
        private System.Windows.Forms.TextBox textBoxAddPrefix;
        private System.Windows.Forms.Label labelAdd1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberingPad;
        private System.Windows.Forms.Label labelNumbering5;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberingStart;
        private System.Windows.Forms.Label labelNumbering3;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberingIncr;
        private System.Windows.Forms.Label labelNumbering4;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberingAtPos;
        private System.Windows.Forms.Label labelNumbering2;
        private System.Windows.Forms.ComboBox comboBoxNumberingMode;
        private System.Windows.Forms.Label labelNumbering1;
        private System.Windows.Forms.GroupBox groupBoxRunning;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.CheckBox checkBoxFolders;
        private System.Windows.Forms.CheckBox checkBoxSubFolders;
        private System.Windows.Forms.CheckBox checkBoxFiles;
        private System.Windows.Forms.Label labelRunning;
        private System.Windows.Forms.Label labelRunningSelect;
    }
}