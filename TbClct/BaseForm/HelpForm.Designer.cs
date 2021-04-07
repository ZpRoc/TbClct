namespace TbClct.BaseForm
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControlHelp = new System.Windows.Forms.TabControl();
            this.tabPageTools = new System.Windows.Forms.TabPage();
            this.textBoxTools = new System.Windows.Forms.TextBox();
            this.tabPageActivate = new System.Windows.Forms.TabPage();
            this.textBoxActivate = new System.Windows.Forms.TextBox();
            this.tabControlHelp.SuspendLayout();
            this.tabPageTools.SuspendLayout();
            this.tabPageActivate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(316, 536);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 33);
            this.buttonCancel.TabIndex = 108;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.Location = new System.Drawing.Point(200, 536);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 33);
            this.buttonOK.TabIndex = 107;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(176, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(66, 31);
            this.labelTitle.TabIndex = 109;
            this.labelTitle.Text = "帮助";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlHelp
            // 
            this.tabControlHelp.Controls.Add(this.tabPageTools);
            this.tabControlHelp.Controls.Add(this.tabPageActivate);
            this.tabControlHelp.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlHelp.Location = new System.Drawing.Point(12, 56);
            this.tabControlHelp.Name = "tabControlHelp";
            this.tabControlHelp.SelectedIndex = 0;
            this.tabControlHelp.Size = new System.Drawing.Size(408, 470);
            this.tabControlHelp.TabIndex = 110;
            // 
            // tabPageTools
            // 
            this.tabPageTools.Controls.Add(this.textBoxTools);
            this.tabPageTools.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageTools.Location = new System.Drawing.Point(4, 34);
            this.tabPageTools.Name = "tabPageTools";
            this.tabPageTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTools.Size = new System.Drawing.Size(400, 432);
            this.tabPageTools.TabIndex = 0;
            this.tabPageTools.Text = "  工具  ";
            this.tabPageTools.UseVisualStyleBackColor = true;
            // 
            // textBoxTools
            // 
            this.textBoxTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTools.Location = new System.Drawing.Point(3, 3);
            this.textBoxTools.Multiline = true;
            this.textBoxTools.Name = "textBoxTools";
            this.textBoxTools.ReadOnly = true;
            this.textBoxTools.Size = new System.Drawing.Size(394, 426);
            this.textBoxTools.TabIndex = 0;
            // 
            // tabPageActivate
            // 
            this.tabPageActivate.Controls.Add(this.textBoxActivate);
            this.tabPageActivate.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageActivate.Location = new System.Drawing.Point(4, 34);
            this.tabPageActivate.Name = "tabPageActivate";
            this.tabPageActivate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActivate.Size = new System.Drawing.Size(400, 432);
            this.tabPageActivate.TabIndex = 2;
            this.tabPageActivate.Text = "  激活  ";
            this.tabPageActivate.UseVisualStyleBackColor = true;
            // 
            // textBoxActivate
            // 
            this.textBoxActivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxActivate.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxActivate.Location = new System.Drawing.Point(3, 3);
            this.textBoxActivate.Multiline = true;
            this.textBoxActivate.Name = "textBoxActivate";
            this.textBoxActivate.ReadOnly = true;
            this.textBoxActivate.Size = new System.Drawing.Size(394, 426);
            this.textBoxActivate.TabIndex = 1;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 581);
            this.Controls.Add(this.tabControlHelp);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "帮助";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpForm_KeyDown);
            this.tabControlHelp.ResumeLayout(false);
            this.tabPageTools.ResumeLayout(false);
            this.tabPageTools.PerformLayout();
            this.tabPageActivate.ResumeLayout(false);
            this.tabPageActivate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControlHelp;
        private System.Windows.Forms.TabPage tabPageTools;
        private System.Windows.Forms.TabPage tabPageActivate;
        private System.Windows.Forms.TextBox textBoxTools;
        private System.Windows.Forms.TextBox textBoxActivate;
    }
}