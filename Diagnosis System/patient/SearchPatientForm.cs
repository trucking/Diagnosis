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
    public partial class SearchPatientForm : Form
    {
        public SearchPatientForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string PatientName = SearchTextBox.Text;
            AccessLib.AccessLib ac = new AccessLib.AccessLib(Program.MdbFile);
            DataSet ds = ac.Select("patient", " [name] = '" + PatientName + "'");
            Patient patient = new Patient(PatientName);
            if(ds.Tables[0].Rows.Count != 0)
            {
                NameLabel.Text = ds.Tables[0].Rows[0][1].ToString();
                if(ds.Tables[0].Rows[0][1].ToString() == "1")
                {
                    SexLabel.Text = patient.SexToString(1);
                }else
                {
                    SexLabel.Text = patient.SexToString(0);
                }
                AgeLabel.Text = patient.ChangeAge(ds.Tables[0].Rows[0][3].ToString()).ToString();
                AddressLabel.Text = ds.Tables[0].Rows[0][5].ToString();                 
                ConsultationDataGridView.DataSource = patient.GetConsultation().Tables[0];
            }
            else
            {
                MessageBox.Show("没有找到相应就诊人员！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultation.CreateConsultationForm ccf = new consultation.CreateConsultationForm(this.SearchTextBox.Text);
            //ccf.Parent = this;
            ccf.Show();
        }
    }
}
