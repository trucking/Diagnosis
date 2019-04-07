namespace Diagnosis_System.consultation
{
    partial class CreateConsultationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.IllnessTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ManageMentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(81, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 12);
            this.NameLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "日期";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(83, 40);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(277, 21);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.Value = new System.DateTime(2019, 4, 7, 20, 50, 23, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "症状";
            // 
            // IllnessTextBox
            // 
            this.IllnessTextBox.Location = new System.Drawing.Point(83, 85);
            this.IllnessTextBox.Name = "IllnessTextBox";
            this.IllnessTextBox.Size = new System.Drawing.Size(277, 21);
            this.IllnessTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "处置措施";
            // 
            // ManageMentTextBox
            // 
            this.ManageMentTextBox.Location = new System.Drawing.Point(83, 134);
            this.ManageMentTextBox.Name = "ManageMentTextBox";
            this.ManageMentTextBox.Size = new System.Drawing.Size(277, 21);
            this.ManageMentTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "费用";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(83, 180);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 21);
            this.CostTextBox.TabIndex = 9;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(83, 259);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "添加";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(214, 258);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "清除";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 326);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ManageMentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IllnessTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateConsultationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加处置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IllnessTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ManageMentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ClearButton;
    }
}