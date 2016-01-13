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
    public class BLLOrder
    {

        public DataTable getitembyname(string item_name)
        {
            SqlParameter[] parm = new SqlParameter[]
          {
            new SqlParameter("@item_name",item_name)
          };
            return DAL.getuser("select item_name from tbl_orders", parm);
        }
        public int insertorder(string user_name, int table_no, string item, int quantity, decimal total, decimal cost)
        {
            SqlParameter[] parm = new SqlParameter[]
          {
            new SqlParameter("@user_name",user_name),

        new SqlParameter("@table_no",table_no),
        new SqlParameter ("@item",item),
        new SqlParameter("@quantity",quantity),
        new SqlParameter("@total",total),
        new SqlParameter("@cost",cost)

          };
            return DAL.IDU("insert into tbl_orders values(@user_name,@table_no,@item,@quantity,@total,@cost)", parm);
        }
        public DataTable getalldata(int table_no)
        {
            SqlParameter[] parm = new SqlParameter[]{
         new SqlParameter("@table_no",table_no)
         };
            return DAL.getuser("select * from tbl_orders where table_no=@table_no", parm);

        }
        public int deletefromtable(int table_no)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
        new SqlParameter ("@table_no",table_no)
        };
            return DAL.IDU("delete from tbl_orders where table_no=@table_no", parm);
        }
        public DataTable getalldatafromitem()
        {
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_items", null);
            return dt;
        }
        public DataTable getallitemprice(int item_id)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
         new SqlParameter("@item_id",item_id)
           };
            DataTable dt = new DataTable();
            dt = DAL.getuser("select * from tbl_items where item_id=@item_id", parm);
            return dt;
        }
        public int updateitem(string item_name, decimal item_price)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
          new SqlParameter("item_name",item_name),
          new SqlParameter("item_price",item_price)
        };
            return DAL.IDU("update  tbl_items set item_name=@item_name,item_price=@item_price", parm);

        }
        public int deleteitem(string item_name)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
            new SqlParameter ("item_name",item_name)
            };
            return DAL.IDU("delete from tbl_items where item_name=@item_name", parm);
        }

        public int updateitemprice(string item_name, decimal item_price)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
        new SqlParameter("item_name",item_name),
          new SqlParameter("item_price",item_price)
            };
            return DAL.IDU("update tbl_items set item_price=@item_price", parm);
        }
        public int additems(string item_name, decimal item_price)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
          new SqlParameter("item_name",item_name),
          new SqlParameter("item_price",item_price)
        };
            return DAL.IDU("insert into  tbl_items  values( @item_name,@item_price)", parm);

        }

        public int updateorderstable(int table_no, string item, int quantity, int order_id, decimal total)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
          new SqlParameter("table_no",table_no),
          new SqlParameter ("item",item),
          new SqlParameter("quantity",quantity),
          new SqlParameter("order_id",order_id),
          new SqlParameter("total",total)
            };

            return DAL.IDU("update tbl_orders set table_no=@table_no,item=@item,quantity=@quantity,total=@total where order_id=@order_id", parm);
        }


        public int additem(string item_name, decimal item_price)
        {
            SqlParameter[] parm = new SqlParameter[]
        {
          new SqlParameter("item_name",item_name),
          new SqlParameter("item_price",item_price)
        };
            return DAL.IDU("insert into  tbl_items  values( @item_name,@item_price)", parm);

        }
        public int addorder(string item,int quantity,decimal total,DateTime date)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
             new SqlParameter("@item",item),
            new SqlParameter("@quantity",quantity),
            new SqlParameter("@total",total),
            new SqlParameter("@date",date)
                };
            return DAL.IDU("insert into tbl_rest_exp values(@item,@quantity,@total,@date)", parm);
        }
        public  DataTable searchbydate(DateTime date)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@date",date)
                };
            
            DataTable dt= DAL.getuser("select * from tbl_rest_exp where date=@date", parm);
            return dt;
        }

    }
}

       
    
