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
    public class TeacherBAL
    {
        TeacherDAL objTeacherDAL;

        public bool saveTeacher(TeacherEntity objTecherEntity)
        {
            objTeacherDAL = new TeacherDAL();
            return objTeacherDAL.saveTeacher(objTecherEntity);
        }

        public DataTable GetAllStreams()
        {

            objTeacherDAL = new TeacherDAL();
            return objTeacherDAL.GetAllStreams();
        }

        public DataTable GetStreamWiseSubject(int StreamID)
        {
            objTeacherDAL = new TeacherDAL();
            return objTeacherDAL.GetStreamWiseSubjet(StreamID);
        }

        public TeacherEntity GetTeacherDetails(int TeacherID)
        {
            objTeacherDAL = new TeacherDAL();
            return objTeacherDAL.GetTeacherDetails(TeacherID);
        }

        public List<TeacherEntity> GetTeacherDetailsForSubjectWise(int SubjectID)
        {
            List<TeacherEntity> DetailsList = new List<TeacherEntity>();
            objTeacherDAL = new TeacherDAL();

            DataTable dt = objTeacherDAL.GetTeacherDetailsForSubjectWise(SubjectID);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TeacherEntity objTecher = new TeacherEntity
                    {
                        TeacherID = Convert.ToInt32(dr["intTeacherID"]),
                        FName = dr["vcFName"].ToString(),
                        LName = dr["vcLName"].ToString(),
                        Address = dr["vcAddress"].ToString(),
                        ContactNo = Convert.ToInt32(dr["intContactNo"]),
                      
                    };
                    DetailsList.Add(objTecher);
                }
            }

            return DetailsList;
        }

        public DataTable GetTeacherSubject(int TeacherID, int StreamID)
        {
            objTeacherDAL = new TeacherDAL();
            return objTeacherDAL.GetTeacherSubject(TeacherID, StreamID);
        }

        public bool DeactivateTeacher(int teacherID)
        {
            objTeacherDAL = new TeacherDAL();
            return objTeacherDAL.DeactivateTeacher(teacherID);
        }

        public bool UpdateTeacher(TeacherEntity objTecherEntity)
        {
            objTeacherDAL = new TeacherDAL();
            return objTeacherDAL.UpdateTeacher(objTecherEntity);
        }
    }
}
