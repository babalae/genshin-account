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
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAcctName.Text))
            {
                MessageBox.Show("请输入账号备注", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            YSAccount acct = YSAccount.ReadFromRegedit(chkSaveSettings.Checked);
            acct.Name = txtAcctName.Text;
            acct.WriteToDisk();
            this.Close();
        }
    }
}
