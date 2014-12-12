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
  public class CollegeDBAccess
  {
     public bool AddNewCollege(College b1)
     {   
             
      b1.College_id = GetNewTBLID();       
      string sql = "insert into [College] ([College_id],[Reg_id],[College_Name],[Address],[City],[Phone],[Mobile],[Fax],[Email],[Website],[College_code],[Prefix],[status]) values(" + b1.College_id+ ", " + b1.Reg_id+ ", '" + b1.College_Name+ "', '" + b1.Address+ "', '" + b1.City+ "', '" + b1.Phone+ "', " + b1.Mobile+ ", '" + b1.Fax+ "', '" + b1.Email+ "', '" + b1.Website+ "', '" + b1.College_code+ "', '" + b1.Prefix+ "', " + b1.Status+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateCollege(College b1)
     {   
             
      string sql = "update [College] set [Reg_id]=" + b1.Reg_id+ " ,[College_Name]='" + b1.College_Name+ "',[Address]='" + b1.Address+ "',[City]='" + b1.City+ "',[Phone]='" + b1.Phone+ "',[Mobile]=" + b1.Mobile+ " ,[Fax]='" + b1.Fax+ "',[Email]='" + b1.Email+ "',[Website]='" + b1.Website+ "',[College_code]='" + b1.College_code+ "',[Prefix]='" + b1.Prefix+ "',[status]=" + b1.Status+ "   where [College_id] =" + b1.College_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteCollege(College x1)
     {   
             
      string Sql = "delete from [College]  where [College_id] =" + x1.College_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public College GetCollegeDetails(int x1)
        { 
          
            string Sql = "select * from [College]   where [College_id] =" + x1 +" ";
            
            
            College b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of College 
                    b1 = new College();
    
                    //Now lets populate the employee details into the list of College 
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.College_Name = row["College_Name"].ToString();
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Fax = row["Fax"].ToString();
                    b1.Email = row["Email"].ToString();
                    b1.Website = row["Website"].ToString();
                    b1.College_code = row["College_code"].ToString();
                    b1.Prefix = row["Prefix"].ToString();
                    b1.Status = Convert.ToInt32(row["status"]);
                }
            } 
 
            return b1; 
        }
 
        public List<College> GetCollegeList()
        { 
            string Sql = "select * from [College]"; 
            List<College> listCollege = null;
  
            //Lets get the list of all College in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of College 
                    listCollege = new List<College>();
   
                    //Now lets populate the College details into the list of College 
                    foreach (DataRow row in table.Rows)
                    {
                    College b1 = new College();
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.College_Name = row["College_Name"].ToString();
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Fax = row["Fax"].ToString();
                    b1.Email = row["Email"].ToString();
                    b1.Website = row["Website"].ToString();
                    b1.College_code = row["College_code"].ToString();
                    b1.Prefix = row["Prefix"].ToString();
                    b1.Status = Convert.ToInt32(row["status"]);
    
                        listCollege.Add(b1);
                    }
                }
            }
    
            return listCollege;
        }        
        public List<College> GetCollegeList(string Sql)
        { 
            List<College> listCollege = null;
  
            //Lets get the list of all College in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of College 
                    listCollege = new List<College>();
   
                    //Now lets populate the College details into the list of College 
                    foreach (DataRow row in table.Rows)
                    {
                    College b1 = new College();
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.College_Name = row["College_Name"].ToString();
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Fax = row["Fax"].ToString();
                    b1.Email = row["Email"].ToString();
                    b1.Website = row["Website"].ToString();
                    b1.College_code = row["College_code"].ToString();
                    b1.Prefix = row["Prefix"].ToString();
                    b1.Status = Convert.ToInt32(row["status"]);
    
                        listCollege.Add(b1);
                    }
                }
            }
    
            return listCollege;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [College]"; 
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
            string Sql = "select max(College_id) from [College]";
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

