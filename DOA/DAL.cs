using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace DOA
{
   public class DAL
    {

       // public static AppSettingsReader aps = new AppSettingsReader();
     public static SqlConnection getconnection()
     {

            //    string sqlcon = aps.GetValue("myConnection",typeof(System.String)).ToString();
            string sqlcon = "Data Source = localhost; Initial Catalog = POS; Integrated Security = True; ";
            SqlConnection scon =new SqlConnection(sqlcon);
         if(scon.State!=ConnectionState.Open)
            {

             scon.Open();
         
         }
         return scon;


     }
     public static int IDU(string sql, SqlParameter[] parm)
     {

         using (SqlConnection scon = getconnection())
         {
             SqlCommand scmd = new SqlCommand(sql,scon);
             scmd.Parameters.AddRange(parm);
             try { 
           
                 return scmd.ExecuteNonQuery();
             
             }
             catch(Exception ex){
             throw ex;
             }

             }



         }
     public static DataTable getuser(string sql, SqlParameter[] parm) { 
     
     using(SqlConnection scon=getconnection()){
         SqlCommand scmd = new SqlCommand(sql, scon);

         if(parm!=null){
         scmd.Parameters.AddRange(parm);
         }
         
         SqlDataAdapter sda = new SqlDataAdapter(scmd);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         return dt;
         
     
     }
         
     }
 public static SqlDataReader getreader(string sql, SqlParameter[]parm)
 {
    using( SqlConnection scon = getconnection()){

    SqlCommand scmd = new SqlCommand(sql, scon);
    
        if(parm!=null){
         scmd.Parameters.AddRange(parm);
         }
        
        SqlDataReader dr = scmd.ExecuteReader(CommandBehavior.CloseConnection);
        return dr;
    }
 }
     } 
     }
    

