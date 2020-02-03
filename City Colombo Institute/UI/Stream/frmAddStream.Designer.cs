namespace City_Colombo_Institute.UI.Stream
{
    partial class frmAddStream
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
            this.dgvStreamDetails = new System.Windows.Forms.DataGridView();
            this.clmStreamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStreamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbtnDeactivate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShortCode = new System.Windows.Forms.TextBox();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStreamDetails)).BeginInit();
            this.SuspendLayout();
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
            this.clmStreamID,
            this.clmStreamName,
            this.clmShortCode,
            this.clmbtnDeactivate});
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
            this.dgvStreamDetails.Location = new System.Drawing.Point(24, 141);
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
            this.dgvStreamDetails.Size = new System.Drawing.Size(388, 211);
            this.dgvStreamDetails.TabIndex = 29;
            this.dgvStreamDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStreamDetails_CellClick);
            // 
            // clmStreamID
            // 
            this.clmStreamID.DataPropertyName = "StreamID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmStreamID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmStreamID.HeaderText = "StreamID";
            this.clmStreamID.Name = "clmStreamID";
            this.clmStreamID.ReadOnly = true;
            this.clmStreamID.Visible = false;
            // 
            // clmStreamName
            // 
            this.clmStreamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmStreamName.DataPropertyName = "StreamName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmStreamName.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmStreamName.HeaderText = "Stream Name";
            this.clmStreamName.Name = "clmStreamName";
            this.clmStreamName.ReadOnly = true;
            this.clmStreamName.Width = 150;
            // 
            // clmShortCode
            // 
            this.clmShortCode.DataPropertyName = "ShortCode";
            this.clmShortCode.HeaderText = "Short Code";
            this.clmShortCode.Name = "clmShortCode";
            this.clmShortCode.ReadOnly = true;
            this.clmShortCode.Width = 150;
            // 
            // clmbtnDeactivate
            // 
            this.clmbtnDeactivate.HeaderText = "Press to Deactivate";
            this.clmbtnDeactivate.Name = "clmbtnDeactivate";
            this.clmbtnDeactivate.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Stream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Short Code";
            // 
            // txtShortCode
            // 
            this.txtShortCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtShortCode.Location = new System.Drawing.Point(166, 79);
            this.txtShortCode.Name = "txtShortCode";
            this.txtShortCode.Size = new System.Drawing.Size(246, 25);
            this.txtShortCode.TabIndex = 61;
            // 
            // txtStream
            // 
            this.txtStream.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStream.Location = new System.Drawing.Point(166, 40);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(246, 25);
            this.txtStream.TabIndex = 60;
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
            this.btnSave.Location = new System.Drawing.Point(345, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 25);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 374);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtShortCode);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvStreamDetails);
            this.Name = "frmAddStream";
            this.Text = "Add Stream";
            this.Load += new System.EventHandler(this.frmAddStream_Load);
            this.Controls.SetChildIndex(this.dgvStreamDetails, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtStream, 0);
            this.Controls.SetChildIndex(this.txtShortCode, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStreamDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStreamDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShortCode;
        private System.Windows.Forms.TextBox txtStream;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStreamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStreamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShortCode;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnDeactivate;
    }
}