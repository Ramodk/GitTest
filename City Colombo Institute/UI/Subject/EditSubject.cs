using BAL;
using Colombo_City_Institute.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Colombo_Institute.UI.Subject
{
    public partial class EditSubject : BaseUI
    {
        StreamBAL objStreamBAL;
        int SubjectID;

        public EditSubject(int SubjectID)
        {
            InitializeComponent();
            this.SetFormName();
            this.SubjectID = SubjectID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Subject !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure Want to Edit Subject ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objStreamBAL = new StreamBAL();
                    bool result = objStreamBAL.UpdateSubject(Convert.ToInt32(SubjectID), txtSubject.Text.ToString());

                    if (result == true)
                    {
                        MessageBox.Show("Subject Updated successfully !");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error !");
                    }
                }
            }
        }

    }
}
