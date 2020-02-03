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
    public class UserBAL
    {
        UserDAL objUserDAL;

        public bool CreateUser(UserEntity obj)
        {
            objUserDAL = new UserDAL();
            return objUserDAL.CreateUser(obj);
        }

        public List<UserGroupEntity> GetUserGroups()
        {
            List<UserGroupEntity> lst = new List<UserGroupEntity>();
            UserGroupEntity obj;

            objUserDAL = new UserDAL();

            DataTable dt = objUserDAL.GetUserGroups();
            foreach (DataRow dr in dt.Rows)
            {
                obj = new UserGroupEntity();
                obj.UserGroup = dr["UserGroup"].ToString();
                obj.UserGroupID = Convert.ToInt32(dr["UserGroupID"]);
                lst.Add(obj);
            }

            return lst;
        }

        public DataRow CheckUserAccount(string UserName, string Password)
        {
            objUserDAL = new UserDAL();
            return objUserDAL.CheckUserAccount(UserName, Password);
        }

        public bool CheckAlreadyCreated(string UserName)
        {
            objUserDAL = new UserDAL();
            DataRow dr = objUserDAL.CheckAlreadyCreated(UserName);
            if (dr != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
