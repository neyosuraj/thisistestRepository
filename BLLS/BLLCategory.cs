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
    public class BLLCategory
    {
        public DataTable getallcategory()
        {
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_categorys", null);
            return dt;
        }
        public int addcategory(string category_name)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter ("@category_name",category_name)
            };
            return DAL.IDU("insert into tbl_categorys values(@category_name)", parm);
        }
        public DataTable checkcategory(string category_name)
        {
            SqlParameter[] parm = new SqlParameter[]
          {
            new SqlParameter("@category_name",category_name)

          };
            return DAL.getuser("select * from tbl_categorys where category_name=@category_name", parm);
        }
        public int deletecategory(string category_name)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
        new SqlParameter("@category_name",category_name)
        };
            return DAL.IDU("delete from tbl_categorys where category_name=@category_name", parm);
        }

       
    }
}
