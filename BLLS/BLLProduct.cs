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
    public class BLLProduct
    {
        

        public DataTable getproductid(int category_id)
        {
            SqlParameter[] parm = new SqlParameter[]
             {
            new SqlParameter ("@category_id", category_id)
             };
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_product where category_id=@category_id", parm);
            return dt;
        }
        public DataTable getpricebyproductid(int product_id)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
            new SqlParameter ("@product_id",product_id)
         };
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_product where product_id=@product_id", parm);
            return dt;
        }
        public int addproduct(int category_id, string product_name, decimal price)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@category_id",category_id),
                new SqlParameter("@product_name",product_name),
                new SqlParameter("@price",price)
            };
            return DAL.IDU("insert into tbl_product values(@category_id,@product_name,@price)", parm);
        }
        public int deleteproduct(string product_name)
        {
            SqlParameter[] parm = new SqlParameter[]
             {
                new SqlParameter ("@product_name",product_name)
             };
            return DAL.IDU("delete from tbl_product where product_name=@product_name", parm);
        }
        public DataTable checkproduct(string product_name)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
            new SqlParameter ("@product_name",product_name)
         };
            return DAL.getuser("select * from tbl_product where product_name=@product_name", parm);
        }
        public DataTable getallproduct()
        {
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_product", null);
            return dt;
        }


        public int updateprice(decimal price, int product_id)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
            new SqlParameter("@price",price),
            new SqlParameter("@product_id",product_id)
         };
            return DAL.IDU("update tbl_product set price=@price where product_id=@product_id", parm);
        }

        public DataTable checkallproducts(string product_name)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
            new SqlParameter ("@product_name",product_name)
         };
            return DAL.getuser("select * from tbl_product where product_name=@product_name", parm);
        }
       

        

    }
}

