using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagnosis_System.sys
{
    public partial class LogViewForm : Form
    {
        public LogViewForm()
        {
            InitializeComponent();
        }

        private void LogViewForm_Load(object sender, EventArgs e)
        {
            Log log = new Log();
            LogGridView.DataSource = log.ShowLog().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            DataSet ds = new DataSet();
            Log log = new Log();
            ds = log.ShowLog(dt);
            LogGridView.DataSource = ds.Tables[0];
        }
    }
}
