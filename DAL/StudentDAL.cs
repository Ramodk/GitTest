using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Common;
using Entities;
using Entities.Enums;

namespace DAL
{
    public class StudentDAL
    {
        public DataTable GetAllStreams()
        {
     
            try
            {
                Execute objExecute = new Execute();
                DataTable dt = (DataTable)objExecute.Executes("spGetAllStreams", ReturnType.DataTable, CommandType.StoredProcedure);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetStreamWiseBatches(int StreamID)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
              {
                    Execute.AddParameter("@StreamID",StreamID)
              };

                return (DataTable)objExecute.Executes("spGetStreamWiseBatches", ReturnType.DataTable, param, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetStudentDetails(int batchID , int streamID)
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetStudentDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@BatchID",Convert.ToInt32(batchID)),
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

        public bool saveStudent(StudentEntity objStudentEntity)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {
          
                    Execute.AddParameter("@NameWithInitials",objStudentEntity.NameWithInitials),
                    Execute.AddParameter("@FullName",objStudentEntity.FullName),
                    Execute.AddParameter("@NIC",objStudentEntity.NIC),
                    Execute.AddParameter("@Address",objStudentEntity.Address),
                    Execute.AddParameter("@ContactHome",objStudentEntity.ContactHome),
                    Execute.AddParameter("@ContactMobile",objStudentEntity.ContactMobile),
                    Execute.AddParameter("@intStreamID",objStudentEntity.intStreamID),
                    Execute.AddParameter("@intBatchID",objStudentEntity.BatchID)
                };

                 objExecute.Executes("spSaveStudent", param, CommandType.StoredProcedure);
               
                    return true;
                
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetSubjects(int streamID)
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetSubject]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@streamID",Convert.ToInt32(streamID)),
                  
                  };
                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeactivateStudent(int studentID)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {
                     Execute.AddParameter("@StudentID",studentID),
                };
                objExecute.Executes("spDeactivateStudent", param, CommandType.StoredProcedure);

                return true;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool updateStudent(StudentEntity objStudentEntity)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {
                    Execute.AddParameter("@StudentID",objStudentEntity.StudentID),
                    Execute.AddParameter("@NameWithInitials",objStudentEntity.NameWithInitials),
                    Execute.AddParameter("@FullName",objStudentEntity.FullName),
                    Execute.AddParameter("@NIC",objStudentEntity.NIC),
                    Execute.AddParameter("@Address",objStudentEntity.Address),
                    Execute.AddParameter("@ContactHome",objStudentEntity.ContactHome),
                    Execute.AddParameter("@ContactMobile",objStudentEntity.ContactMobile),
                    Execute.AddParameter("@intStreamID",objStudentEntity.intStreamID),
                    Execute.AddParameter("@intBatchID",objStudentEntity.BatchID),
                    Execute.AddParameter("@intCurrentBatchID",objStudentEntity.CurrentBatchID)

                };

               objExecute.Executes("spUpdateStudent", param, CommandType.StoredProcedure);
    
                    return true;
             
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet GetOneStudentDetails(int studentID)
        {
            DataSet ds = new DataSet();
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
              {
                    Execute.AddParameter("@StudentID",studentID)
              };

                ds = (DataSet)objExecute.Executes("spGetOneStudentDetails", ReturnType.DataSet, param, CommandType.StoredProcedure);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
