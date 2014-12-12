using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;using System.Web.UI;using System.Web.UI.WebControls;
using System.Data.SqlClient;


using AURO.BLL;
 
namespace AURO.DAL
{
  public class FineDBAccess
  {
     public bool AddNewFine(Fine b1)
     {   
             
      b1.Fine_id = GetNewTBLID();       
      string sql = "insert into [Fine] ([Fine_id],[Reg_id],[Rec_no],[Fine_date],[Mem_id],[Fine_amt],[Rec_amt],[Detail],[Rec_by]) values(" + b1.Fine_id+ ", " + b1.Reg_id+ ", " + b1.Rec_no+ ", '" + b1.Fine_date+ "', " + b1.Mem_id+ ", " + b1.Fine_amt+ ", " + b1.Rec_amt+ ", '" + b1.Detail+ "', " + b1.Rec_by+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateFine(Fine b1)
     {   
             
      string sql = "update [Fine] set [Reg_id]=" + b1.Reg_id+ " ,[Rec_no]=" + b1.Rec_no+ " ,[Fine_date]='" + b1.Fine_date+ "',[Mem_id]=" + b1.Mem_id+ " ,[Fine_amt]=" + b1.Fine_amt+ " ,[Rec_amt]=" + b1.Rec_amt+ " ,[Detail]='" + b1.Detail+ "',[Rec_by]=" + b1.Rec_by+ "   where [Fine_id] =" + b1.Fine_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteFine(Fine x1)
     {   
             
      string Sql = "delete from [Fine]  where [Fine_id] =" + x1.Fine_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Fine GetFineDetails(int x1)
        { 
          
            string Sql = "select * from [Fine]   where [Fine_id] =" + x1 +" ";
            
            
            Fine b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Fine 
                    b1 = new Fine();
    
                    //Now lets populate the employee details into the list of Fine 
                    b1.Fine_id = Convert.ToInt32(row["Fine_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Rec_no = Convert.ToInt32(row["Rec_no"]);
                    b1.Fine_date = Convert.ToDateTime(row["Fine_date"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Fine_amt = Convert.ToDecimal(row["Fine_amt"]);
                    b1.Rec_amt = Convert.ToDecimal(row["Rec_amt"]);
                    b1.Detail = row["Detail"].ToString();
                    b1.Rec_by = Convert.ToInt32(row["Rec_by"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Fine> GetFineList()
        { 
            string Sql = "select * from [Fine]"; 
            List<Fine> listFine = null;
  
            //Lets get the list of all Fine in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Fine 
                    listFine = new List<Fine>();
   
                    //Now lets populate the Fine details into the list of Fine 
                    foreach (DataRow row in table.Rows)
                    {
                    Fine b1 = new Fine();
                    b1.Fine_id = Convert.ToInt32(row["Fine_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Rec_no = Convert.ToInt32(row["Rec_no"]);
                    b1.Fine_date = Convert.ToDateTime(row["Fine_date"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Fine_amt = Convert.ToDecimal(row["Fine_amt"]);
                    b1.Rec_amt = Convert.ToDecimal(row["Rec_amt"]);
                    b1.Detail = row["Detail"].ToString();
                    b1.Rec_by = Convert.ToInt32(row["Rec_by"]);
    
                        listFine.Add(b1);
                    }
                }
            }
    
            return listFine;
        }        
        public List<Fine> GetFineList(string Sql)
        { 
            List<Fine> listFine = null;
  
            //Lets get the list of all Fine in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Fine 
                    listFine = new List<Fine>();
   
                    //Now lets populate the Fine details into the list of Fine 
                    foreach (DataRow row in table.Rows)
                    {
                    Fine b1 = new Fine();
                    b1.Fine_id = Convert.ToInt32(row["Fine_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Rec_no = Convert.ToInt32(row["Rec_no"]);
                    b1.Fine_date = Convert.ToDateTime(row["Fine_date"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Fine_amt = Convert.ToDecimal(row["Fine_amt"]);
                    b1.Rec_amt = Convert.ToDecimal(row["Rec_amt"]);
                    b1.Detail = row["Detail"].ToString();
                    b1.Rec_by = Convert.ToInt32(row["Rec_by"]);
    
                        listFine.Add(b1);
                    }
                }
            }
    
            return listFine;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VFine]"; 
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            return table;
        }        
        public DataTable GetList(string Sql)
        { 
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            return table;
        }        
        public int GetNewTBLID()
        { 
            int i = 0;
            string Sql = "select max(Fine_id) from [Fine]";
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            if (table.Rows.Count > 0 && table.Rows[0][0].ToString()!="")
              {
                    i = Convert.ToInt32(table.Rows[0][0].ToString()) + 1;    
               }
               else
               {
                     i = 1;
               }
            return i;
        }        
    }   
 }   

