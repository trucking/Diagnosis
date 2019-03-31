using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagnosis_System.sysUser
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.UserTextBox.Text = "";
            this.PasswordTextBox.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text;
            string password = PasswordTextBox.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("用户名或密码不能为空，请重新输入","添加系统用户提示");
            }
            else
            {
                AccessLib.AccessLib ac = new AccessLib.AccessLib("./Diagnosis.mdb");
                List<string> items = new List<string> { "uid", "[password]" };
                List<string> values = new List<string> { username, password };
                ac.Insert("sys_user", items, values);
                sys.Log log = new sys.Log("新建了 " + username + " 系统用户",Program.User);
                MessageBox.Show("添加用户成功！");
                this.Close();
            }
        }
    }
}
