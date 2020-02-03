namespace City_Colombo_Institute.UI.Student
{
    partial class frmViewStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStream = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvStudentDetails = new System.Windows.Forms.DataGridView();
            this.clmStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStream = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameWithInitials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmbtnDeactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(22, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Batch Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = ":";
            // 
            // cmbBatch
            // 
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBatch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(223, 111);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(267, 25);
            this.cmbBatch.TabIndex = 25;
            this.cmbBatch.SelectionChangeCommitted += new System.EventHandler(this.cmbBatch_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = ":";
            // 
            // cmbStream
            // 
            this.cmbStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStream.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbStream.FormattingEnabled = true;
            this.cmbStream.Location = new System.Drawing.Point(223, 75);
            this.cmbStream.Name = "cmbStream";
            this.cmbStream.Size = new System.Drawing.Size(267, 25);
            this.cmbStream.TabIndex = 23;
            this.cmbStream.SelectionChangeCommitted += new System.EventHandler(this.cmbStream_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Batch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Stream";
            // 
            // dgvStudentDetails
            // 
            this.dgvStudentDetails.AllowUserToAddRows = false;
            this.dgvStudentDetails.AllowUserToDeleteRows = false;
            this.dgvStudentDetails.AllowUserToOrderColumns = true;
            this.dgvStudentDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStudentDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudentDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStudentDetails.ColumnHeadersHeight = 35;
            this.dgvStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStudentID,
            this.clmStream,
            this.clmBatch,
            this.clmFullName,
            this.clmNameWithInitials,
            this.clmAddress,
            this.clmNIC,
            this.clmContactHome,
            this.clmContactMobile,
            this.clmbtnEdit,
            this.clmbtnDeactivate});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentDetails.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStudentDetails.EnableHeadersVisualStyles = false;
            this.dgvStudentDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStudentDetails.Location = new System.Drawing.Point(12, 151);
            this.dgvStudentDetails.MultiSelect = false;
            this.dgvStudentDetails.Name = "dgvStudentDetails";
            this.dgvStudentDetails.ReadOnly = true;
            this.dgvStudentDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStudentDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStudentDetails.RowHeadersVisible = false;
            this.dgvStudentDetails.RowHeadersWidth = 15;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentDetails.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStudentDetails.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudentDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentDetails.Size = new System.Drawing.Size(744, 287);
            this.dgvStudentDetails.TabIndex = 28;
            this.dgvStudentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentDetails_CellClick);
            // 
            // clmStudentID
            // 
            this.clmStudentID.DataPropertyName = "StudentID";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmStudentID.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmStudentID.HeaderText = "StudentID";
            this.clmStudentID.Name = "clmStudentID";
            this.clmStudentID.ReadOnly = true;
            this.clmStudentID.Visible = false;
            // 
            // clmStream
            // 
            this.clmStream.DataPropertyName = "Stream";
            this.clmStream.HeaderText = "Stream ";
            this.clmStream.Name = "clmStream";
            this.clmStream.ReadOnly = true;
            // 
            // clmBatch
            // 
            this.clmBatch.DataPropertyName = "Batch";
            this.clmBatch.HeaderText = "Batch";
            this.clmBatch.Name = "clmBatch";
            this.clmBatch.ReadOnly = true;
            this.clmBatch.Width = 50;
            // 
            // clmFullName
            // 
            this.clmFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmFullName.DataPropertyName = "FullName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmFullName.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmFullName.HeaderText = "Full Name";
            this.clmFullName.Name = "clmFullName";
            this.clmFullName.ReadOnly = true;
            this.clmFullName.Width = 250;
            // 
            // clmNameWithInitials
            // 
            this.clmNameWithInitials.DataPropertyName = "NameWithInitials";
            this.clmNameWithInitials.HeaderText = "Name WithInitials";
            this.clmNameWithInitials.Name = "clmNameWithInitials";
            this.clmNameWithInitials.ReadOnly = true;
            this.clmNameWithInitials.Width = 150;
            // 
            // clmAddress
            // 
            this.clmAddress.DataPropertyName = "Address";
            this.clmAddress.HeaderText = "Address";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            // 
            // clmNIC
            // 
            this.clmNIC.DataPropertyName = "NIC";
            this.clmNIC.HeaderText = "NIC";
            this.clmNIC.Name = "clmNIC";
            this.clmNIC.ReadOnly = true;
            // 
            // clmContactHome
            // 
            this.clmContactHome.DataPropertyName = "ContactHome";
            this.clmContactHome.HeaderText = "Contact Home";
            this.clmContactHome.Name = "clmContactHome";
            this.clmContactHome.ReadOnly = true;
            // 
            // clmContactMobile
            // 
            this.clmContactMobile.DataPropertyName = "ContactMobile";
            this.clmContactMobile.HeaderText = "Contact Mobile";
            this.clmContactMobile.Name = "clmContactMobile";
            this.clmContactMobile.ReadOnly = true;
            // 
            // clmbtnEdit
            // 
            this.clmbtnEdit.HeaderText = "Press to Edit";
            this.clmbtnEdit.Name = "clmbtnEdit";
            this.clmbtnEdit.ReadOnly = true;
            // 
            // clmbtnDeactivate
            // 
            this.clmbtnDeactivate.HeaderText = "Deactivate";
            this.clmbtnDeactivate.Name = "clmbtnDeactivate";
            this.clmbtnDeactivate.ReadOnly = true;
            // 
            // frmViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.dgvStudentDetails);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbStream);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "frmViewStudent";
            this.Text = "View Student ";
            this.Load += new System.EventHandler(this.frmViewStudent_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbStream, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbBatch, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dgvStudentDetails, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStream;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvStudentDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStream;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameWithInitials;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactMobile;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnDeactivate;
    }
}