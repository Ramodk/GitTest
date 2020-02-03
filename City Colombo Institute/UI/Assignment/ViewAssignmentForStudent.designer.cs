namespace City_Colombo_Institute.UI.Assignment
{
    partial class ViewAssignmentForStudent
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
            this.dgvAssignmentDetails = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStream = new System.Windows.Forms.Label();
            this.rbtPending = new System.Windows.Forms.RadioButton();
            this.rbtComplete = new System.Windows.Forms.RadioButton();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.rbtLate = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clmAssignmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGivenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsSubmited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentDetails)).BeginInit();
            this.SuspendLayout();
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
            this.clmRemark,
            this.clmGivenDate,
            this.clmSubmissionDate,
            this.clmView,
            this.clmFilePath,
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
            this.dgvAssignmentDetails.Location = new System.Drawing.Point(12, 137);
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
            this.dgvAssignmentDetails.Size = new System.Drawing.Size(785, 300);
            this.dgvAssignmentDetails.TabIndex = 37;
            this.dgvAssignmentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignmentDetails_CellClick);
            this.dgvAssignmentDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAssignmentDetails_DataBindingComplete);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Student No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Stream";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNo.Location = new System.Drawing.Point(120, 36);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(31, 17);
            this.lblStudentNo.TabIndex = 44;
            this.lblStudentNo.Text = "N/A";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(120, 67);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(31, 17);
            this.lblStudentName.TabIndex = 45;
            this.lblStudentName.Text = "N/A";
            // 
            // lblStream
            // 
            this.lblStream.AutoSize = true;
            this.lblStream.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStream.Location = new System.Drawing.Point(120, 98);
            this.lblStream.Name = "lblStream";
            this.lblStream.Size = new System.Drawing.Size(31, 17);
            this.lblStream.TabIndex = 46;
            this.lblStream.Text = "N/A";
            // 
            // rbtPending
            // 
            this.rbtPending.AutoSize = true;
            this.rbtPending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPending.Location = new System.Drawing.Point(657, 98);
            this.rbtPending.Name = "rbtPending";
            this.rbtPending.Size = new System.Drawing.Size(77, 21);
            this.rbtPending.TabIndex = 47;
            this.rbtPending.Text = "Pending";
            this.rbtPending.UseVisualStyleBackColor = true;
            this.rbtPending.CheckedChanged += new System.EventHandler(this.rbtPending_CheckedChanged);
            // 
            // rbtComplete
            // 
            this.rbtComplete.AutoSize = true;
            this.rbtComplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtComplete.Location = new System.Drawing.Point(558, 98);
            this.rbtComplete.Name = "rbtComplete";
            this.rbtComplete.Size = new System.Drawing.Size(93, 21);
            this.rbtComplete.TabIndex = 48;
            this.rbtComplete.Text = "Completed";
            this.rbtComplete.UseVisualStyleBackColor = true;
            this.rbtComplete.CheckedChanged += new System.EventHandler(this.rbtComplete_CheckedChanged);
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.Checked = true;
            this.rbtAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAll.Location = new System.Drawing.Point(509, 98);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(43, 21);
            this.rbtAll.TabIndex = 49;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "All";
            this.rbtAll.UseVisualStyleBackColor = true;
            this.rbtAll.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
            // 
            // rbtLate
            // 
            this.rbtLate.AutoSize = true;
            this.rbtLate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtLate.Location = new System.Drawing.Point(745, 98);
            this.rbtLate.Name = "rbtLate";
            this.rbtLate.Size = new System.Drawing.Size(52, 21);
            this.rbtLate.TabIndex = 50;
            this.rbtLate.Text = "Late";
            this.rbtLate.UseVisualStyleBackColor = true;
            this.rbtLate.CheckedChanged += new System.EventHandler(this.rbtLate_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(41, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 82;
            this.label10.Text = "Completed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(56)))));
            this.panel9.Location = new System.Drawing.Point(15, 454);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(20, 20);
            this.panel9.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(149, 457);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 84;
            this.label11.Text = "Pending";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(115)))), ((int)(((byte)(88)))));
            this.panel1.Location = new System.Drawing.Point(123, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(240, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 15);
            this.label12.TabIndex = 86;
            this.label12.Text = "Late";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(214, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 85;
            // 
            // clmAssignmentID
            // 
            this.clmAssignmentID.DataPropertyName = "AssignmentID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmAssignmentID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmAssignmentID.HeaderText = "AssignmentID";
            this.clmAssignmentID.Name = "clmAssignmentID";
            this.clmAssignmentID.ReadOnly = true;
            this.clmAssignmentID.Visible = false;
            // 
            // clmSubject
            // 
            this.clmSubject.DataPropertyName = "SubjectName";
            this.clmSubject.HeaderText = "Subject";
            this.clmSubject.Name = "clmSubject";
            this.clmSubject.ReadOnly = true;
            this.clmSubject.Width = 150;
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
            // clmSubmissionDate
            // 
            this.clmSubmissionDate.DataPropertyName = "dtSubmissionDate";
            this.clmSubmissionDate.HeaderText = "Submission Date";
            this.clmSubmissionDate.Name = "clmSubmissionDate";
            this.clmSubmissionDate.ReadOnly = true;
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
            // ViewAssignmentForStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 496);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.rbtLate);
            this.Controls.Add(this.rbtAll);
            this.Controls.Add(this.rbtComplete);
            this.Controls.Add(this.rbtPending);
            this.Controls.Add(this.lblStream);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAssignmentDetails);
            this.Name = "ViewAssignmentForStudent";
            this.Text = "View Assignment";
            this.Controls.SetChildIndex(this.dgvAssignmentDetails, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblStudentNo, 0);
            this.Controls.SetChildIndex(this.lblStudentName, 0);
            this.Controls.SetChildIndex(this.lblStream, 0);
            this.Controls.SetChildIndex(this.rbtPending, 0);
            this.Controls.SetChildIndex(this.rbtComplete, 0);
            this.Controls.SetChildIndex(this.rbtAll, 0);
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

        private System.Windows.Forms.DataGridView dgvAssignmentDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtPending;
        private System.Windows.Forms.RadioButton rbtComplete;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.RadioButton rbtLate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssignmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGivenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubmissionDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsSubmited;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStream;
    }
}