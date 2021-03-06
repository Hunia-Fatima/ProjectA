﻿namespace ExpandablePanelSample
{
    partial class Advisor
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblDesignationError = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblFNameError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblDOBError = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.dgvAdvisor = new System.Windows.Forms.DataGridView();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.lblSalary = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMain.Controls.Add(this.lblSalary);
            this.pnlMain.Controls.Add(this.numSalary);
            this.pnlMain.Controls.Add(this.cmbDesignation);
            this.pnlMain.Controls.Add(this.dgvAdvisor);
            this.pnlMain.Controls.Add(this.cmdSave);
            this.pnlMain.Controls.Add(this.lblDesignationError);
            this.pnlMain.Controls.Add(this.lblDesignation);
            this.pnlMain.Controls.Add(this.lblFNameError);
            this.pnlMain.Controls.Add(this.lblEmailError);
            this.pnlMain.Controls.Add(this.lblDOBError);
            this.pnlMain.Controls.Add(this.cmdAdd);
            this.pnlMain.Controls.Add(this.cmbGender);
            this.pnlMain.Controls.Add(this.dtpDOB);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblDOB);
            this.pnlMain.Controls.Add(this.lblContact);
            this.pnlMain.Controls.Add(this.lblLName);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.txtContact);
            this.pnlMain.Controls.Add(this.txtLName);
            this.pnlMain.Controls.Add(this.lblFName);
            this.pnlMain.Controls.Add(this.txtFName);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(594, 592);
            this.pnlMain.TabIndex = 67;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(172, 372);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(180, 32);
            this.cmdSave.TabIndex = 84;
            this.cmdSave.Text = "Save Changes";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblDesignationError
            // 
            this.lblDesignationError.AutoSize = true;
            this.lblDesignationError.ForeColor = System.Drawing.Color.Red;
            this.lblDesignationError.Location = new System.Drawing.Point(141, 281);
            this.lblDesignationError.Name = "lblDesignationError";
            this.lblDesignationError.Size = new System.Drawing.Size(75, 13);
            this.lblDesignationError.TabIndex = 83;
            this.lblDesignationError.Text = "Required Field";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(34, 301);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 82;
            this.lblDesignation.Text = "Designation";
            // 
            // lblFNameError
            // 
            this.lblFNameError.AutoSize = true;
            this.lblFNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFNameError.Location = new System.Drawing.Point(146, 12);
            this.lblFNameError.Name = "lblFNameError";
            this.lblFNameError.Size = new System.Drawing.Size(75, 13);
            this.lblFNameError.TabIndex = 80;
            this.lblFNameError.Text = "Required Field";
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(146, 145);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(75, 13);
            this.lblEmailError.TabIndex = 79;
            this.lblEmailError.Text = "Required Field";
            // 
            // lblDOBError
            // 
            this.lblDOBError.AutoSize = true;
            this.lblDOBError.ForeColor = System.Drawing.Color.Red;
            this.lblDOBError.Location = new System.Drawing.Point(146, 192);
            this.lblDOBError.Name = "lblDOBError";
            this.lblDOBError.Size = new System.Drawing.Size(100, 13);
            this.lblDOBError.TabIndex = 78;
            this.lblDOBError.Text = "Invalid Date of Birth";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdd.Location = new System.Drawing.Point(379, 372);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(180, 32);
            this.cmdAdd.TabIndex = 77;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Select",
            "Male",
            "Female"});
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(144, 253);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(415, 21);
            this.cmbGender.TabIndex = 76;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDOB.Location = new System.Drawing.Point(144, 212);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(415, 20);
            this.dtpDOB.TabIndex = 75;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(41, 257);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 74;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(41, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 73;
            this.lblEmail.Text = "Email";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(41, 212);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 72;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(41, 123);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 71;
            this.lblContact.Text = "Contact";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(41, 79);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 70;
            this.lblLName.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(144, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(415, 20);
            this.txtEmail.TabIndex = 69;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.Location = new System.Drawing.Point(144, 119);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(415, 20);
            this.txtContact.TabIndex = 68;
            // 
            // txtLName
            // 
            this.txtLName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLName.Location = new System.Drawing.Point(144, 76);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(415, 20);
            this.txtLName.TabIndex = 67;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(41, 33);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 66;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFName.Location = new System.Drawing.Point(144, 31);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(415, 20);
            this.txtFName.TabIndex = 65;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // dgvAdvisor
            // 
            this.dgvAdvisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdvisor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAdvisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvisor.Location = new System.Drawing.Point(3, 410);
            this.dgvAdvisor.Name = "dgvAdvisor";
            this.dgvAdvisor.Size = new System.Drawing.Size(588, 179);
            this.dgvAdvisor.TabIndex = 85;
            this.dgvAdvisor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdvisor_CellContentClick);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDesignation.AutoCompleteCustomSource.AddRange(new string[] {
            "Select",
            "Male",
            "Female"});
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.cmbDesignation.Location = new System.Drawing.Point(143, 297);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(415, 21);
            this.cmbDesignation.TabIndex = 86;
            this.cmbDesignation.SelectedIndexChanged += new System.EventHandler(this.cmbDesignation_SelectedIndexChanged);
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(145, 337);
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(414, 20);
            this.numSalary.TabIndex = 87;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(40, 343);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 88;
            this.lblSalary.Text = "Salary";
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 616);
            this.Controls.Add(this.pnlMain);
            this.Name = "Advisor";
            this.Text = "Advisor";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.DataGridView dgvAdvisor;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblDesignationError;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblFNameError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblDOBError;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
    }
}