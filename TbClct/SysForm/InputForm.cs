using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TbClct.SysForm
{
    public partial class InputForm : BaseForm.OkCancelForm
    {
        public string m_title = string.Empty;
        public string m_input = string.Empty;

        public InputForm()
        {
            InitializeComponent();
        }

        public InputForm(string title)
        {
            InitializeComponent();

            m_title         = title;
            labelTitle.Text = title;
        }

        // ------------------------------- override Events -------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 确定 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign
                m_title = labelTitle.Text;

                // 关闭窗体并返回
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
