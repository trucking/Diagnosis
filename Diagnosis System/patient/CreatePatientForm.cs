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

        }
    }
}
