using DOA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLS
{
    public class BLLUser
    {
        public DataTable getalluser()
        {
            return DAL.getuser("select * from tbl_user", null);
        }
        public DataTable getusername(string user_name)
        {
            SqlParameter [] parm = new SqlParameter []
            {
                new SqlParameter("@user_name",user_name)

            };
            return DAL.getuser("select * from tbl_user where user_name=@username", parm);
        }
        public DataTable getalluserlogin(string user_name, string password)
        {

            SqlParameter[] parm = new SqlParameter[]
         {
         new SqlParameter("@user_name",user_name),
         new SqlParameter("@password",password)
         };
            return DAL.getuser("select * from tbl_user where user_name=@user_name and password=@password", parm);

        }

        public DataTable getpasswordbyusername(string password)
        {
            SqlParameter[] parm = new SqlParameter[]
           {
                new SqlParameter("@password",password)

           };

            return DAL.getuser("select * from tbl_user where password=@password", parm);
        }
        public int newpassword(string password, string user_name)
        {
            SqlParameter[] parm = new SqlParameter[]
           {
                new SqlParameter("@password",password),
                new SqlParameter("@user_name",user_name)


           };
            return DAL.IDU("update tbl_user set password=@password where user_name=@user_name", parm);
        }

        public int signupuser(string user_name, string pasword, string user_type, string e_mail)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@user_name",user_name),
            new SqlParameter("@password",pasword),
            new SqlParameter("@user_type",user_type),
            new SqlParameter("@e_mail",e_mail)
            };
            return DAL.IDU("insert into tbl_user values(@user_name,@password,@user_type,@e_mail)", parm);
        }

        public SqlDataReader checkusers(string user_name, string password)
        {

            SqlParameter[] parm = new SqlParameter[]
         {
         new SqlParameter("@user_name",user_name),
         new SqlParameter("@password",password)
         };
            return DAL.getreader("select * from tbl_user where user_name=@user_name", parm);

        }
    }
}
