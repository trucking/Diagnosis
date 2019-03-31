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
    public partial class UserListForm : Form
    {
        
        public UserListForm()
        {
            InitializeComponent();
        }
        private string userId = "";

        private void UserListForm_Load(object sender, EventArgs e)
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib("./Diagnosis.mdb");
            DataSet ds = new DataSet();
            List<string> items = new List<string> { "id", "uid", "password" };            
            ds = ac.Select(items,"sys_user","uid <> 'admin'");            
            UserListGridView.DataSource = ds.Tables[0];
            ac.CloseConn();
        }

        private void UserListGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(UserListGridView.SelectedRows.Count == 1)
            {
                UserNameTextBox.Text = UserListGridView.SelectedRows[0].Cells[1].Value.ToString();
                PasswordTextBox.Text = UserListGridView.SelectedRows[0].Cells[2].Value.ToString();
                this.userId = UserListGridView.SelectedRows[0].Cells[0].Value.ToString();
            }
            else if(UserListGridView.SelectedRows.Count == 0)
            {
                
            }
            else
            {
                MessageBox.Show("请选择一行进行操作！");
                UserListGridView.ClearSelection();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib("./Diagnosis.mdb");
            Dictionary<string, string> keyValues = new Dictionary<string, string> { };
            keyValues.Add("[uid]", UserNameTextBox.Text);
            keyValues.Add("[password]", PasswordTextBox.Text);
            ac.Update("sys_user", keyValues, "id = "+this.userId);
            ac.CloseConn();
            MessageBox.Show("已修改","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            UserListGridView.SelectedRows[0].Cells[1].Value = UserNameTextBox.Text;
            UserListGridView.SelectedRows[0].Cells[2].Value = PasswordTextBox.Text;
            sys.Log log = new sys.Log("修改系统用户" + UserNameTextBox.Text + "的用户信息", Program.User);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除用户信息吗？删除后将无法恢复", "警告信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                AccessLib.AccessLib ac = new AccessLib.AccessLib("./Diagnosis.mdb");
                ac.Delete("sys_user"," [id] = "+this.userId+"");
                ac.CloseConn();
                sys.Log log = new sys.Log("删除系统用户" + UserNameTextBox.Text + "的用户信息", Program.User);
                UserListGridView.Rows.RemoveAt(UserListGridView.SelectedRows[0].Index);
            }            
        }
    }
}
