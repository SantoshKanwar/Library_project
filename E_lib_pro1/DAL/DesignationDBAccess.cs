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
  public class DesignationDBAccess
  {
     public bool AddNewDesignation(Designation b1)
     {   
             
      b1.Des_id = GetNewTBLID();       
      string sql = "insert into [Designation] ([Des_id],[Reg_id],[Des_name],[Des_code],[IsTeaching]) values(" + b1.Des_id+ ", " + b1.Reg_id+ ", '" + b1.Des_name+ "', " + b1.Des_code+ ", " + b1.IsTeaching+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateDesignation(Designation b1)
     {   
             
      string sql = "update [Designation] set [Reg_id]=" + b1.Reg_id+ " ,[Des_name]='" + b1.Des_name+ "',[Des_code]=" + b1.Des_code+ " ,[IsTeaching]=" + b1.IsTeaching+ "   where [Des_id] =" + b1.Des_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteDesignation(Designation x1)
     {   
             
      string Sql = "delete from [Designation]  where [Des_id] =" + x1.Des_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Designation GetDesignationDetails(int x1)
        { 
          
            string Sql = "select * from [Designation]   where [Des_id] =" + x1 +" ";
            
            
            Designation b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Designation 
                    b1 = new Designation();
    
                    //Now lets populate the employee details into the list of Designation 
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Des_name = row["Des_name"].ToString();
                    b1.Des_code = Convert.ToInt32(row["Des_code"]);
                    b1.IsTeaching = Convert.ToInt32(row["IsTeaching"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Designation> GetDesignationList()
        { 
            string Sql = "select * from [Designation]"; 
            List<Designation> listDesignation = null;
  
            //Lets get the list of all Designation in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Designation 
                    listDesignation = new List<Designation>();
   
                    //Now lets populate the Designation details into the list of Designation 
                    foreach (DataRow row in table.Rows)
                    {
                    Designation b1 = new Designation();
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Des_name = row["Des_name"].ToString();
                    b1.Des_code = Convert.ToInt32(row["Des_code"]);
                    b1.IsTeaching = Convert.ToInt32(row["IsTeaching"]);
    
                        listDesignation.Add(b1);
                    }
                }
            }
    
            return listDesignation;
        }        
        public List<Designation> GetDesignationList(string Sql)
        { 
            List<Designation> listDesignation = null;
  
            //Lets get the list of all Designation in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Designation 
                    listDesignation = new List<Designation>();
   
                    //Now lets populate the Designation details into the list of Designation 
                    foreach (DataRow row in table.Rows)
                    {
                    Designation b1 = new Designation();
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Des_name = row["Des_name"].ToString();
                    b1.Des_code = Convert.ToInt32(row["Des_code"]);
                    b1.IsTeaching = Convert.ToInt32(row["IsTeaching"]);
    
                        listDesignation.Add(b1);
                    }
                }
            }
    
            return listDesignation;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [Designation]"; 
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
            string Sql = "select max(Des_id) from [Designation]";
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            if (table.Rows.Count > 0 && table.Rows[0][0].ToString() != "")
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

