using BAL;
using Colombo_City_Institute.UI.Common;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Colombo_Institute.UI.Assignment
{
    public partial class AddStudentAssignmentForSubmission : BaseUI
    {
        StudentBAL objStudentBAL;
        AssignmentBAL objAssignmentBAL;
        TeacherBAL objTeacherBAL;
        AssignmentEntity objAssignmentEntity;
        FilePathEntity objFilePathEntity;
        string file = "";
        string FileSavePath = "";
        string MovePath;
        int intAssignmentID;
        string SubjectName;

        public AddStudentAssignmentForSubmission(int intAssignmentID, string SubjectName)
        {
            InitializeComponent();
            this.SetFormName();
            this.intAssignmentID = intAssignmentID;
            this.SubjectName = SubjectName;
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
                else
                {
                    btnBrowse.BackColor = Color.FromArgb(64, 64, 64);
                    btnBrowse.ForeColor = Color.White;
                    btnView.Visible = false;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e) 
        {

            string NewFileSavePath = "";

            NewFileSavePath = FileSavePath + "Assignment_Submit";

            if (!Directory.Exists(NewFileSavePath))
            {
                Directory.CreateDirectory(NewFileSavePath);
            }

            NewFileSavePath = NewFileSavePath + @"\" + SubjectName;

            if (!Directory.Exists(NewFileSavePath))
            {
                Directory.CreateDirectory(NewFileSavePath);
            }


            string[] f = file.Split('\\');
            string fn = f[(f.Length) - 1];
            string dest = NewFileSavePath + "\\" + fn;
            string ext = Path.GetExtension(dest);

            MovePath = NewFileSavePath + @"\" + fn;

            objAssignmentEntity = new AssignmentEntity
            {
                intAssignmentID = Convert.ToInt32(intAssignmentID),
                intStudentID = Convert.ToInt32(Entities.User.StudentID),
                FilePath = MovePath,
                bIsLateSubmission = Convert.ToBoolean(true) //check date late

            };

            DialogResult dr = MessageBox.Show("Are You Sure Submit?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                    objAssignmentBAL = new AssignmentBAL();
                bool result = objAssignmentBAL.saveAssignmentSubmission(objAssignmentEntity);

                if (result == true)
                {

                    if (File.Exists(MovePath))
                    {
                        DialogResult dr1 = MessageBox.Show("This file is already created. Do you want to replace ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                        if (dr1 == DialogResult.Yes)
                        {
                            File.Delete(MovePath);
                            File.Copy(file, dest, true);
                            System.IO.File.Move(dest, MovePath);
                        }
                    }
                    else
                    {
                        File.Copy(file, dest, true);
                        System.IO.File.Move(dest, MovePath);
                    }

                    MessageBox.Show("Assignment save successfully !");
                    this.Hide();
                    clear();
                }
                else
                {
                    MessageBox.Show("Can't save");
                }

            }

        }

        public void clear()
        {
            lblFile.Text = string.Empty;
        }
    }
}
