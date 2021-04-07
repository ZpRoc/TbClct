using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TbClct.Tools.GetFN
{
    public class GetFN
    {
        public string m_url = string.Empty;

        public readonly string[] m_FORMAT = new string[]{"文件名", "完整路径"};
        public readonly string[] m_SORTED = new string[]{"名称升序", "名称降序", "时间升序", "时间降序", "类型升序", "类型降序"};

        public List<string> m_extList        = new List<string>();     // 后缀
        public List<FileInfo> m_fileInfoList = new List<FileInfo>();   // 文件信息

        public GetFN()
        {

        }

        // ---------------------------------- Functions ----------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 获取 [扩展名 / 文件信息] 的 List
        /// </summary>
        /// <param name="url"></param>
        /// <param name="err"></param>
        public void Update(string url, out string err)
        {
            // Initialization
            err = string.Empty;

            // Does given directory Exist?
            if (Directory.Exists(url))
            {
                // Get FileInfo
                DirectoryInfo root = new DirectoryInfo(url);
                FileInfo[] files   = root.GetFiles();

                // Clear
                m_extList.Clear();
                m_fileInfoList.Clear();

                // Add
                foreach (FileInfo file in files)
                {
                    // 文件信息
                    m_fileInfoList.Add(file);

                    // 扩展名去重
                    if (!m_extList.Contains(file.Extension))
                    {
                        m_extList.Add(file.Extension);
                    }
                }
            }
            else
            {
                err = "给定路径不存在文件夹";
            }
        }

        /// <summary>
        /// 获取输出字符串
        /// </summary>
        /// <param name="extClct"></param>
        /// <param name="format"></param>
        /// <param name="sorted"></param>
        /// <param name="isIndex"></param>
        /// <returns></returns>
        public string Output(System.Windows.Forms.CheckedListBox.CheckedItemCollection extClct, string format, string sorted, bool isIndex)
        {
            // Initialization
            string str = string.Empty;

            // Collection to ExtensionList
            List<string> extList = new List<string>();
            foreach (string ext in extClct)
            {
                extList.Add(ext.Substring(1, ext.Length - 1));
            }

            // Select
            List<FileInfo> fileInfoList = new List<FileInfo>(); 
            for (int i = 0; i < m_fileInfoList.Count; i++)
            {
                string[] fnSplit = m_fileInfoList[i].Name.Split('.');
                if (extList.Contains(fnSplit[fnSplit.Length - 1]))
                {
                    fileInfoList.Add(m_fileInfoList[i]);
                }
            }

            // Sorted fileInfoList
            if (format == m_SORTED[0])          // "名称升序"
            {
                
            }
            else if (format == m_SORTED[1])     // "名称降序"
            {
                
            }
            else if (format == m_SORTED[2])     // "时间升序"
            {
                
            }
            else if (format == m_SORTED[3])     // "时间降序"
            {
                
            }
            else if (format == m_SORTED[4])     // "类型升序"
            {
                
            }
            else if (format == m_SORTED[5])     // "类型降序"
            {
                
            }

            // Format str
            for (int i = 0; i < fileInfoList.Count; i++)
            {
                if (format == m_FORMAT[0])          // 文件名
                {
                    str += (isIndex ? (i + 1).ToString("#0000") + "\t" : "") + fileInfoList[i].Name + System.Environment.NewLine;
                }
                else if (format == m_FORMAT[1])     // 完整路径
                {
                    str += (isIndex ? (i + 1).ToString("#0000") + "\t" : "") + fileInfoList[i].FullName + System.Environment.NewLine;
                }
            }

            return str;
        }
    }
}
