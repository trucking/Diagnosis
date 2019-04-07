using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagnosis_System
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sysUser.AddUserForm auf = new sysUser.AddUserForm();
            auf.MdiParent = this;
            auf.Show();
        }

        private void 修改用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sysUser.UserListForm ulf = new sysUser.UserListForm();
            ulf.MdiParent = this;
            ulf.Show();
        }

        private void 系统日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sys.LogViewForm lvf = new sys.LogViewForm();
            lvf.MdiParent = this;
            lvf.Show();
        }

        private void 新建人员档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient.CreatePatientForm cpf = new patient.CreatePatientForm();
            cpf.MdiParent = this;
            cpf.Show();
        }

        private void 查找档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient.SearchPatientForm spf = new patient.SearchPatientForm();
            spf.MdiParent = this;
            spf.Show();
        }
    }
}
