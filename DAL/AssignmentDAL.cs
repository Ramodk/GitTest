using DAL.Common;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AssignmentDAL
    {
        public DataTable GetAssignmentDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetAssignmentDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {


                  };
                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetBatchDetailsForStreamWise(int streamID)
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetBatchDetailsForStreamWise]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@StreamID",Convert.ToInt32(streamID)),

                  };
                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool SaveBatch(int streamID, string batchNo, DateTime startDate)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {

                    Execute.AddParameter("@StreamID",Convert.ToInt32(streamID)),
                    Execute.AddParameter("@BatchNo",batchNo),
                    Execute.AddParameter("@StartDate",startDate),

                };

                objExecute.Executes("spSaveBatch", param, CommandType.StoredProcedure);

                return true;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAssignmentDeatilsForSubjectWise(int intSubjectID)
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetAssignmentDeatilsForSubjectWise]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intSubjectID",Convert.ToInt32(intSubjectID)),

                  };
                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetSubjectForStudentWise(int UserID)
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spSubjectForStudentWise]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@StudentID",Convert.ToInt32(UserID)),

                  };
                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool saveAssignment(AssignmentEntity objAssignmentEntity)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {

                   
                    Execute.AddParameter("@intSubjectID",objAssignmentEntity.intSubjectID),
                    Execute.AddParameter("@BatchID",objAssignmentEntity.BatchID),
                    Execute.AddParameter("@vcTitle",objAssignmentEntity.vcTitle),
                    Execute.AddParameter("@vcRemarks",objAssignmentEntity.vcRemarks),
                    Execute.AddParameter("@dtSubmissionDate",objAssignmentEntity.dtSubmissionDate),
                    Execute.AddParameter("@FilePath",objAssignmentEntity.FilePath),

                };

                objExecute.Executes("spSaveAssignment", param, CommandType.StoredProcedure);

                return true;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool saveAssignmentSubmission(AssignmentEntity objAssignmentEntity)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {


                    Execute.AddParameter("@intAssignmentID",objAssignmentEntity.intAssignmentID),
                    Execute.AddParameter("@intStudentID",Entities.User.StudentID),
                    Execute.AddParameter("@FilePath",objAssignmentEntity.FilePath),
                    Execute.AddParameter("@bIsLateSubmission",objAssignmentEntity.bIsLateSubmission),


                };

                objExecute.Executes("spSaveAssignmentSubmit", param, CommandType.StoredProcedure);

                return true;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetFilePath(int FilePathID)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
          {

                    Execute.AddParameter("@FilePathID",Convert.ToInt32(FilePathID))
          };
                string Query = "[dbo].[spGetFilePath]";

                DataRow dr = (DataRow)objExecute.Executes(Query, ReturnType.DataRow,param, CommandType.StoredProcedure);

               return dr["vcFilePath"].ToString();
          
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
