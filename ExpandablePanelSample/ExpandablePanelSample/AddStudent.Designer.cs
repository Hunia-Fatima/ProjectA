namespace ExpandablePanelSample
{
    partial class AddStudent
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
            this.lblRegNoError = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMain.Controls.Add(this.cmdSave);
            this.pnlMain.Controls.Add(this.lblRegNoError);
            this.pnlMain.Controls.Add(this.lblRegNo);
            this.pnlMain.Controls.Add(this.txtRegNo);
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
            this.pnlMain.Size = new System.Drawing.Size(580, 377);
            this.pnlMain.TabIndex = 65;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(144, 330);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(180, 32);
            this.cmdSave.TabIndex = 84;
            this.cmdSave.Text = "Save Changes";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblRegNoError
            // 
            this.lblRegNoError.AutoSize = true;
            this.lblRegNoError.ForeColor = System.Drawing.Color.Red;
            this.lblRegNoError.Location = new System.Drawing.Point(141, 281);
            this.lblRegNoError.Name = "lblRegNoError";
            this.lblRegNoError.Size = new System.Drawing.Size(75, 13);
            this.lblRegNoError.TabIndex = 83;
            this.lblRegNoError.Text = "Required Field";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(34, 301);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(103, 13);
            this.lblRegNo.TabIndex = 82;
            this.lblRegNo.Text = "Registration Number";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegNo.Location = new System.Drawing.Point(144, 299);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(401, 20);
            this.txtRegNo.TabIndex = 81;
            this.txtRegNo.TextChanged += new System.EventHandler(this.txtRegNo_TextChanged);
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
            this.cmdAdd.Location = new System.Drawing.Point(365, 330);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(180, 32);
            this.cmdAdd.TabIndex = 77;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
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
            this.cmbGender.Size = new System.Drawing.Size(401, 21);
            this.cmbGender.TabIndex = 76;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDOB.Location = new System.Drawing.Point(144, 212);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(401, 20);
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
            this.txtEmail.Size = new System.Drawing.Size(401, 20);
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
            this.txtContact.Size = new System.Drawing.Size(401, 20);
            this.txtContact.TabIndex = 68;
            // 
            // txtLName
            // 
            this.txtLName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLName.Location = new System.Drawing.Point(144, 76);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(401, 20);
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
            this.txtFName.Size = new System.Drawing.Size(401, 20);
            this.txtFName.TabIndex = 65;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged_1);
            // 
            // dgvStudent
            // 
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(12, 395);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(580, 149);
            this.dgvStudent.TabIndex = 66;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick_1);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 544);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.pnlMain);
            this.MinimumSize = new System.Drawing.Size(442, 453);
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblRegNoError;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtRegNo;
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
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button cmdSave;
    }
}