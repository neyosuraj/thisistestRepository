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
    public class BLLPurchase
    {
        public int createpurhase(int category_id, int product_id, int quantity, int invoice_no, decimal price, int discount, decimal total,DateTime expiry_date,decimal paid_amount,decimal remaining_amount)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
       new SqlParameter("@category_id",category_id),
       new SqlParameter("@product_id",product_id),
       new SqlParameter("@quantity",quantity),
       new SqlParameter("@invoice_no",invoice_no),
       new SqlParameter("@price",price),
       new SqlParameter("@discount",discount),
       new SqlParameter("@total",total),
       new SqlParameter("@expiry_date",expiry_date),
       new SqlParameter("@paid_amount",paid_amount),
       new SqlParameter("@remaining_amount",remaining_amount)

       };
            return DAL.IDU("insert into tbl_purchases values(@category_id,@product_id,@quantity,@invoice_no,@price,@discount,@total,@expiry_date,@paid_amount,@remaining_amount)", parm);
        }
        public DataTable getallpurchase() 
        {
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_purchases", null);
            return dt;
        }
        public DataTable getpurchasebycategory(int category_id)
        {
            SqlParameter[] parm = new SqlParameter[] 
            { 
             new SqlParameter("@category_id",category_id)
            };
            return DAL.getuser("select * from tbl_purchases where category_id = @category_id", parm);
        }
        public DataTable getpurchasebyproduct(int product_id)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter("@product_id",product_id)
            };
           return DAL.getuser("select * from tbl_purchases where product_id =@product_id ",parm);
        }
    }
}
