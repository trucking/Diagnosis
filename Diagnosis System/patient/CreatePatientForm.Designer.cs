namespace Diagnosis_System.patient
{
    partial class CreatePatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.TelphoneTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SexManRadioButton = new System.Windows.Forms.RadioButton();
            this.SexWomanRadioButton = new System.Windows.Forms.RadioButton();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "年龄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "手机号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "地址";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(225, 9);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(129, 21);
            this.NameTextBox.TabIndex = 6;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(225, 90);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(129, 21);
            this.AgeTextBox.TabIndex = 8;
            this.AgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeTextBox_KeyPress);
            // 
            // TelphoneTextBox
            // 
            this.TelphoneTextBox.Location = new System.Drawing.Point(225, 127);
            this.TelphoneTextBox.Name = "TelphoneTextBox";
            this.TelphoneTextBox.Size = new System.Drawing.Size(129, 21);
            this.TelphoneTextBox.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(84, 182);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(270, 21);
            this.AddressTextBox.TabIndex = 10;
            // 
            // SexManRadioButton
            // 
            this.SexManRadioButton.AutoSize = true;
            this.SexManRadioButton.Checked = true;
            this.SexManRadioButton.Location = new System.Drawing.Point(225, 52);
            this.SexManRadioButton.Name = "SexManRadioButton";
            this.SexManRadioButton.Size = new System.Drawing.Size(35, 16);
            this.SexManRadioButton.TabIndex = 11;
            this.SexManRadioButton.TabStop = true;
            this.SexManRadioButton.Text = "男";
            this.SexManRadioButton.UseVisualStyleBackColor = true;
            // 
            // SexWomanRadioButton
            // 
            this.SexWomanRadioButton.AutoSize = true;
            this.SexWomanRadioButton.Location = new System.Drawing.Point(266, 52);
            this.SexWomanRadioButton.Name = "SexWomanRadioButton";
            this.SexWomanRadioButton.Size = new System.Drawing.Size(35, 16);
            this.SexWomanRadioButton.TabIndex = 12;
            this.SexWomanRadioButton.TabStop = true;
            this.SexWomanRadioButton.Text = "女";
            this.SexWomanRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(171, 238);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 13;
            this.CreateButton.Text = "添加";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(266, 238);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 23);
            this.Clearbutton.TabIndex = 14;
            this.Clearbutton.Text = "清空";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // CreatePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 283);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SexWomanRadioButton);
            this.Controls.Add(this.SexManRadioButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.TelphoneTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatePatientForm";
            this.Text = "患者信息";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox TelphoneTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.RadioButton SexManRadioButton;
        private System.Windows.Forms.RadioButton SexWomanRadioButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button Clearbutton;
    }
}