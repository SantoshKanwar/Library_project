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
  public class Composite1_DesigDBAccess
  {
     public bool AddNewComposite1_Desig(Composite1_Desig b1)
     {   
             
      b1.Comp1_id = GetNewTBLID();       
      string sql = "insert into [Composite1_Desig] ([Comp1_id],[Des_id],[College_id]) values(" + b1.Comp1_id+ ", " + b1.Des_id+ ", " + b1.College_id+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateComposite1_Desig(Composite1_Desig b1)
     {   
             
      string sql = "update [Composite1_Desig] set [Des_id]=" + b1.Des_id+ " ,[College_id]=" + b1.College_id+ "   where [Comp1_id] =" + b1.Comp1_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteComposite1_Desig(Composite1_Desig x1)
     {   
             
      string Sql = "delete from [Composite1_Desig]  where [Comp1_id] =" + x1.Comp1_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Composite1_Desig GetComposite1_DesigDetails(int x1)
        { 
          
            string Sql = "select * from [Composite1_Desig]   where [Comp1_id] =" + x1 +" ";
            
            
            Composite1_Desig b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Composite1_Desig 
                    b1 = new Composite1_Desig();
    
                    //Now lets populate the employee details into the list of Composite1_Desig 
                    b1.Comp1_id = Convert.ToInt32(row["Comp1_id"]);
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Composite1_Desig> GetComposite1_DesigList()
        { 
            string Sql = "select * from [Composite1_Desig]"; 
            List<Composite1_Desig> listComposite1_Desig = null;
  
            //Lets get the list of all Composite1_Desig in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Composite1_Desig 
                    listComposite1_Desig = new List<Composite1_Desig>();
   
                    //Now lets populate the Composite1_Desig details into the list of Composite1_Desig 
                    foreach (DataRow row in table.Rows)
                    {
                    Composite1_Desig b1 = new Composite1_Desig();
                    b1.Comp1_id = Convert.ToInt32(row["Comp1_id"]);
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
    
                        listComposite1_Desig.Add(b1);
                    }
                }
            }
    
            return listComposite1_Desig;
        }        
        public List<Composite1_Desig> GetComposite1_DesigList(string Sql)
        { 
            List<Composite1_Desig> listComposite1_Desig = null;
  
            //Lets get the list of all Composite1_Desig in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Composite1_Desig 
                    listComposite1_Desig = new List<Composite1_Desig>();
   
                    //Now lets populate the Composite1_Desig details into the list of Composite1_Desig 
                    foreach (DataRow row in table.Rows)
                    {
                    Composite1_Desig b1 = new Composite1_Desig();
                    b1.Comp1_id = Convert.ToInt32(row["Comp1_id"]);
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
    
                        listComposite1_Desig.Add(b1);
                    }
                }
            }
    
            return listComposite1_Desig;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VComposite1_Desig]"; 
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
            string Sql = "select max(Comp1_id) from [Composite1_Desig]";
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

