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
    public class StudentBAL
    {
        StudentDAL objStudentDAL;

        public DataTable GetAllStreams()
        {
            objStudentDAL = new StudentDAL();
            return objStudentDAL.GetAllStreams();
        }

        public DataTable GetStreamWiseBatches(int StreamID)
        {
            objStudentDAL = new StudentDAL();
            return objStudentDAL.GetStreamWiseBatches(StreamID);
        }

        public bool saveStudent(StudentEntity objStudentEntity)
        {
            objStudentDAL = new StudentDAL();
            return objStudentDAL.saveStudent(objStudentEntity);
        }

        public List<StudentEntity> GetStudentDetails(int batchID, int streamID)
        {
            List<StudentEntity> DetailsList = new List<StudentEntity>();
            objStudentDAL = new StudentDAL();

            DataTable dt = objStudentDAL.GetStudentDetails(batchID, streamID);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    StudentEntity objStu = new StudentEntity
                    {
                        Batch = dr["BatchNo"].ToString(),
                        Stream = dr["StreamName"].ToString(),
                        StudentID = Convert.ToInt32(dr["StudentID"]),
                        NameWithInitials = dr["NameWithInitials"].ToString(),
                        FullName = dr["FullName"].ToString(),
                        Address = dr["Address"].ToString(),
                        ContactHome = Convert.ToInt32(dr["ContactHome"]),
                        ContactMobile = Convert.ToInt32(dr["ContactMobile"]),
                        intStreamID = Convert.ToInt32(dr["intStreamID"]),
                        BatchID = Convert.ToInt32(dr["intBatchID"]),
                        NIC = dr["NIC"].ToString(),
                    };
                    DetailsList.Add(objStu);
                }
            }

            return DetailsList; 
        }

        public DataTable GetSubjects(int StreamID)
        {
            objStudentDAL = new StudentDAL();
            return objStudentDAL.GetSubjects(StreamID);
        }

        public bool updateStudent(StudentEntity objStudentEntity)
        {
            objStudentDAL = new StudentDAL();
            return objStudentDAL.updateStudent(objStudentEntity);
        }

        public DataSet GetOneStudentDetails(int studentID)
        {
            objStudentDAL = new StudentDAL();
            return objStudentDAL.GetOneStudentDetails(studentID);
        }

        public bool DeactivateStudent(int studentID)
        {
            objStudentDAL = new StudentDAL();
            return objStudentDAL.DeactivateStudent(studentID);
        }
    }       
}
