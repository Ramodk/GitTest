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
    public class StreamBAL
    {
        StreamDAL objStreamDAL;

        public List<StreamEntity> GetStreamDetails()
        {
            List<StreamEntity> DetailsList = new List<StreamEntity>();
            objStreamDAL = new StreamDAL();

            DataTable dt = objStreamDAL.GetStreamDetails();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    StreamEntity objStream = new StreamEntity
                    {
                        StreamID = Convert.ToInt32(dr["StreamID"]),
                        StreamName = dr["StreamName"].ToString(),
                        ShortCode = dr["ShortCode"].ToString(),
                        IsActive = Convert.ToBoolean(dr["IsActive"]),

                    };
                    DetailsList.Add(objStream);
                }
            }
            return DetailsList;
        }

        public DataTable GetTeacherStream(int TeacherID)
        {
            StreamDAL objStream = new StreamDAL();
            return objStream.GetTeacherStream(TeacherID);
        }

        public bool UpdateSubject(int SubjectID, string SubjectName)
        {
            StreamDAL objStream = new StreamDAL();
            return objStream.UpdateSubject(SubjectID, SubjectName);
        }

        public bool SaveSubject(int StreamID, string SubjectName)
        {
            StreamDAL objStream = new StreamDAL();
            return objStream.SaveSubject(StreamID, SubjectName);
        }

        public bool SaveStream(string StreamName, string ShortCode)
        {
            StreamDAL objStream = new StreamDAL();
            return objStream.SaveStream(StreamName, ShortCode);
        }

        public bool DeactivateStream(int streamID)
        {
            objStreamDAL = new StreamDAL();
            return objStreamDAL.DeactivateStream(streamID);
        }
    }
}
