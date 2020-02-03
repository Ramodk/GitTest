using DAL.Common;
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
    public class StreamDAL
    {
        public DataTable GetStreamDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetAllStreams]";
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

        public bool SaveSubject(int streamID, string subjectName)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {

                    Execute.AddParameter("@StreamID",streamID),
                    Execute.AddParameter("@subjectName",subjectName),
                
                };

                objExecute.Executes("spSaveSubject", param, CommandType.StoredProcedure);

                return true;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateSubject(int SubjectID, string SubjectName)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {

                    Execute.AddParameter("@SubjectID",SubjectID),
                    Execute.AddParameter("@SubjectName",SubjectName),

                };

                objExecute.Executes("spUpdateSubject", param, CommandType.StoredProcedure);

                return true;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveStream(string streamName, string shortCode)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {

                    Execute.AddParameter("@streamName",streamName),
                    Execute.AddParameter("@shortCode",shortCode),

                };

                objExecute.Executes("spSaveStream", param, CommandType.StoredProcedure);

                return true;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeactivateStream(int streamID)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {
                     Execute.AddParameter("@StreamID",streamID),
                };
                objExecute.Executes("spDeactivateStream", param, CommandType.StoredProcedure);

                return true;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataTable GetTeacherStream(int teacherID)
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetTeacherStream]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intTeacherID",Convert.ToInt32(teacherID)),

                  };
                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
