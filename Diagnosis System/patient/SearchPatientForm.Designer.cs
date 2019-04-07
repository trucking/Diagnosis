namespace Diagnosis_System.patient
{
    partial class SearchPatientForm
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ConsultationDataGridView = new System.Windows.Forms.DataGridView();
            this.DiagnosisTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Illness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Management = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchTextBox.Location = new System.Drawing.Point(85, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(109, 30);
            this.SearchTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchButton.Location = new System.Drawing.Point(220, 18);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "查找";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "住址";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(86, 72);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 12);
            this.NameLabel.TabIndex = 7;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(86, 108);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(0, 12);
            this.SexLabel.TabIndex = 8;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(86, 145);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(0, 12);
            this.AgeLabel.TabIndex = 9;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(85, 182);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(0, 12);
            this.AddressLabel.TabIndex = 10;
            // 
            // ConsultationDataGridView
            // 
            this.ConsultationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiagnosisTime,
            this.Illness,
            this.Management,
            this.Cost});
            this.ConsultationDataGridView.Location = new System.Drawing.Point(199, 92);
            this.ConsultationDataGridView.Name = "ConsultationDataGridView";
            this.ConsultationDataGridView.RowTemplate.Height = 23;
            this.ConsultationDataGridView.Size = new System.Drawing.Size(589, 350);
            this.ConsultationDataGridView.TabIndex = 11;
            // 
            // DiagnosisTime
            // 
            this.DiagnosisTime.DataPropertyName = "consultationdate";
            this.DiagnosisTime.HeaderText = "就诊时间";
            this.DiagnosisTime.Name = "DiagnosisTime";
            // 
            // Illness
            // 
            this.Illness.DataPropertyName = "illness";
            this.Illness.HeaderText = "症状";
            this.Illness.Name = "Illness";
            this.Illness.Width = 150;
            // 
            // Management
            // 
            this.Management.DataPropertyName = "management";
            this.Management.HeaderText = "处置措施";
            this.Management.Name = "Management";
            this.Management.Width = 200;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "cost";
            this.Cost.HeaderText = "费用";
            this.Cost.Name = "Cost";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "新增就诊记录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "就诊记录";
            // 
            // SearchPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ConsultationDataGridView);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "SearchPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "就诊人员信息";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.DataGridView ConsultationDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Illness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Management;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Label label6;
    }
}