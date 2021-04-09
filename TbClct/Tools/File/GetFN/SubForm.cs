using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TbClct.Tools.File.GetFN
{
    public partial class SubForm : BaseForm.ToolForm
    {
        GetFN m_getFN = new GetFN();        // 获取文件名 相关类

        public SubForm()
        {
            InitializeComponent();

            // Component Initialization
            comboBoxFormat.SelectedIndexChanged -= new System.EventHandler(comboBoxFormat_SelectedIndexChanged);
            comboBoxSorted.SelectedIndexChanged -= new System.EventHandler(comboBoxSorted_SelectedIndexChanged);

            comboBoxFormat.Items.AddRange(m_getFN.m_FORMAT);        // 输出格式
            comboBoxFormat.SelectedIndex = 0;                     

            comboBoxSorted.Items.AddRange(m_getFN.m_SORTED);        // 输出排序
            comboBoxSorted.SelectedIndex = 0;                     

            comboBoxFormat.SelectedIndexChanged += new System.EventHandler(comboBoxFormat_SelectedIndexChanged);
            comboBoxSorted.SelectedIndexChanged += new System.EventHandler(comboBoxSorted_SelectedIndexChanged);
        }

        // ------------------------------------ Events ------------------------------------ //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 选择文件夹，更新文件名
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
        /// 文件夹路径改变，更新文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Get fullname and extension
                m_getFN.Update(textBoxUrl.Text, out string err);
                if (!string.IsNullOrWhiteSpace(err))
                {
                    MessageBox.Show(err);
                    return;
                }

                // Update Suffix
                checkedListBoxSuffix.Items.Clear();
                foreach (string ext in m_getFN.m_extList)
                {
                    checkedListBoxSuffix.Items.Add(ext);
                }

                // Update SelectAll
                checkBoxSelectAll_CheckedChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 是否全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // 禁止 文件扩展名选择事件
                checkedListBoxSuffix.SelectedIndexChanged -= new System.EventHandler(checkedListBoxSuffix_SelectedIndexChanged);

                // 设置 文件扩展名 选中项目
                if (checkBoxSelectAll.Checked)
                {
                    for (int i = 0; i < checkedListBoxSuffix.Items.Count; i++)
                    {
                        checkedListBoxSuffix.SetItemChecked(i, true);
                    }
                }
                else
                {
                    for (int i = 0; i < checkedListBoxSuffix.Items.Count; i++)
                    {
                        checkedListBoxSuffix.SetItemChecked(i, false);
                    }
                }

                // 启动并调用 文件扩展名选择事件
                checkedListBoxSuffix.SelectedIndexChanged += new System.EventHandler(checkedListBoxSuffix_SelectedIndexChanged);
                checkedListBoxSuffix_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 文件扩展名选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBoxSuffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxFN.Text = m_getFN.Output(checkedListBoxSuffix.CheckedItems, comboBoxFormat.SelectedItem.ToString(), 
                                                comboBoxSorted.SelectedItem.ToString(), checkBoxIsIndex.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 文件名输出格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxFN.Text = m_getFN.Output(checkedListBoxSuffix.CheckedItems, comboBoxFormat.SelectedItem.ToString(), 
                                                comboBoxSorted.SelectedItem.ToString(), checkBoxIsIndex.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 文件名输出排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSorted_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxFN.Text = m_getFN.Output(checkedListBoxSuffix.CheckedItems, comboBoxFormat.SelectedItem.ToString(), 
                                                comboBoxSorted.SelectedItem.ToString(), checkBoxIsIndex.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 是否 添加编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxIsIndex_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxFN.Text = m_getFN.Output(checkedListBoxSuffix.CheckedItems, comboBoxFormat.SelectedItem.ToString(), 
                                                comboBoxSorted.SelectedItem.ToString(), checkBoxIsIndex.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 导出 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    m_getFN.WriteTxt(saveFileDialog.FileName, textBoxFN.Text, out string err);
                    if (!string.IsNullOrWhiteSpace(err))
                    {
                        MessageBox.Show(err);
                        return;
                    }
                    MessageBox.Show("导出完成！", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
