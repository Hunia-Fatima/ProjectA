namespace ExpandablePanelSample
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblDesignationError = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.dgvAdvisor = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvisor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMain.Controls.Add(this.dgvAdvisor);
            this.pnlMain.Controls.Add(this.numericUpDown1);
            this.pnlMain.Controls.Add(this.cmdSave);
            this.pnlMain.Controls.Add(this.lblDesignationError);
            this.pnlMain.Controls.Add(this.cmdAdd);
            this.pnlMain.Controls.Add(this.cmbDesignation);
            this.pnlMain.Controls.Add(this.lblSalary);
            this.pnlMain.Controls.Add(this.lblDesignation);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(622, 425);
            this.pnlMain.TabIndex = 67;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(149, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(443, 20);
            this.numericUpDown1.TabIndex = 85;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(237, 124);
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
            this.lblDesignationError.Location = new System.Drawing.Point(146, 9);
            this.lblDesignationError.Name = "lblDesignationError";
            this.lblDesignationError.Size = new System.Drawing.Size(75, 13);
            this.lblDesignationError.TabIndex = 80;
            this.lblDesignationError.Text = "Required Field";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdd.Location = new System.Drawing.Point(423, 124);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(180, 32);
            this.cmdAdd.TabIndex = 77;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
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
            this.cmbDesignation.Location = new System.Drawing.Point(149, 29);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(443, 21);
            this.cmbDesignation.TabIndex = 76;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(41, 79);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 70;
            this.lblSalary.Text = "Salary";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(41, 33);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 66;
            this.lblDesignation.Text = "Designation";
            // 
            // dgvAdvisor
            // 
            this.dgvAdvisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdvisor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAdvisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvisor.Location = new System.Drawing.Point(3, 186);
            this.dgvAdvisor.Name = "dgvAdvisor";
            this.dgvAdvisor.Size = new System.Drawing.Size(616, 236);
            this.dgvAdvisor.TabIndex = 86;
            this.dgvAdvisor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 449);
            this.Controls.Add(this.pnlMain);
            this.Name = "Advisor";
            this.Text = "Advisor";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblDesignationError;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.DataGridView dgvAdvisor;
    }
}