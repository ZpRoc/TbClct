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
        public List<string> m_extList = new List<string>();     // 后缀
        public List<string> m_fnListY = new List<string>();     // 文件名 (有后缀)
        public List<string> m_fnListN = new List<string>();     // 文件名 (无后缀)
        public List<string> m_urlList = new List<string>();     // 完整路径


        public GetFN()
        {

        }


        // ---------------------------------- Functions ----------------------------------- //
        // -------------------------------------------------------------------------------- //
        // -------------------------------------------------------------------------------- //

        /// <summary>
        /// 获取完整路径
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public List<string> GetAllFNs(string url)
        {
            List<string> fnList = new List<string>();

            if (Directory.Exists(url))
            {
                DirectoryInfo root = new DirectoryInfo(url);
                FileInfo[] files = root.GetFiles();
                foreach (FileInfo file in files)
                {
                    fnList.Add(file.FullName);
                }
            }

            return fnList;
        }
    }
}
