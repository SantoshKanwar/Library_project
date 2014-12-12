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
  public class DepartmentDBAccess
  {
     public bool AddNewDepartment(Department b1)
     {   
             
      b1.Dep_id = GetNewTBLID();       
      string sql = "insert into [Department] ([Dep_id],[Reg_id],[Dep_name],[Dep_code]) values(" + b1.Dep_id+ ", " + b1.Reg_id+ ", '" + b1.Dep_name+ "', '" + b1.Dep_code+ "' )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateDepartment(Department b1)
     {   
             
      string sql = "update [Department] set [Reg_id]=" + b1.Reg_id+ " ,[Dep_name]='" + b1.Dep_name+ "',[Dep_code]='" + b1.Dep_code+ "'  where [Dep_id] =" + b1.Dep_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteDepartment(Department x1)
     {   
             
      string Sql = "delete from [Department]  where [Dep_id] =" + x1.Dep_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Department GetDepartmentDetails(int x1)
        { 
          
            string Sql = "select * from [Department]   where [Dep_id] =" + x1 +" ";
            
            
            Department b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Department 
                    b1 = new Department();
    
                    //Now lets populate the employee details into the list of Department 
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Dep_name = row["Dep_name"].ToString();
                    b1.Dep_code = row["Dep_code"].ToString();
                }
            } 
 
            return b1; 
        }
 
        public List<Department> GetDepartmentList()
        { 
            string Sql = "select * from [Department]"; 
            List<Department> listDepartment = null;
  
            //Lets get the list of all Department in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Department 
                    listDepartment = new List<Department>();
   
                    //Now lets populate the Department details into the list of Department 
                    foreach (DataRow row in table.Rows)
                    {
                    Department b1 = new Department();
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Dep_name = row["Dep_name"].ToString();
                    b1.Dep_code = row["Dep_code"].ToString();
    
                        listDepartment.Add(b1);
                    }
                }
            }
    
            return listDepartment;
        }        
        public List<Department> GetDepartmentList(string Sql)
        { 
            List<Department> listDepartment = null;
  
            //Lets get the list of all Department in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Department 
                    listDepartment = new List<Department>();
   
                    //Now lets populate the Department details into the list of Department 
                    foreach (DataRow row in table.Rows)
                    {
                    Department b1 = new Department();
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Dep_name = row["Dep_name"].ToString();
                    b1.Dep_code = row["Dep_code"].ToString();
    
                        listDepartment.Add(b1);
                    }
                }
            }
    
            return listDepartment;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [Department]"; 
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
            string Sql = "select max(Dep_id) from [Department]";
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            if (table.Rows.Count > 0 && table.Rows[0][0].ToString()!= "")
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

