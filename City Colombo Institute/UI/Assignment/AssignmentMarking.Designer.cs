namespace City_Colombo_Institute.UI.Assignment
{
    partial class AssignmentMarking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStream = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAssignmentDetails = new System.Windows.Forms.DataGridView();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.rbtComplete = new System.Windows.Forms.RadioButton();
            this.rbtPending = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.clmAssignmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsSubmited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubmittedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(152, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 103;
            this.label9.Text = ":";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(169, 76);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(267, 25);
            this.cmbSubject.TabIndex = 102;
            this.cmbSubject.SelectionChangeCommitted += new System.EventHandler(this.cmbSubject_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 101;
            this.label8.Text = ":";
            // 
            // cmbStream
            // 
            this.cmbStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStream.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbStream.FormattingEnabled = true;
            this.cmbStream.Location = new System.Drawing.Point(169, 40);
            this.cmbStream.Name = "cmbStream";
            this.cmbStream.Size = new System.Drawing.Size(267, 25);
            this.cmbStream.TabIndex = 100;
            this.cmbStream.SelectionChangeCommitted += new System.EventHandler(this.cmbStream_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 99;
            this.label7.Text = "Subject";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 98;
            this.label10.Text = "Stream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = ":";
            // 
            // cmbBatch
            // 
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBatch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(169, 115);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(267, 25);
            this.cmbBatch.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "Batch No";
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
            this.clmSubject,
            this.clmTitle,
            this.clmView,
            this.clmFilePath,
            this.clmIsSubmited,
            this.clmSubmittedDate,
            this.clmMarks,
            this.clmGrade});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignmentDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAssignmentDetails.EnableHeadersVisualStyles = false;
            this.dgvAssignmentDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAssignmentDetails.Location = new System.Drawing.Point(25, 156);
            this.dgvAssignmentDetails.MultiSelect = false;
            this.dgvAssignmentDetails.Name = "dgvAssignmentDetails";
            this.dgvAssignmentDetails.ReadOnly = true;
            this.dgvAssignmentDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAssignmentDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAssignmentDetails.RowHeadersVisible = false;
            this.dgvAssignmentDetails.RowHeadersWidth = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAssignmentDetails.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAssignmentDetails.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAssignmentDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAssignmentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignmentDetails.Size = new System.Drawing.Size(750, 245);
            this.dgvAssignmentDetails.TabIndex = 107;
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.Checked = true;
            this.rbtAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAll.Location = new System.Drawing.Point(550, 114);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(43, 21);
            this.rbtAll.TabIndex = 110;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "All";
            this.rbtAll.UseVisualStyleBackColor = true;
            // 
            // rbtComplete
            // 
            this.rbtComplete.AutoSize = true;
            this.rbtComplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtComplete.Location = new System.Drawing.Point(599, 114);
            this.rbtComplete.Name = "rbtComplete";
            this.rbtComplete.Size = new System.Drawing.Size(93, 21);
            this.rbtComplete.TabIndex = 109;
            this.rbtComplete.Text = "Completed";
            this.rbtComplete.UseVisualStyleBackColor = true;
            // 
            // rbtPending
            // 
            this.rbtPending.AutoSize = true;
            this.rbtPending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPending.Location = new System.Drawing.Point(698, 114);
            this.rbtPending.Name = "rbtPending";
            this.rbtPending.Size = new System.Drawing.Size(77, 21);
            this.rbtPending.TabIndex = 108;
            this.rbtPending.Text = "Pending";
            this.rbtPending.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(700, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // clmAssignmentID
            // 
            this.clmAssignmentID.DataPropertyName = "StudentID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmAssignmentID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmAssignmentID.HeaderText = "StudentID";
            this.clmAssignmentID.Name = "clmAssignmentID";
            this.clmAssignmentID.ReadOnly = true;
            this.clmAssignmentID.Visible = false;
            // 
            // clmSubject
            // 
            this.clmSubject.DataPropertyName = "Student No";
            this.clmSubject.HeaderText = "Student No";
            this.clmSubject.Name = "clmSubject";
            this.clmSubject.ReadOnly = true;
            this.clmSubject.Width = 150;
            // 
            // clmTitle
            // 
            this.clmTitle.DataPropertyName = "Student Name";
            this.clmTitle.HeaderText = "Student Name";
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            this.clmTitle.Width = 150;
            // 
            // clmView
            // 
            this.clmView.HeaderText = "View";
            this.clmView.Name = "clmView";
            this.clmView.ReadOnly = true;
            this.clmView.Width = 50;
            // 
            // clmFilePath
            // 
            this.clmFilePath.DataPropertyName = "FilePath";
            this.clmFilePath.HeaderText = "FilePath";
            this.clmFilePath.Name = "clmFilePath";
            this.clmFilePath.ReadOnly = true;
            this.clmFilePath.Visible = false;
            this.clmFilePath.Width = 200;
            // 
            // clmIsSubmited
            // 
            this.clmIsSubmited.DataPropertyName = "IsSubmited";
            this.clmIsSubmited.HeaderText = "IsSubmited";
            this.clmIsSubmited.Name = "clmIsSubmited";
            this.clmIsSubmited.ReadOnly = true;
            this.clmIsSubmited.Visible = false;
            // 
            // clmSubmittedDate
            // 
            this.clmSubmittedDate.HeaderText = "Submitted Date";
            this.clmSubmittedDate.Name = "clmSubmittedDate";
            this.clmSubmittedDate.ReadOnly = true;
            this.clmSubmittedDate.Width = 150;
            // 
            // clmMarks
            // 
            this.clmMarks.HeaderText = "Mark";
            this.clmMarks.Name = "clmMarks";
            this.clmMarks.ReadOnly = true;
            this.clmMarks.Width = 150;
            // 
            // clmGrade
            // 
            this.clmGrade.HeaderText = "Grade";
            this.clmGrade.Name = "clmGrade";
            this.clmGrade.ReadOnly = true;
            // 
            // AssignmentMarking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbtAll);
            this.Controls.Add(this.rbtComplete);
            this.Controls.Add(this.rbtPending);
            this.Controls.Add(this.dgvAssignmentDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbStream);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Name = "AssignmentMarking";
            this.Text = "AssignmentMarking";
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbStream, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbSubject, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbBatch, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvAssignmentDetails, 0);
            this.Controls.SetChildIndex(this.rbtPending, 0);
            this.Controls.SetChildIndex(this.rbtComplete, 0);
            this.Controls.SetChildIndex(this.rbtAll, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStream;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAssignmentDetails;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.RadioButton rbtComplete;
        private System.Windows.Forms.RadioButton rbtPending;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssignmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsSubmited;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubmittedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrade;
    }
}