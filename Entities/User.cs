using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class User
    {

        private static int userID;
        private static string userName;
        private static int userGroupID;
        private static string studentName;
        private static string stream;
        private static string studentNo;

        public static int teacherID;
        public static int studentID { get; set; }

        public static string teacherName { get; set; }

        public static string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }

        public static int TeacherID
        {
            get { return teacherID; }
            set { teacherID = value; }
        }

        public static int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public static int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static int UserGroupID
        {
            get { return userGroupID; }
            set { userGroupID = value; }
        }

        public static string StudentName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static string Stream
        {
            get { return stream; }
            set { stream = value; }
        }

        public static string StudentNo
        {
            get { return studentNo; }
            set { studentNo = value; }
        }
    }
}
