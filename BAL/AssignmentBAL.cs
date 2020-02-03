using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BAL
{
    public class AssignmentBAL
    {
        AssignmentDAL objAssignmentDAL;

        public List<AssignmentEntity> GetAssignmentDetails()
        {
            List<AssignmentEntity> DetailsList = new List<AssignmentEntity>();
            objAssignmentDAL = new AssignmentDAL();

            DataTable dt = objAssignmentDAL.GetAssignmentDetails();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    AssignmentEntity objAssignment = new AssignmentEntity
                    {
                        intAssignmentID = Convert.ToInt32(dr["intAssignmentID"]),
                        vcTitle = dr["vcTitle"].ToString(),
                        vcRemarks = dr["vcRemarks"].ToString(),
                        dtGivenDate = Convert.ToDateTime(dr["dtGivenDate"]),
                        dtSubmissionDate = Convert.ToDateTime(dr["dtSubmissionDate"]),
                        SubmitedDate = dr["SubmitedDate"].ToString(),
                        SubjectName = dr["SubjectName"].ToString(),
                        FilePath = dr["vcSavePath"].ToString(),
                        IsSubmited = Convert.ToBoolean(dr["IsSubmited"])


                    };
                    DetailsList.Add(objAssignment);
                }
            }

            return DetailsList;
        }

        public List<AssignmentEntity> GetAssignmentDeatilsForSubjectWise(int intSubjectID)
        {
            List<AssignmentEntity> DetailsList = new List<AssignmentEntity>();
            objAssignmentDAL = new AssignmentDAL();

            DataTable dt = objAssignmentDAL.GetAssignmentDeatilsForSubjectWise(intSubjectID);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    AssignmentEntity objAssignment = new AssignmentEntity
                    {
                        intAssignmentID = Convert.ToInt32(dr["intAssignmentID"]),
                        intSubjectID = Convert.ToInt32(dr["intSubjectID"]),
                        vcTitle = dr["vcTitle"].ToString(),
                        vcRemarks = dr["vcRemarks"].ToString(),
                        FilePath = dr["vcSavePath"].ToString(),
                        dtGivenDate = Convert.ToDateTime(dr["dtGivenDate"]),
                        dtSubmissionDate = Convert.ToDateTime(dr["dtSubmissionDate"]),


                    };
                    DetailsList.Add(objAssignment);
                }
            }

            return DetailsList;
        }

        public DataTable GetSubjectForStudentWise(int UserID)
        {
            objAssignmentDAL = new AssignmentDAL();
            return objAssignmentDAL.GetSubjectForStudentWise(UserID);
        }

        public string GetFilePath(int FilePathID)
        {
            objAssignmentDAL = new AssignmentDAL();
            return objAssignmentDAL.GetFilePath(FilePathID);
        }

        public DataTable GetBatchDetailsForStreamWise(int StreamID)
        {
            objAssignmentDAL = new AssignmentDAL();
            return objAssignmentDAL.GetBatchDetailsForStreamWise(StreamID);
        }

        public bool SaveBatch(int StreamID, string BatchNo, DateTime StartDate)
        {
            AssignmentDAL objAssignmentDAL = new AssignmentDAL();
            return objAssignmentDAL.SaveBatch(StreamID, BatchNo, StartDate);
        }

        public bool saveAssignmentSubmission(AssignmentEntity objAssignmentEntity)
        {
            AssignmentDAL objAssignmentDAL = new AssignmentDAL();
            return objAssignmentDAL.saveAssignmentSubmission(objAssignmentEntity);
        }

        public bool saveAssignment(AssignmentEntity objAssignmentEntity)
        {
            AssignmentDAL objAssignmentDAL = new AssignmentDAL();
            return objAssignmentDAL.saveAssignment(objAssignmentEntity);
        }
    }
}
