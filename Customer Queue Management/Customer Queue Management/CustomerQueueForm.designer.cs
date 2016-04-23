namespace Customer_Queue_Managment
{
    partial class CustomerQueueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerQueueForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTXT = new System.Windows.Forms.TextBox();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.completeBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typeShowTXT = new System.Windows.Forms.TextBox();
            this.nameShowTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionShowTXT = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serviceListDataGridView = new System.Windows.Forms.DataGridView();
            this.serialShowTXT = new System.Windows.Forms.TextBox();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.saveBTN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.descriptionTXT);
            this.groupBox1.Controls.Add(this.nameTXT);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Service";
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(228, 75);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 3;
            this.saveBTN.Text = "Add Queue";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // descriptionTXT
            // 
            this.descriptionTXT.Location = new System.Drawing.Point(73, 40);
            this.descriptionTXT.Multiline = true;
            this.descriptionTXT.Name = "descriptionTXT";
            this.descriptionTXT.Size = new System.Drawing.Size(230, 33);
            this.descriptionTXT.TabIndex = 2;
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(73, 17);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(86, 20);
            this.nameTXT.TabIndex = 0;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Charger",
            "SIM",
            "Others"});
            this.typeComboBox.Location = new System.Drawing.Point(205, 16);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(98, 21);
            this.typeComboBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.completeBTN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.typeShowTXT);
            this.groupBox2.Controls.Add(this.serialShowTXT);
            this.groupBox2.Controls.Add(this.nameShowTXT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.descriptionShowTXT);
            this.groupBox2.Location = new System.Drawing.Point(323, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Running Service";
            // 
            // completeBTN
            // 
            this.completeBTN.Location = new System.Drawing.Point(232, 74);
            this.completeBTN.Name = "completeBTN";
            this.completeBTN.Size = new System.Drawing.Size(75, 23);
            this.completeBTN.TabIndex = 3;
            this.completeBTN.Text = "Complete";
            this.completeBTN.UseVisualStyleBackColor = true;
            this.completeBTN.Click += new System.EventHandler(this.completeBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Description";
            // 
            // typeShowTXT
            // 
            this.typeShowTXT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.typeShowTXT.Location = new System.Drawing.Point(209, 16);
            this.typeShowTXT.Name = "typeShowTXT";
            this.typeShowTXT.ReadOnly = true;
            this.typeShowTXT.Size = new System.Drawing.Size(98, 20);
            this.typeShowTXT.TabIndex = 1;
            // 
            // nameShowTXT
            // 
            this.nameShowTXT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nameShowTXT.Location = new System.Drawing.Point(77, 16);
            this.nameShowTXT.Name = "nameShowTXT";
            this.nameShowTXT.ReadOnly = true;
            this.nameShowTXT.Size = new System.Drawing.Size(86, 20);
            this.nameShowTXT.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Serial No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // descriptionShowTXT
            // 
            this.descriptionShowTXT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.descriptionShowTXT.Location = new System.Drawing.Point(77, 39);
            this.descriptionShowTXT.Multiline = true;
            this.descriptionShowTXT.Name = "descriptionShowTXT";
            this.descriptionShowTXT.ReadOnly = true;
            this.descriptionShowTXT.Size = new System.Drawing.Size(230, 33);
            this.descriptionShowTXT.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.serviceListDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 192);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Services";
            // 
            // serviceListDataGridView
            // 
            this.serviceListDataGridView.AllowUserToAddRows = false;
            this.serviceListDataGridView.AllowUserToDeleteRows = false;
            this.serviceListDataGridView.AllowUserToResizeColumns = false;
            this.serviceListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.serviceListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.CustomerName,
            this.Type,
            this.description});
            this.serviceListDataGridView.Location = new System.Drawing.Point(11, 21);
            this.serviceListDataGridView.Name = "serviceListDataGridView";
            this.serviceListDataGridView.ReadOnly = true;
            this.serviceListDataGridView.Size = new System.Drawing.Size(607, 160);
            this.serviceListDataGridView.TabIndex = 0;
            // 
            // serialShowTXT
            // 
            this.serialShowTXT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.serialShowTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialShowTXT.ForeColor = System.Drawing.SystemColors.Info;
            this.serialShowTXT.Location = new System.Drawing.Point(77, 75);
            this.serialShowTXT.Name = "serialShowTXT";
            this.serialShowTXT.ReadOnly = true;
            this.serialShowTXT.Size = new System.Drawing.Size(86, 20);
            this.serialShowTXT.TabIndex = 1;
            this.serialShowTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SerialNo
            // 
            this.SerialNo.DataPropertyName = "SerialNo";
            this.SerialNo.HeaderText = "Serial";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Width = 40;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 107;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "ServiceType";
            this.Type.HeaderText = "Type of Service";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 110;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "Service Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 307;
            // 
            // CustomerQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(652, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerQueueForm";
            this.Text = "Customer Queue Management";
            this.Load += new System.EventHandler(this.CustomerQueueForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTXT;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button completeBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionShowTXT;
        private System.Windows.Forms.TextBox typeShowTXT;
        private System.Windows.Forms.TextBox nameShowTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView serviceListDataGridView;
        private System.Windows.Forms.TextBox serialShowTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}

