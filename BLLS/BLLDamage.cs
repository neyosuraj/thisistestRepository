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
    public class BLLDamage
    {
        public int damageproduct(string product_name, int quantity)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
            new SqlParameter("@product_name",product_name),
            new SqlParameter("@quantity",quantity)
        };

            return DAL.IDU("UPDATE tbl_stocks SET quantity =quantity-@quantity WHERE product_name=@product_name", parm);
        }
        public int addtodamage(string category_name, string product_name, int quantity, DateTime damage_entry_date)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
            new SqlParameter("@category_name",category_name),
            new SqlParameter("@product_name",product_name),
            new SqlParameter("@quantity",quantity),
            new SqlParameter("@damage_entry_date",damage_entry_date)

        };
            return DAL.IDU("insert into tbl_damages values(@category_name,@product_name,@quantity,@damage_entry_date) ", parm);
        }
        public int addexpirydate(string category_name, string product_name, int quantity, DateTime expiry_date, DateTime expiry_date_entry)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@category_name",category_name),
                new SqlParameter("@product_name",product_name),
                new SqlParameter("@quantity",quantity),
                new SqlParameter("@expiry_date",expiry_date),
                new SqlParameter ("@expiry_date_entry",expiry_date_entry)

            };
            return DAL.IDU("insert into tbl_expiry values(@category_name,@product_name,@quantity,@expiry_date,@expiry_date_entry)", parm);
        }
        public DataTable getalldamageproduct()
        {
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_damages", null);
            return dt;

        }

        public DataTable getdamageproductbyproductname(string product_name)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
        new SqlParameter("@product_name",product_name)
        };
            return DAL.getuser("select * from tbl_damages where product_name=@product_name", parm);
        }
        public DataTable getallexpiryproduct()
        {
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_expiry", null);
            return dt;
        }
        public DataTable getexpiryproductbyproductname(string product_name)
        {
            SqlParameter[] parm = new SqlParameter[]
          {
            new SqlParameter("@product_name",product_name)
          };
            return DAL.getuser("select * from tbl_expiry where product_name =@product_name ", parm);
        }
    }
}
