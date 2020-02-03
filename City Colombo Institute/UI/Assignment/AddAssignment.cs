using BAL;
using Colombo_City_Institute.UI.Common;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Colombo_Institute.UI.Assignment
{
    public partial class AddAssignment : BaseUI
    {
        StudentBAL objStudentBAL;
        AssignmentBAL objAssignmentBAL;
        TeacherBAL objTeacherBAL;
        AssignmentEntity objAssignmentEntity;
        FilePathEntity objFilePathEntity;
        string file = "";
        string FileSavePath = "";
        string MovePath;
        //private string SavePath = @"D:\";

        public AddAssignment()
        {
            InitializeComponent();
            this.SetFormName();
            GetAllStreams();
            FileSavePath = GetFileSavePath(1);
        }

        private string GetFileSavePath(int FilePathID)
        {
            objAssignmentBAL = new AssignmentBAL();
           return objAssignmentBAL.GetFilePath(FilePathID);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;

                if (file != "")
                {
                    btnBrowse.BackColor = Color.FromArgb(248, 205, 60);
                    btnBrowse.ForeColor = Color.Black;
                    btnView.Visible = true;
                    string[] f = file.Split('\\');
                    string fn = f[(f.Length) - 1];
                    lblFile.Text = fn;
                }
                else {
                    btnBrowse.BackColor = Color.FromArgb(64, 64, 64);
                    btnBrowse.ForeColor = Color.White;
                    btnView.Visible = false;
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string NewFileSavePath = "";
            NewFileSavePath = FileSavePath + "Assignment";

            if (!Directory.Exists(FileSavePath + "Assignment"))
            {
                Directory.CreateDirectory(NewFileSavePath);
            }

            //NewFileSavePath = FileSavePath + "Assignment";
            NewFileSavePath = NewFileSavePath + @"\" + cmbStream.Text.Trim();


            if (!Directory.Exists(NewFileSavePath + @"\" + cmbStream.Text.Trim()))
            {
                Directory.CreateDirectory(NewFileSavePath);
            }

            //NewFileSavePath = NewFileSavePath + @"\" + cmbStream.Text.Trim();
            NewFileSavePath = NewFileSavePath + @"\" + cmbBatch.Text.Trim();

            if (!Directory.Exists(NewFileSavePath + @"\" + cmbBatch.Text.Trim()))
            {
                Directory.CreateDirectory(NewFileSavePath);
            }

            //NewFileSavePath = NewFileSavePath + @"\" + cmbBatch.Text.Trim();
            NewFileSavePath = NewFileSavePath + @"\" + cmbSubject.Text.Trim();

            if (!Directory.Exists(NewFileSavePath + @"\" + cmbSubject.Text.Trim()))
            {
                Directory.CreateDirectory(NewFileSavePath);
            }

            //NewFileSavePath = NewFileSavePath + @"\" + cmbSubject.Text.Trim();


            string[] f = file.Split('\\');
            string fn = f[(f.Length) - 1];
            string dest = NewFileSavePath +"\\"+ fn;
            string ext = Path.GetExtension(dest);

            MovePath = NewFileSavePath + @"\" + txtTitle.Text.Trim() + ext;

            objAssignmentEntity = new AssignmentEntity
            {
                intStreamID = Convert.ToInt32(cmbStream.SelectedValue),
                intSubjectID = Convert.ToInt32(cmbSubject.SelectedValue),
                BatchID = Convert.ToInt32(cmbBatch.SelectedValue),
                vcTitle = txtTitle.Text.Trim(),
                vcRemarks = txtRemark.Text.Trim(),
                dtSubmissionDate = Convert.ToDateTime(dtSubmissionDate.Value),
                FilePath = MovePath

            };

            objAssignmentBAL = new AssignmentBAL();
            bool result = objAssignmentBAL.saveAssignment(objAssignmentEntity);

            if (result == true)
            {
               
                if (File.Exists(MovePath))
                {
                    DialogResult dr = MessageBox.Show("This file is already created. Do you want to replace ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        File.Delete(MovePath);
                        File.Copy(file, dest, true);
                        System.IO.File.Move(dest, MovePath);
                    }
                }
                else {
                    File.Copy(file, dest, true);
                    System.IO.File.Move(dest, MovePath);
                }

                MessageBox.Show("Assignment save successfully !");
                clear();
            }
            else
            {
                MessageBox.Show("Can't save");

            }

        }
        public void clear()
        {
            cmbStream.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            cmbBatch.SelectedIndex = -1;
            txtTitle.Text = string.Empty;
            txtRemark.Text = string.Empty;
        }

        private void GetAllStreams()
        {
            objStudentBAL = new StudentBAL();
            DataTable dt = objStudentBAL.GetAllStreams();
            cmbStream.DataSource = dt;
            cmbStream.DisplayMember = "StreamName";
            cmbStream.ValueMember = "StreamID";
            cmbStream.SelectedIndex = -1;
        }

        public void GetStreamWiseSubject()
        {
            objTeacherBAL = new TeacherBAL();
            DataTable dt = objTeacherBAL.GetStreamWiseSubject(Convert.ToInt32(cmbStream.SelectedValue));
            cmbSubject.DataSource = dt;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStreamWiseSubject();
            GetStreamWiseBatches();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            System.Diagnostics.Process.Start(file);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }
        public void GetStreamWiseBatches()
        {
            objStudentBAL = new StudentBAL();
            DataTable dt = objStudentBAL.GetStreamWiseBatches(Convert.ToInt32(cmbStream.SelectedValue));
            cmbBatch.DataSource = dt;
            cmbBatch.DisplayMember = "BatchNo";
            cmbBatch.ValueMember = "BatchID";
            cmbBatch.SelectedIndex = -1;
        }
    }
}
