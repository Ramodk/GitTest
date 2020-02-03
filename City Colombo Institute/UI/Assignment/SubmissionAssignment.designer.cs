namespace City_Colombo_Institute.UI.Assignment
{
    partial class SubmissionAssignment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAssignmentDetails = new System.Windows.Forms.DataGridView();
            this.rbtLate = new System.Windows.Forms.RadioButton();
            this.rbtPending = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.clmAssignmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGivenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmSubmit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmIsSubmited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = ":";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(89, 35);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(267, 25);
            this.cmbSubject.TabIndex = 32;
            this.cmbSubject.SelectionChangeCommitted += new System.EventHandler(this.cmbSubject_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Subject ";
            // 
            // dgvAssignmentDetails
            // 
            this.dgvAssignmentDetails.AllowUserToAddRows = false;
            this.dgvAssignmentDetails.AllowUserToDeleteRows = false;
            this.dgvAssignmentDetails.AllowUserToOrderColumns = true;
            this.dgvAssignmentDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAssignmentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignmentDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignmentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignmentDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignmentDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignmentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignmentDetails.ColumnHeadersHeight = 35;
            this.dgvAssignmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAssignmentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAssignmentID,
            this.clmTitle,
            this.clmRemark,
            this.clmFilePath,
            this.clmGivenDate,
            this.clmView,
            this.clmSubmit,
            this.clmIsSubmited});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignmentDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAssignmentDetails.EnableHeadersVisualStyles = false;
            this.dgvAssignmentDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignmentDetails.Location = new System.Drawing.Point(11, 66);
            this.dgvAssignmentDetails.MultiSelect = false;
            this.dgvAssignmentDetails.Name = "dgvAssignmentDetails";
            this.dgvAssignmentDetails.ReadOnly = true;
            this.dgvAssignmentDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssignmentDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAssignmentDetails.RowHeadersVisible = false;
            this.dgvAssignmentDetails.RowHeadersWidth = 15;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAssignmentDetails.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAssignmentDetails.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAssignmentDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAssignmentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignmentDetails.Size = new System.Drawing.Size(638, 377);
            this.dgvAssignmentDetails.TabIndex = 38;
            this.dgvAssignmentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignmentDetails_CellClick);
            // 
            // rbtLate
            // 
            this.rbtLate.AutoSize = true;
            this.rbtLate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtLate.Location = new System.Drawing.Point(554, 39);
            this.rbtLate.Name = "rbtLate";
            this.rbtLate.Size = new System.Drawing.Size(52, 21);
            this.rbtLate.TabIndex = 54;
            this.rbtLate.Text = "Late";
            this.rbtLate.UseVisualStyleBackColor = true;
            // 
            // rbtPending
            // 
            this.rbtPending.AutoSize = true;
            this.rbtPending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPending.Location = new System.Drawing.Point(409, 38);
            this.rbtPending.Name = "rbtPending";
            this.rbtPending.Size = new System.Drawing.Size(77, 21);
            this.rbtPending.TabIndex = 51;
            this.rbtPending.Text = "Pending";
            this.rbtPending.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(236, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 15);
            this.label12.TabIndex = 92;
            this.label12.Text = "Late";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(210, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(145, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 90;
            this.label11.Text = "Pending";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(115)))), ((int)(((byte)(88)))));
            this.panel1.Location = new System.Drawing.Point(119, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(37, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 88;
            this.label10.Text = "Completed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(56)))));
            this.panel9.Location = new System.Drawing.Point(11, 449);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(20, 20);
            this.panel9.TabIndex = 87;
            // 
            // clmAssignmentID
            // 
            this.clmAssignmentID.DataPropertyName = "intAssignmentID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmAssignmentID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmAssignmentID.HeaderText = "AssignmentID";
            this.clmAssignmentID.Name = "clmAssignmentID";
            this.clmAssignmentID.ReadOnly = true;
            this.clmAssignmentID.Visible = false;
            // 
            // clmTitle
            // 
            this.clmTitle.DataPropertyName = "vcTitle";
            this.clmTitle.HeaderText = "Title";
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            this.clmTitle.Width = 150;
            // 
            // clmRemark
            // 
            this.clmRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmRemark.DataPropertyName = "vcRemarks";
            this.clmRemark.HeaderText = "Remark";
            this.clmRemark.Name = "clmRemark";
            this.clmRemark.ReadOnly = true;
            // 
            // clmFilePath
            // 
            this.clmFilePath.DataPropertyName = "FilePath";
            this.clmFilePath.HeaderText = "FilePath";
            this.clmFilePath.Name = "clmFilePath";
            this.clmFilePath.ReadOnly = true;
            this.clmFilePath.Visible = false;
            // 
            // clmGivenDate
            // 
            this.clmGivenDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmGivenDate.DataPropertyName = "dtGivenDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmGivenDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmGivenDate.HeaderText = "Given Date";
            this.clmGivenDate.Name = "clmGivenDate";
            this.clmGivenDate.ReadOnly = true;
            // 
            // clmView
            // 
            this.clmView.HeaderText = "View";
            this.clmView.Name = "clmView";
            this.clmView.ReadOnly = true;
            this.clmView.Width = 50;
            // 
            // clmSubmit
            // 
            this.clmSubmit.HeaderText = "Submit";
            this.clmSubmit.Name = "clmSubmit";
            this.clmSubmit.ReadOnly = true;
            // 
            // clmIsSubmited
            // 
            this.clmIsSubmited.DataPropertyName = "IsSubmited";
            this.clmIsSubmited.HeaderText = "IsSubmited";
            this.clmIsSubmited.Name = "clmIsSubmited";
            this.clmIsSubmited.ReadOnly = true;
            this.clmIsSubmited.Visible = false;
            // 
            // SubmissionAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 485);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.rbtLate);
            this.Controls.Add(this.rbtPending);
            this.Controls.Add(this.dgvAssignmentDetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label6);
            this.Name = "SubmissionAssignment";
            this.Text = "Submission Assignment";
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cmbSubject, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dgvAssignmentDetails, 0);
            this.Controls.SetChildIndex(this.rbtPending, 0);
            this.Controls.SetChildIndex(this.rbtLate, 0);
            this.Controls.SetChildIndex(this.panel9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvAssignmentDetails;
        private System.Windows.Forms.RadioButton rbtLate;
        private System.Windows.Forms.RadioButton rbtPending;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssignmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGivenDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewButtonColumn clmSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsSubmited;
    }
}