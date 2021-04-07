namespace TbClct.BaseForm
{
    partial class OkCancelForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(267, 308);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 36);
            this.buttonCancel.TabIndex = 108;
            this.buttonCancel.Text = "取 消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.Location = new System.Drawing.Point(151, 308);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 36);
            this.buttonOK.TabIndex = 107;
            this.buttonOK.Text = "确 定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // OkCancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.KeyPreview = true;
            this.Name = "OkCancelForm";
            this.Text = "OkCancelForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OkCancelForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonOK;
    }
}