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
    public class UserDAL
    {
        public bool CreateUser(UserEntity obj)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {
                    Execute.AddParameter("@UserName",obj.UserName),
                    Execute.AddParameter("@Password",obj.Password),
                    Execute.AddParameter("@UserGroupID",obj.UserGroupID),
                    Execute.AddParameter("@IsSuperUser",obj.IsSuperUser)
                };

                objExecute.Executes("spCreateUser", param, CommandType.StoredProcedure);
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUserGroups()
        {
            try
            {
                Execute objExecute = new Execute();
                DataTable dt = (DataTable)objExecute.Executes("spGetUserGroups", ReturnType.DataTable, CommandType.StoredProcedure);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataRow CheckUserAccount(string userName, string password)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
              {
                    Execute.AddParameter("@UserName",userName),
                     Execute.AddParameter("@Password",password)
              };

                DataRow dr = (DataRow)objExecute.Executes("spCheckUserAccount", ReturnType.DataRow, param, CommandType.StoredProcedure);

                if (dr != null)
                {
                    User.UserID = Convert.ToInt32(dr["UserID"]);
                    User.UserName = dr["UserName"].ToString();
                    User.UserGroupID = Convert.ToInt32(dr["UserGroupID"]);
                    User.StudentNo = dr["StudentCode"].ToString();
                    User.StudentName = dr["NameWithInitials"].ToString();
                    User.Stream = dr["StreamName"].ToString();
                    User.TeacherID = Convert.ToInt32(dr["intTeacherID"]);
                    User.StudentID = Convert.ToInt32(dr["StudentID"]);
                    User.TeacherName = dr["vcFName"].ToString();


                    return dr;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataRow CheckAlreadyCreated(string UserName)
        {
            try
            {
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
              {
                    Execute.AddParameter("@UserName",UserName)
              };

                DataRow dr = (DataRow)objExecute.Executes("spCheckAlreadyCreated", ReturnType.DataRow, param, CommandType.StoredProcedure);
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
