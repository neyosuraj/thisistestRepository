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
    public class BLLStock
    {
        public int createstock(string category_name, string product_name, int quantity, decimal price, DateTime expiry_date)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
       new SqlParameter("@category_name",category_name),

       new SqlParameter("@product_name",product_name),


       new SqlParameter("@quantity",quantity),
       new SqlParameter("@price",price),
       new SqlParameter("@expiry_date",expiry_date)
            };
            return DAL.IDU("insert into tbl_stocks values(@category_name,@product_name,@quantity,@price,@expiry_date)", parm);
        }
        public DataTable getallstock()
        {
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_stocks", null);
            return dt;
        }

        public DataTable getallstockbyname(string category_name)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
             new SqlParameter("@category_name",category_name)
            };
            return DAL.getuser("select * from tbl_stocks where category_name=@category_name", parm);
        }
        public int addquantity(int quantity, string product_name)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
         new SqlParameter("@quantity",quantity),
         new SqlParameter("@product_name",product_name)
         };
            return DAL.IDU("UPDATE tbl_stocks SET quantity = @quantity +quantity WHERE product_name=@product_name", parm);
        }
        public DataTable checkquantityofproduct(string product_name)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
            new SqlParameter ("@product_name",product_name)
        };
            return DAL.getuser("select * from tbl_stocks where product_name=@product_name", parm);
        }
       
    }
}

        
  
    

