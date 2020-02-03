namespace City_Colombo_Institute.UI
{
    partial class TeacherMainMenu
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
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnViewAssignmnet = new System.Windows.Forms.Button();
            this.btnCreateAssignment = new System.Windows.Forms.Button();
            this.btnAssignmentMarking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.Location = new System.Drawing.Point(535, 52);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(31, 17);
            this.lblTeacherName.TabIndex = 57;
            this.lblTeacherName.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Teacher Name";
            // 
            // btnViewAssignmnet
            // 
            this.btnViewAssignmnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.btnViewAssignmnet.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAssignmnet.ForeColor = System.Drawing.Color.White;
            this.btnViewAssignmnet.Location = new System.Drawing.Point(423, 105);
            this.btnViewAssignmnet.Name = "btnViewAssignmnet";
            this.btnViewAssignmnet.Size = new System.Drawing.Size(200, 200);
            this.btnViewAssignmnet.TabIndex = 59;
            this.btnViewAssignmnet.Text = "View Assignment";
            this.btnViewAssignmnet.UseVisualStyleBackColor = false;
            this.btnViewAssignmnet.Click += new System.EventHandler(this.btnViewAssignmnet_Click);
            // 
            // btnCreateAssignment
            // 
            this.btnCreateAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.btnCreateAssignment.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAssignment.ForeColor = System.Drawing.Color.White;
            this.btnCreateAssignment.Location = new System.Drawing.Point(12, 105);
            this.btnCreateAssignment.Name = "btnCreateAssignment";
            this.btnCreateAssignment.Size = new System.Drawing.Size(200, 200);
            this.btnCreateAssignment.TabIndex = 58;
            this.btnCreateAssignment.Text = "Create Assignment";
            this.btnCreateAssignment.UseVisualStyleBackColor = false;
            this.btnCreateAssignment.Click += new System.EventHandler(this.btnCreateAssignment_Click);
            // 
            // btnAssignmentMarking
            // 
            this.btnAssignmentMarking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.btnAssignmentMarking.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignmentMarking.ForeColor = System.Drawing.Color.White;
            this.btnAssignmentMarking.Location = new System.Drawing.Point(218, 105);
            this.btnAssignmentMarking.Name = "btnAssignmentMarking";
            this.btnAssignmentMarking.Size = new System.Drawing.Size(200, 200);
            this.btnAssignmentMarking.TabIndex = 60;
            this.btnAssignmentMarking.Text = "Assignment Marking";
            this.btnAssignmentMarking.UseVisualStyleBackColor = false;
            this.btnAssignmentMarking.Click += new System.EventHandler(this.btnAssignmentMarking_Click);
            // 
            // TeacherMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 363);
            this.Controls.Add(this.btnAssignmentMarking);
            this.Controls.Add(this.btnViewAssignmnet);
            this.Controls.Add(this.btnCreateAssignment);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Name = "TeacherMainMenu";
            this.Text = "Teacher Main Menu";
            this.Load += new System.EventHandler(this.TeacherMainMenu_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblTeacherName, 0);
            this.Controls.SetChildIndex(this.btnCreateAssignment, 0);
            this.Controls.SetChildIndex(this.btnViewAssignmnet, 0);
            this.Controls.SetChildIndex(this.btnAssignmentMarking, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnViewAssignmnet;
        private System.Windows.Forms.Button btnCreateAssignment;
        private System.Windows.Forms.Button btnAssignmentMarking;
    }
}