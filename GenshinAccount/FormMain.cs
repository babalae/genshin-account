using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinAccount
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "修改前请先备份自己的账户信息哦！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\miHoYo\原神", "ACCOUNT_DATA_LIST_FILEPROD_CN_h934817908", Encoding.UTF8.GetBytes(rtbAcccount.Text));
                MessageBox.Show("修改成功");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            object value = Registry.GetValue(@"HKEY_CURRENT_USER\Software\miHoYo\原神", "ACCOUNT_DATA_LIST_FILEPROD_CN_h934817908", "");
            rtbAcccount.Text = Encoding.UTF8.GetString((byte[])value);
        }
    }
}
