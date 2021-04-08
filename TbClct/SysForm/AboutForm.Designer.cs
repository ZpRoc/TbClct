namespace TbClct.SysForm
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxAbout = new System.Windows.Forms.GroupBox();
            this.labelAuthority = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAlipay = new System.Windows.Forms.Label();
            this.pictureBoxAlipay = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxAbout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlipay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(177, 468);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(81, 468);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(11, 11);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(252, 25);
            this.labelTitle.TabIndex = 102;
            this.labelTitle.Text = "关于";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxAbout
            // 
            this.groupBoxAbout.Controls.Add(this.labelAuthority);
            this.groupBoxAbout.Controls.Add(this.labelVersion);
            this.groupBoxAbout.Controls.Add(this.labelDate);
            this.groupBoxAbout.Controls.Add(this.labelAuthor);
            this.groupBoxAbout.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxAbout.Location = new System.Drawing.Point(11, 40);
            this.groupBoxAbout.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAbout.Name = "groupBoxAbout";
            this.groupBoxAbout.Size = new System.Drawing.Size(252, 146);
            this.groupBoxAbout.TabIndex = 103;
            this.groupBoxAbout.TabStop = false;
            this.groupBoxAbout.Text = "软件信息";
            // 
            // labelAuthority
            // 
            this.labelAuthority.AutoSize = true;
            this.labelAuthority.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAuthority.Location = new System.Drawing.Point(13, 116);
            this.labelAuthority.Name = "labelAuthority";
            this.labelAuthority.Size = new System.Drawing.Size(190, 21);
            this.labelAuthority.TabIndex = 106;
            this.labelAuthority.Tag = "Authority: ";
            this.labelAuthority.Text = "Authority: No access";
            this.labelAuthority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.Location = new System.Drawing.Point(13, 86);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(145, 21);
            this.labelVersion.TabIndex = 105;
            this.labelVersion.Tag = "Version: ";
            this.labelVersion.Text = "Version: V1.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDate.Location = new System.Drawing.Point(13, 56);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(136, 21);
            this.labelDate.TabIndex = 104;
            this.labelDate.Tag = "Date: ";
            this.labelDate.Text = "Date: 20210101";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAuthor.Location = new System.Drawing.Point(13, 26);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(127, 21);
            this.labelAuthor.TabIndex = 103;
            this.labelAuthor.Tag = "Author: ";
            this.labelAuthor.Text = "Author: ZpRoc";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAlipay);
            this.groupBox1.Controls.Add(this.pictureBoxAlipay);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(11, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 267);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "作者信息";
            // 
            // labelAlipay
            // 
            this.labelAlipay.AutoSize = true;
            this.labelAlipay.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAlipay.ForeColor = System.Drawing.Color.Blue;
            this.labelAlipay.Location = new System.Drawing.Point(13, 60);
            this.labelAlipay.Name = "labelAlipay";
            this.labelAlipay.Size = new System.Drawing.Size(154, 21);
            this.labelAlipay.TabIndex = 109;
            this.labelAlipay.Tag = "";
            this.labelAlipay.Text = "欢迎打赏(支付宝)";
            this.labelAlipay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAlipay
            // 
            this.pictureBoxAlipay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlipay.BackgroundImage")));
            this.pictureBoxAlipay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAlipay.Location = new System.Drawing.Point(46, 94);
            this.pictureBoxAlipay.Name = "pictureBoxAlipay";
            this.pictureBoxAlipay.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxAlipay.TabIndex = 108;
            this.pictureBoxAlipay.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmail.Location = new System.Drawing.Point(13, 29);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(226, 21);
            this.labelEmail.TabIndex = 107;
            this.labelEmail.Tag = "Email: ";
            this.labelEmail.Text = "Email: pengzheng@188.com";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAbout);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(290, 550);
            this.MinimumSize = new System.Drawing.Size(290, 550);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.groupBoxAbout, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.groupBoxAbout.ResumeLayout(false);
            this.groupBoxAbout.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlipay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAuthority;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelAlipay;
        private System.Windows.Forms.PictureBox pictureBoxAlipay;
        private System.Windows.Forms.Label labelEmail;
    }
}