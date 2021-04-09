using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TbClct.Tools.File.RenameFN
{
    public partial class SubForm : BaseForm.ToolForm
    {
        RenameFN m_renameFN = new RenameFN();        // 修改文件名 相关类

        public SubForm()
        {
            InitializeComponent();

            // Component Initialization
            comboBoxNumberingMode.Items.AddRange(m_renameFN.m_NUMBERING_MODE);      // NumberingMode
            comboBoxNumberingMode.SelectedIndex = 0;
        }

        
        // ------------------------------------ Events ------------------------------------ //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 选择文件夹，更新文件目录树
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUrl_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxUrl.Text = folderBrowserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 文件夹路径改变，更新文件目录树
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
