namespace TbClct.Tools.GetFN
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
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonUrl = new System.Windows.Forms.Button();
            this.checkedListBoxSuffix = new System.Windows.Forms.CheckedListBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.comboBoxSorted = new System.Windows.Forms.ComboBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.checkBoxIsIndex = new System.Windows.Forms.CheckBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Size = new System.Drawing.Size(562, 25);
            this.labelTitle.Text = "获 取 文 件 名";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.checkBoxIsIndex);
            this.panelMain.Controls.Add(this.buttonExport);
            this.panelMain.Controls.Add(this.comboBoxSorted);
            this.panelMain.Controls.Add(this.comboBoxFormat);
            this.panelMain.Controls.Add(this.checkBoxSelectAll);
            this.panelMain.Controls.Add(this.textBoxFN);
            this.panelMain.Controls.Add(this.checkedListBoxSuffix);
            this.panelMain.Controls.Add(this.buttonUrl);
            this.panelMain.Controls.Add(this.textBoxUrl);
            this.panelMain.Controls.Add(this.labelUrl);
            this.panelMain.Size = new System.Drawing.Size(562, 260);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(487, 318);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(391, 318);
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F);
            this.labelUrl.Location = new System.Drawing.Point(6, 12);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(100, 21);
            this.labelUrl.TabIndex = 110;
            this.labelUrl.Tag = "";
            this.labelUrl.Text = "选择文件夹";
            this.labelUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(112, 8);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(389, 29);
            this.textBoxUrl.TabIndex = 111;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // buttonUrl
            // 
            this.buttonUrl.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUrl.Location = new System.Drawing.Point(507, 7);
            this.buttonUrl.Name = "buttonUrl";
            this.buttonUrl.Size = new System.Drawing.Size(45, 30);
            this.buttonUrl.TabIndex = 112;
            this.buttonUrl.Text = "...";
            this.buttonUrl.UseVisualStyleBackColor = true;
            this.buttonUrl.Click += new System.EventHandler(this.buttonUrl_Click);
            // 
            // checkedListBoxSuffix
            // 
            this.checkedListBoxSuffix.CheckOnClick = true;
            this.checkedListBoxSuffix.FormattingEnabled = true;
            this.checkedListBoxSuffix.Location = new System.Drawing.Point(8, 78);
            this.checkedListBoxSuffix.Name = "checkedListBoxSuffix";
            this.checkedListBoxSuffix.Size = new System.Drawing.Size(100, 172);
            this.checkedListBoxSuffix.TabIndex = 113;
            this.checkedListBoxSuffix.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSuffix_SelectedIndexChanged);
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(116, 78);
            this.textBoxFN.Multiline = true;
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.ReadOnly = true;
            this.textBoxFN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFN.Size = new System.Drawing.Size(436, 172);
            this.textBoxFN.TabIndex = 114;
            this.textBoxFN.WordWrap = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "选择文件夹";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(116, 44);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(100, 29);
            this.comboBoxFormat.TabIndex = 116;
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormat_SelectedIndexChanged);
            // 
            // comboBoxSorted
            // 
            this.comboBoxSorted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSorted.FormattingEnabled = true;
            this.comboBoxSorted.Location = new System.Drawing.Point(234, 44);
            this.comboBoxSorted.Name = "comboBoxSorted";
            this.comboBoxSorted.Size = new System.Drawing.Size(100, 29);
            this.comboBoxSorted.TabIndex = 117;
            this.comboBoxSorted.SelectedIndexChanged += new System.EventHandler(this.comboBoxSorted_SelectedIndexChanged);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExport.Location = new System.Drawing.Point(472, 43);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(80, 30);
            this.buttonExport.TabIndex = 118;
            this.buttonExport.Text = "导出";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(10, 46);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(65, 25);
            this.checkBoxSelectAll.TabIndex = 111;
            this.checkBoxSelectAll.Text = "全选";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // checkBoxIsIndex
            // 
            this.checkBoxIsIndex.AutoSize = true;
            this.checkBoxIsIndex.Location = new System.Drawing.Point(358, 46);
            this.checkBoxIsIndex.Name = "checkBoxIsIndex";
            this.checkBoxIsIndex.Size = new System.Drawing.Size(101, 25);
            this.checkBoxIsIndex.TabIndex = 119;
            this.checkBoxIsIndex.Text = "添加编号";
            this.checkBoxIsIndex.UseVisualStyleBackColor = true;
            this.checkBoxIsIndex.CheckedChanged += new System.EventHandler(this.checkBoxIsIndex_CheckedChanged);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Name = "SubForm";
            this.Text = "获取文件名";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Button buttonUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.CheckedListBox checkedListBoxSuffix;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox comboBoxSorted;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.CheckBox checkBoxIsIndex;
    }
}