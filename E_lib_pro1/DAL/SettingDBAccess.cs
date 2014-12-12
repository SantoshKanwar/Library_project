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
  public class SettingDBAccess
  {
     public bool AddNewSetting(Setting b1)
     {   
             
      b1.Set_id = GetNewTBLID();       
      string sql = "insert into [Setting] ([Set_id],[Reg_id],[College_id],[Mem_role],[Due_day],[Total_book],[Fine_per_day]) values(" + b1.Set_id+ ", " + b1.Reg_id+ ","+ b1.College_id +", '" + b1.Mem_role+ "', " + b1.Due_day+ ", " + b1.Total_book+ ", " + b1.Fine_per_day+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateSetting(Setting b1)
     {   
             
      string sql = "update [Setting] set [Reg_id]=" + b1.Reg_id+ " ,[College_id]="+ b1.College_id +",[Mem_role]='" + b1.Mem_role+ "' ,[Due_day]=" + b1.Due_day+ " ,[Total_book]=" + b1.Total_book+ " ,[Fine_per_day]=" + b1.Fine_per_day+ "   where [Set_id] =" + b1.Set_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteSetting(Setting x1)
     {   
             
      string Sql = "delete from [Setting]  where [Set_id] =" + x1.Set_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Setting GetSettingDetails(int x1)
        { 
          
            string Sql = "select * from [Setting]   where [Set_id] =" + x1 +" ";
            
            
            Setting b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Setting 
                    b1 = new Setting();
    
                    //Now lets populate the employee details into the list of Setting 
                    b1.Set_id = Convert.ToInt32(row["Set_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Mem_role = row["mem_role"].ToString();
                    b1.Due_day = Convert.ToInt32(row["Due_day"]);
                    b1.Total_book = Convert.ToInt32(row["Total_book"]);
                    b1.Fine_per_day = Convert.ToDecimal(row["Fine_per_day"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Setting> GetSettingList()
        { 
            string Sql = "select * from [Setting]"; 
            List<Setting> listSetting = null;
  
            //Lets get the list of all Setting in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Setting 
                    listSetting = new List<Setting>();
   
                    //Now lets populate the Setting details into the list of Setting 
                    foreach (DataRow row in table.Rows)
                    {
                    Setting b1 = new Setting();
                    b1.Set_id = Convert.ToInt32(row["Set_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Mem_role = row["mem_role"].ToString();
                    b1.Due_day = Convert.ToInt32(row["Due_day"]);
                    b1.Total_book = Convert.ToInt32(row["Total_book"]);
                    b1.Fine_per_day = Convert.ToDecimal(row["Fine_per_day"]);
    
                        listSetting.Add(b1);
                    }
                }
            }
    
            return listSetting;
        }        
        public List<Setting> GetSettingList(string Sql)
        { 
            List<Setting> listSetting = null;
  
            //Lets get the list of all Setting in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Setting 
                    listSetting = new List<Setting>();
   
                    //Now lets populate the Setting details into the list of Setting 
                    foreach (DataRow row in table.Rows)
                    {
                    Setting b1 = new Setting();
                    b1.Set_id = Convert.ToInt32(row["Set_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Mem_role = row["Mem_role"].ToString();
                    b1.Due_day = Convert.ToInt32(row["Due_day"]);
                    b1.Total_book = Convert.ToInt32(row["Total_book"]);
                    b1.Fine_per_day = Convert.ToDecimal(row["Fine_per_day"]);
    
                        listSetting.Add(b1);
                    }
                }
            }
    
            return listSetting;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VSetting]"; 
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
            string Sql = "select max(Set_id) from [Setting]";
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

