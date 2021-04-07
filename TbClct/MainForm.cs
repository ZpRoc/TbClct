using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TbClct
{
    public partial class MainForm : BaseForm.BaseForm
    {
        // 版本
        string m_dateVersion = "20210407";
        string m_pushVersion = "V1.0.0";

        // 是否过期
        string m_overtime  = string.Empty;
        bool m_isOutOfDate = true;


        public MainForm()
        {
            InitializeComponent();

            // 菜单栏 激活
            Activation.ActivateMenu am = new Activation.ActivateMenu();
            toolStripMenuItemMainActivate.DropDown = am.ContextMenuStripActivate;

            // 软件注册权限
            Activation.SecretKey sk = new Activation.SecretKey();
            m_overtime              = sk.GetOverTime();
            m_isOutOfDate           = sk.IsOutOfDate(m_overtime);
        }

        // ------------------------------------ Timer ------------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        private void timerMain_Tick(object sender, EventArgs e)
        {
            try
            {
                // 更新状态栏时间
                toolStripStatusLabelTime.Text = DateTime.Now.ToString(toolStripStatusLabelTime.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ------------------------------------ Tools ------------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        private void buttonGetFilenames_Click(object sender, EventArgs e)
        {
            try
            {
                // 过期保护
                if (m_isOutOfDate)
                    MessageBox.Show("无权限，请先激活软件！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // ----------------------------- menuStripMain Events ----------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 菜单栏 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 菜单栏 查看帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            try
            {
                // 弹出命令配置窗口
                BaseForm.HelpForm helpForm = new BaseForm.HelpForm();
                if (helpForm.ShowDialog(this) == DialogResult.OK)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 菜单栏 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            try
            {
                string authority = string.Empty;

                if (!m_isOutOfDate)
                {
                    authority = m_overtime;
                }
                else
                {
                    authority = "No access";
                }

                // 弹出命令配置窗口
                BaseForm.AboutForm aboutForm = new BaseForm.AboutForm(m_dateVersion, m_pushVersion, authority);
                if (aboutForm.ShowDialog(this) == DialogResult.OK)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---------------------------- statusStripMain Events ---------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //
    }
}
