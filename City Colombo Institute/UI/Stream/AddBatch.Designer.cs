﻿namespace City_Colombo_Institute.UI.Stream
{
    partial class AddBatch
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
            this.cmbStream = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvStreamDetails = new System.Windows.Forms.DataGridView();
            this.clmBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStreamDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = ":";
            // 
            // cmbStream
            // 
            this.cmbStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStream.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbStream.FormattingEnabled = true;
            this.cmbStream.Location = new System.Drawing.Point(208, 39);
            this.cmbStream.Name = "cmbStream";
            this.cmbStream.Size = new System.Drawing.Size(267, 25);
            this.cmbStream.TabIndex = 26;
            this.cmbStream.SelectionChangeCommitted += new System.EventHandler(this.cmbStream_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Stream";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBatchNo.Location = new System.Drawing.Point(208, 79);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(267, 25);
            this.txtBatchNo.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Batch No.";
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
            this.btnSave.Location = new System.Drawing.Point(408, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 25);
            this.btnSave.TabIndex = 98;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(188, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 17);
            this.label10.TabIndex = 108;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 107;
            this.label11.Text = "Start Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(208, 118);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(267, 20);
            this.dtStartDate.TabIndex = 106;
            // 
            // dgvStreamDetails
            // 
            this.dgvStreamDetails.AllowUserToAddRows = false;
            this.dgvStreamDetails.AllowUserToDeleteRows = false;
            this.dgvStreamDetails.AllowUserToOrderColumns = true;
            this.dgvStreamDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStreamDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStreamDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvStreamDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStreamDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStreamDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStreamDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStreamDetails.ColumnHeadersHeight = 35;
            this.dgvStreamDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStreamDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBatchID,
            this.clmBatchNo,
            this.clmStartDate,
            this.clmbtnEdit});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStreamDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStreamDetails.EnableHeadersVisualStyles = false;
            this.dgvStreamDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStreamDetails.Location = new System.Drawing.Point(17, 177);
            this.dgvStreamDetails.MultiSelect = false;
            this.dgvStreamDetails.Name = "dgvStreamDetails";
            this.dgvStreamDetails.ReadOnly = true;
            this.dgvStreamDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStreamDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStreamDetails.RowHeadersVisible = false;
            this.dgvStreamDetails.RowHeadersWidth = 15;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStreamDetails.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStreamDetails.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStreamDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStreamDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStreamDetails.Size = new System.Drawing.Size(458, 249);
            this.dgvStreamDetails.TabIndex = 109;
            // 
            // clmBatchID
            // 
            this.clmBatchID.DataPropertyName = "BatchID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBatchID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmBatchID.HeaderText = "BatchID";
            this.clmBatchID.Name = "clmBatchID";
            this.clmBatchID.ReadOnly = true;
            this.clmBatchID.Visible = false;
            this.clmBatchID.Width = 150;
            // 
            // clmBatchNo
            // 
            this.clmBatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmBatchNo.DataPropertyName = "BatchNo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBatchNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmBatchNo.HeaderText = "Batch No";
            this.clmBatchNo.Name = "clmBatchNo";
            this.clmBatchNo.ReadOnly = true;
            this.clmBatchNo.Width = 250;
            // 
            // clmStartDate
            // 
            this.clmStartDate.DataPropertyName = "StartDate";
            this.clmStartDate.HeaderText = "Start Date";
            this.clmStartDate.Name = "clmStartDate";
            this.clmStartDate.ReadOnly = true;
            this.clmStartDate.Width = 160;
            // 
            // clmbtnEdit
            // 
            this.clmbtnEdit.HeaderText = "Press to Edit";
            this.clmbtnEdit.Name = "clmbtnEdit";
            this.clmbtnEdit.ReadOnly = true;
            this.clmbtnEdit.Visible = false;
            // 
            // AddBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 444);
            this.Controls.Add(this.dgvStreamDetails);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbStream);
            this.Controls.Add(this.label6);
            this.Name = "AddBatch";
            this.Text = "AddBatch";
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cmbStream, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBatchNo, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.dtStartDate, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dgvStreamDetails, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStreamDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStream;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DataGridView dgvStreamDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnEdit;
    }
}