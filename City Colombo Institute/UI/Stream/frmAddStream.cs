using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using Colombo_City_Institute.UI.Common;
using Entities;

namespace City_Colombo_Institute.UI.Stream
{
    public partial class frmAddStream : BaseUI
    {
        StreamBAL objStreamBAL;
        public int StreamID;

        public frmAddStream()
        {
            InitializeComponent();
            this.SetFormName();
        }

        public void GetStreamDetails()
        {
            objStreamBAL = new StreamBAL();
            List<StreamEntity> listStreamDetails = new List<StreamEntity>();
            listStreamDetails = objStreamBAL.GetStreamDetails();

            dgvStreamDetails.DataSource = null;
            dgvStreamDetails.AutoGenerateColumns = false;
            dgvStreamDetails.DataSource = listStreamDetails;
        }

        private void frmAddStream_Load(object sender, EventArgs e)
        {
            GetStreamDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStream.Text.Trim() == "")
            {
                MessageBox.Show("Please enter stream !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtShortCode.Text.Trim() == "")
            {
                MessageBox.Show("Please enter short code !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure Want to add New Stream ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objStreamBAL = new StreamBAL();
                    bool result = objStreamBAL.SaveStream(txtStream.Text.ToString(), txtShortCode.Text.ToString());

                    if (result == true)
                    {
                        GetStreamDetails();
                        MessageBox.Show("Stream added successfully !");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error !");
                        Clear();
                    }
                }
            }
        }
        public void Clear()
        {
            txtStream.Text = string.Empty;
            txtShortCode.Text = string.Empty;
        }

        private void dgvStreamDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStreamDetails.Columns[e.ColumnIndex] == clmbtnDeactivate)
            {
               
                DialogResult dr = MessageBox.Show("Are you sure want to deactivate in this stream ?", "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objStreamBAL = new StreamBAL();
                    StreamID = Convert.ToInt32(dgvStreamDetails.Rows[e.RowIndex].Cells[clmStreamID.Name].Value);
                    bool result = objStreamBAL.DeactivateStream(StreamID);

                    if (result)
                    {
                        GetStreamDetails();
                        MessageBox.Show("Successfully Deactivated !");

                    }
                    else
                    {
                        MessageBox.Show("Stream Deactivate Process Error !");
                    }
                }
            }
        }
    }
}
