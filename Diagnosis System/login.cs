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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string accessPath = "./Diagnosis.mdb";
            AccessLib.AccessLib Al = new AccessLib.AccessLib(accessPath);
            
            string table = "sys_user";
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string condition = " uid = '" + username + "' and password = '" + password + "'";
            DataSet ds = new DataSet();
            ds = Al.Select(table, condition);

            if(ds.Tables[0].Rows.Count != 0)
            {                
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Hide();
                Program.User = username;
                sys.Log log = new sys.Log("系统登陆", Program.User);                
                Al.CloseConn();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }            
        }
    }
}
