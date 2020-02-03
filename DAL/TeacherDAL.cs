using DAL.Common;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TeacherDAL
    {

        public bool saveTeacher(TeacherEntity objTecherEntity)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param= new SqlParameter[]
            {
                    Execute.AddParameter("@vcFName",objTecherEntity.FName),
                    Execute.AddParameter("@vcLName",objTecherEntity.LName),
                    Execute.AddParameter("@vcAddress",objTecherEntity.Address),
                    Execute.AddParameter("@intContactNo",objTecherEntity.ContactNo)
            };

                int TeacherID = objExecute.ExecuteIdentity("spSaveTeacher", param, CommandType.StoredProcedure); ;

                foreach (SubjectEntity item in objTecherEntity.lstSubjectEntity)
                {
                    SqlParameter[] paramX = new SqlParameter[]
                 {
                    Execute.AddParameter("@TeacherID",TeacherID),
                    Execute.AddParameter("@SubjectID",item.SubjectID)
                 };
                    objExecute.Executes("spSaveTeacherSubjects", paramX, CommandType.StoredProcedure);
                }

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetTeacherDetailsForSubjectWise(int subjectID)
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetTeacherDetailsForSubjectWise]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intSubjectID",Convert.ToInt32(subjectID)),
             
                  };
                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetTeacherSubject(int teacherID, int streamID)
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetTeacherDetailsForStreamWise]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@teacherID",Convert.ToInt32(teacherID)),
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

        public bool DeactivateTeacher(int teacherID)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {
                     Execute.AddParameter("@teacherID",teacherID),
                };
                objExecute.Executes("spDeactivateTeacher", param, CommandType.StoredProcedure);

                return true;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UpdateTeacher(TeacherEntity objTecherEntity)
        {
            try
            {
                    Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
            {
                     Execute.AddParameter("@TeacherID",objTecherEntity.TeacherID),
                    Execute.AddParameter("@FirstName",objTecherEntity.FName),
                    Execute.AddParameter("@LastName",objTecherEntity.LName),
                    Execute.AddParameter("@Address",objTecherEntity.Address),
                    Execute.AddParameter("@ContactNo",objTecherEntity.ContactNo)
            };

               
                    objExecute.Executes("spUpdateTeacher", param, CommandType.StoredProcedure);

                SqlParameter[] paramZX = new SqlParameter[]
            {
                    Execute.AddParameter("@TeacherID",objTecherEntity.TeacherID)
            };

                objExecute.Executes("DELETE FROM TeacherSubject WHERE intTeacherID = @TeacherID", paramZX, CommandType.Text);

                foreach (SubjectEntity item in objTecherEntity.lstSubjectEntity)
                {
                    SqlParameter[] paramX = new SqlParameter[]
                 {
                    Execute.AddParameter("@TeacherID",objTecherEntity.TeacherID),
                    Execute.AddParameter("@SubjectID",item.SubjectID)
                 };
                    objExecute.Executes("spSaveTeacherSubjects", paramX, CommandType.StoredProcedure);
                }


                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetStreamWiseSubjet(int StreamID)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
              {
                    Execute.AddParameter("@StreamID",StreamID)
              };

                return (DataTable)objExecute.Executes("spGetStreamWiseSubject", ReturnType.DataTable, param, CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
        public TeacherEntity GetTeacherDetails(int TeacherID)
        {
            TeacherEntity obj = new TeacherEntity();


            DataSet ds = new DataSet();
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
              {
                    Execute.AddParameter("@TeacherID",TeacherID)
              };

                ds = (DataSet)objExecute.Executes("spGetTeacherDetails", ReturnType.DataSet, param, CommandType.StoredProcedure);

                     
                    obj.FName = ds.Tables[0].Rows[0]["vcFName"].ToString();
                    obj.LName = ds.Tables[0].Rows[0]["vcLName"].ToString();
                    obj.Address = ds.Tables[0].Rows[0]["vcAddress"].ToString();
                    obj.ContactNo = Convert.ToInt32(ds.Tables[0].Rows[0]["intContactNo"].ToString());

                SqlParameter[] paramX = new SqlParameter[]
                {
                    Execute.AddParameter("@TeacherID",TeacherID)
                };

                DataTable dt = (DataTable)objExecute.Executes("spGetTeacherSubject", ReturnType.DataTable, paramX, CommandType.StoredProcedure);
                obj.lstSubjectEntity = new List<SubjectEntity>();
                foreach (DataRow dr in dt.Rows)
                {
                    SubjectEntity objSubject = new SubjectEntity();
                    objSubject.SubjectID = Convert.ToInt32(dr["intSubjectID"]);
                    objSubject.SubjectName = dr["SubjectName"].ToString();
                    obj.lstSubjectEntity.Add(objSubject);
                }

                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
