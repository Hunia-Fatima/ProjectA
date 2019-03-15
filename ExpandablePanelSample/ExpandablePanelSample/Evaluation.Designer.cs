namespace ExpandablePanelSample
{
    partial class Evaluation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.dgvEvaluation = new System.Windows.Forms.DataGridView();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblWeigtage = new System.Windows.Forms.Label();
            this.NumMarks = new System.Windows.Forms.NumericUpDown();
            this.NumWeightage = new System.Windows.Forms.NumericUpDown();
            this.lblWeightageError = new System.Windows.Forms.Label();
            this.lblMarksError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWeightage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lblNameError);
            this.panel1.Controls.Add(this.lblMarksError);
            this.panel1.Controls.Add(this.lblWeightageError);
            this.panel1.Controls.Add(this.NumWeightage);
            this.panel1.Controls.Add(this.NumMarks);
            this.panel1.Controls.Add(this.lblWeigtage);
            this.panel1.Controls.Add(this.lblMarks);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.dgvEvaluation);
            this.panel1.Controls.Add(this.cmdAdd);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 401);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(76, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAdd.Location = new System.Drawing.Point(350, 154);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dgvEvaluation
            // 
            this.dgvEvaluation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvaluation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEvaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluation.Location = new System.Drawing.Point(3, 183);
            this.dgvEvaluation.Name = "dgvEvaluation";
            this.dgvEvaluation.Size = new System.Drawing.Size(437, 215);
            this.dgvEvaluation.TabIndex = 3;
            this.dgvEvaluation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvaluation_CellContentClick);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(196, 154);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(99, 23);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save Changes";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(14, 80);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(36, 13);
            this.lblMarks.TabIndex = 6;
            this.lblMarks.Text = "Marks";
            // 
            // lblWeigtage
            // 
            this.lblWeigtage.AutoSize = true;
            this.lblWeigtage.Location = new System.Drawing.Point(11, 121);
            this.lblWeigtage.Name = "lblWeigtage";
            this.lblWeigtage.Size = new System.Drawing.Size(59, 13);
            this.lblWeigtage.TabIndex = 8;
            this.lblWeigtage.Text = "Weightage";
            // 
            // NumMarks
            // 
            this.NumMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumMarks.Location = new System.Drawing.Point(76, 75);
            this.NumMarks.Name = "NumMarks";
            this.NumMarks.Size = new System.Drawing.Size(349, 20);
            this.NumMarks.TabIndex = 9;
            // 
            // NumWeightage
            // 
            this.NumWeightage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumWeightage.Location = new System.Drawing.Point(76, 119);
            this.NumWeightage.Name = "NumWeightage";
            this.NumWeightage.Size = new System.Drawing.Size(349, 20);
            this.NumWeightage.TabIndex = 10;
            // 
            // lblWeightageError
            // 
            this.lblWeightageError.AutoSize = true;
            this.lblWeightageError.ForeColor = System.Drawing.Color.Red;
            this.lblWeightageError.Location = new System.Drawing.Point(73, 103);
            this.lblWeightageError.Name = "lblWeightageError";
            this.lblWeightageError.Size = new System.Drawing.Size(75, 13);
            this.lblWeightageError.TabIndex = 11;
            this.lblWeightageError.Text = "Required Field";
            // 
            // lblMarksError
            // 
            this.lblMarksError.AutoSize = true;
            this.lblMarksError.ForeColor = System.Drawing.Color.Red;
            this.lblMarksError.Location = new System.Drawing.Point(73, 59);
            this.lblMarksError.Name = "lblMarksError";
            this.lblMarksError.Size = new System.Drawing.Size(75, 13);
            this.lblMarksError.TabIndex = 12;
            this.lblMarksError.Text = "Required Field";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(73, 15);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(75, 13);
            this.lblNameError.TabIndex = 13;
            this.lblNameError.Text = "Required Field";
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 425);
            this.Controls.Add(this.panel1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWeightage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEvaluation;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.NumericUpDown NumWeightage;
        private System.Windows.Forms.NumericUpDown NumMarks;
        private System.Windows.Forms.Label lblWeigtage;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblMarksError;
        private System.Windows.Forms.Label lblWeightageError;
    }
}