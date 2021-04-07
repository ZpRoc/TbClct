using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TbClct.BaseForm
{
    public partial class HelpForm : BaseForm
    {
        // ------------------------------------ Helps ------------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        string m_tools   =  @"1、" + System.Environment.NewLine
                          + @"2、";

        string m_active =   @"1、点击<激活-获取机器码>，软件会自动生成机器码。" + System.Environment.NewLine
                          + @"2、点击<确定>后，自动将机器码复制至粘贴板，请将机器码发送给码农。" + System.Environment.NewLine
                          + @"3、收到码农发回的注册码。" + System.Environment.NewLine
                          + @"4、点击<激活-载入注册码>，输入注册码。" + System.Environment.NewLine
                          + @"5、点击确定，即可完成注册。" + System.Environment.NewLine
                          + @"6、点击<帮助-关于>，可在<软件信息-Authority>中查看到期时间。";

        public HelpForm()
        {
            InitializeComponent();

            textBoxTools.Text   = m_tools;
            textBoxActivate.Text = m_active;
        }

        // ------------------------------------ Events ------------------------------------ //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 确定 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                // 关闭窗体并返回
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 取消 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // 关闭窗体并返回
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 窗体快捷键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // 回车按键，直接点击确定
                if (e.KeyCode == Keys.Enter)
                {
                    buttonOK_Click(null, null);
                }
                // Esc 直接关闭窗口
                else if (e.KeyCode == Keys.Escape)
                {
                    buttonCancel_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
