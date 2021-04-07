using System;
using System.Windows.Forms;


namespace TbClct.SysForm
{
    public partial class AboutForm : BaseForm.OkCancelForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        public AboutForm(string date, string version, string authority)
        {
            InitializeComponent();

            labelDate.Text      = labelDate.Tag.ToString()      + date;
            labelVersion.Text   = labelVersion.Tag.ToString()   + version;
            labelAuthority.Text = labelAuthority.Tag.ToString() + authority;
        }
    }
}
