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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------- FileOpsTools 文件操作 ----------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 获取文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemGetFN_Click(object sender, EventArgs e)
        {
            try
            {
                // 过期保护
                if (m_isOutOfDate)
                {
                    MessageBox.Show("无权限，请先激活软件！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 弹出子窗口
                Tools.File.GetFN.SubForm subForm = new Tools.File.GetFN.SubForm();
                if (subForm.ShowDialog(this) == DialogResult.OK)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        // ----------------------------- DataOpsTools 数据操作 ----------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 散点绘制拟合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemPlotFit_Click(object sender, EventArgs e)
        {
            try
            {
                // 过期保护
                if (m_isOutOfDate)
                {
                    MessageBox.Show("无权限，请先激活软件！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 弹出子窗口
                //Tools.GetFN.SubForm subForm = new Tools.GetFN.SubForm();
                //if (subForm.ShowDialog(this) == DialogResult.OK)
                //{
                    
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------- ImgOpsTools 图像处理 ------------------------------ //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 图像处理基础
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemImgBasis_Click(object sender, EventArgs e)
        {
            try
            {
                // 过期保护
                if (m_isOutOfDate)
                {
                    MessageBox.Show("无权限，请先激活软件！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 弹出子窗口
                //Tools.GetFN.SubForm subForm = new Tools.GetFN.SubForm();
                //if (subForm.ShowDialog(this) == DialogResult.OK)
                //{
                    
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------------- OtherTools 其他 -------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// SPM (Bruker)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemSpmBruker_Click(object sender, EventArgs e)
        {
            try
            {
                // 过期保护
                if (m_isOutOfDate)
                {
                    MessageBox.Show("无权限，请先激活软件！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 弹出子窗口
                //Tools.GetFN.SubForm subForm = new Tools.GetFN.SubForm();
                //if (subForm.ShowDialog(this) == DialogResult.OK)
                //{
                    
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 菜单栏 系统设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemSysCfg_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SysForm.HelpForm helpForm = new SysForm.HelpForm();
                if (helpForm.ShowDialog(this) == DialogResult.OK)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SysForm.AboutForm aboutForm = new SysForm.AboutForm(m_dateVersion, m_pushVersion, authority);
                if (aboutForm.ShowDialog(this) == DialogResult.OK)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------- statusStripMain Events ---------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //



        // -------------------------------- button Events --------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 获取文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetFN_Click(object sender, EventArgs e)
        {
            toolStripMenuItemGetFN_Click(null, null);
        }

        /// <summary>
        /// 散点绘制拟合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlotFit_Click(object sender, EventArgs e)
        {
            toolStripMenuItemPlotFit_Click(null, null);
        }

        /// <summary>
        /// 图像处理基础
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImgBasis_Click(object sender, EventArgs e)
        {
            toolStripMenuItemImgBasis_Click(null, null);
        }

        /// <summary>
        /// SPM (Bruker)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSpmBruker_Click(object sender, EventArgs e)
        {
            toolStripMenuItemSpmBruker_Click(null, null);
        }

        
    }
}
