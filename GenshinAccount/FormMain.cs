using GenshinAccount.Utils;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinAccount
{
    public partial class FormMain : Form
    {
        private readonly string userDataPath = Path.Combine(Application.StartupPath, "UserData");
        private string thisVersion;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 标题加上版本号
            string currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (currentVersion.Length > 3)
            {
                thisVersion = currentVersion.Substring(0, 3);
                currentVersion = " v" + thisVersion;
            }
            this.Text += currentVersion;
            GAHelper.Instance.RequestPageView($"/acct/main/{thisVersion}", $"进入{thisVersion}版本原神账户切换工具主界面");

            lvwAcct.Columns[0].Width = lvwAcct.Width;
            RefreshList();
        }

        private void btnSaveCurr_Click(object sender, EventArgs e)
        {
            FormInput form = new FormInput();
            form.ShowDialog();
            RefreshList();
        }

        private void RefreshList()
        {
            if (!Directory.Exists(userDataPath))
            {
                Directory.CreateDirectory(userDataPath);
            }
            lvwAcct.Items.Clear();
            DirectoryInfo root = new DirectoryInfo(userDataPath);
            FileInfo[] files = root.GetFiles();
            foreach (FileInfo file in files)
            {
                lvwAcct.Items.Add(new ListViewItem()
                {
                    Text = file.Name
                });
            }

            if(lvwAcct.Items.Count > 0)
            {
                btnDelete.Enabled = true;
                btnSwitch.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnSwitch.Enabled = false;
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (lvwAcct.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要切换的账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = lvwAcct.SelectedItems[0]?.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请选择要切换的账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (YuanShenIsRunning())
            {
                MessageBox.Show("原神正在运行，请先关闭原神进程后再切换账号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"是否要切换为[{name}]", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                YSAccount acct = YSAccount.ReadFromDisk(name);
                acct.WriteToRegedit();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvwAcct.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要切换的账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = lvwAcct.SelectedItems[0]?.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请选择要切换的账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            YSAccount.DeleteFromDisk(name);
            RefreshList();
        }

        private bool YuanShenIsRunning()
        {
            var pros = Process.GetProcessesByName("YuanShen");
            if (pros.Any())
            {
                return true;
            }
            else
            {
                pros = Process.GetProcessesByName("GenshinImpact");
                return pros.Any();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/babalae/genshin-account");
        }
    }
}
