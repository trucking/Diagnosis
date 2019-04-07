using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagnosis_System.consultation
{
    public partial class CreateConsultationForm : Form
    {
        public CreateConsultationForm()
        {
            InitializeComponent();
        }

        public CreateConsultationForm(string name)
        {
            InitializeComponent();
            this.Name = name;
            this.GetPatientId();
            NameLabel.Text = name;
        }

        public string Uid { get; set; }
        public string Name { get; set; }

        private void GetPatientId()
        {
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            DataSet ds = new DataSet();
            ds = ac.Select("patient", " [name] = '" + this.Name + "'");
            Uid = ds.Tables[0].Rows[0][0].ToString();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Consultation ct = new Consultation();
            ct.CreateConsultation(this.Uid,DateTimePicker.Value.ToString("yyyy-MM-dd"),IllnessTextBox.Text,ManageMentTextBox.Text,CostTextBox.Text);

            sys.Log log = new sys.Log("添加了 " + this.Name +" 一条处置信息",Program.User);
            MessageBox.Show("已添加");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IllnessTextBox.Text = "";
            ManageMentTextBox.Text = "";
            CostTextBox.Text = "";
        }
    }
}
