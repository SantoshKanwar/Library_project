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
  public class Composite_DepDBAccess
  {
     public bool AddNewComposite_Dep(Composite_Dep b1)
     {   
             
      b1.Comp_id = GetNewTBLID();       
      string sql = "insert into [Composite_Dep] ([Comp_id],[Dep_id],[College_id]) values(" + b1.Comp_id+ ", " + b1.Dep_id+ ", " + b1.College_id+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateComposite_Dep(Composite_Dep b1)
     {   
             
      string sql = "update [Composite_Dep] set [Dep_id]=" + b1.Dep_id+ " ,[College_id]=" + b1.College_id+ "   where [Comp_id] =" + b1.Comp_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteComposite_Dep(Composite_Dep x1)
     {   
             
      string Sql = "delete from [Composite_Dep]  where [Comp_id] =" + x1.Comp_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Composite_Dep GetComposite_DepDetails(int x1)
        { 
          
            string Sql = "select * from [Composite_Dep]   where [Comp_id] =" + x1 +" ";
            
            
            Composite_Dep b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Composite_Dep 
                    b1 = new Composite_Dep();
    
                    //Now lets populate the employee details into the list of Composite_Dep 
                    b1.Comp_id = Convert.ToInt32(row["Comp_id"]);
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Composite_Dep> GetComposite_DepList()
        { 
            string Sql = "select * from [Composite_Dep]"; 
            List<Composite_Dep> listComposite_Dep = null;
  
            //Lets get the list of all Composite_Dep in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Composite_Dep 
                    listComposite_Dep = new List<Composite_Dep>();
   
                    //Now lets populate the Composite_Dep details into the list of Composite_Dep 
                    foreach (DataRow row in table.Rows)
                    {
                    Composite_Dep b1 = new Composite_Dep();
                    b1.Comp_id = Convert.ToInt32(row["Comp_id"]);
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
    
                        listComposite_Dep.Add(b1);
                    }
                }
            }
    
            return listComposite_Dep;
        }        
        public List<Composite_Dep> GetComposite_DepList(string Sql)
        { 
            List<Composite_Dep> listComposite_Dep = null;
  
            //Lets get the list of all Composite_Dep in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Composite_Dep 
                    listComposite_Dep = new List<Composite_Dep>();
   
                    //Now lets populate the Composite_Dep details into the list of Composite_Dep 
                    foreach (DataRow row in table.Rows)
                    {
                    Composite_Dep b1 = new Composite_Dep();
                    b1.Comp_id = Convert.ToInt32(row["Comp_id"]);
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
    
                        listComposite_Dep.Add(b1);
                    }
                }
            }
    
            return listComposite_Dep;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VComposite_Dep]"; 
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
            string Sql = "select max(Comp_id) from [Composite_Dep]";
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

