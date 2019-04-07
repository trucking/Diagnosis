using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagnosis_System.patient
{
    public partial class CreatePatientForm : Form
    {
        public CreatePatientForm()
        {
            InitializeComponent();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = null;
            SexManRadioButton = null;
            SexWomanRadioButton = null;
            AgeTextBox.Text = null;
            TelphoneTextBox.Text = null;
            AddressTextBox.Text = null;
            NameTextBox.Focus();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text == "")
            {
                MessageBox.Show("请输入姓名！", "提示信息！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            string name = NameTextBox.Text;
            int age = 0;
            if(AgeTextBox.Text == "")
            {
                MessageBox.Show("请输入年龄！", "提示信息！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }else
            {
                age = Convert.ToInt16(AgeTextBox.Text);
            }
            Patient.sex patientSex = Patient.sex.Man;

            string telphone = TelphoneTextBox.Text;
            string address = AddressTextBox.Text;
            if(SexWomanRadioButton.Checked)
            {
                patientSex = Patient.sex.Woman;
            }else
            {
                MessageBox.Show("请选择性别！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            Patient patient = new Patient(name,age,patientSex,telphone,address);
            patient.CreatePatient();
            DialogResult result = MessageBox.Show("添加成功！是否继续添加？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(result == DialogResult.Yes)
            {
                this.Clearbutton_Click(sender,e);
            }else
            {
                this.Close();
            }
        }

        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
    }
}
