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
  public class Purchase_DetailDBAccess
  {
     public bool AddNewPurchase_Detail(Purchase_Detail b1)
     {   
             
      b1.Pd_id = GetNewTBLID();       
      string sql = "insert into [Purchase_Detail] ([Pd_id],[Reg_id],[Pm_id],[Book_id],[Qty],[Rate],[Amount]) values(" + b1.Pd_id+ ", " + b1.Reg_id+ ", " + b1.Pm_id+ ", " + b1.Book_id+ ", " + b1.Qty+ ", " + b1.Rate+ ", " + b1.Amount+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdatePurchase_Detail(Purchase_Detail b1)
     {   
             
      string sql = "update [Purchase_Detail] set [Reg_id]=" + b1.Reg_id+ " ,[Pm_id]=" + b1.Pm_id+ " ,[Book_id]=" + b1.Book_id+ " ,[Qty]=" + b1.Qty+ " ,[Rate]=" + b1.Rate+ " ,[Amount]=" + b1.Amount+ "   where [Pd_id] =" + b1.Pd_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeletePurchase_Detail(Purchase_Detail x1)
     {   
             
      string Sql = "delete from [Purchase_Detail]  where [Pd_id] =" + x1.Pd_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Purchase_Detail GetPurchase_DetailDetails(int x1)
        { 
          
            string Sql = "select * from [Purchase_Detail]   where [Pd_id] =" + x1 +" ";
            
            
            Purchase_Detail b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Purchase_Detail 
                    b1 = new Purchase_Detail();
    
                    //Now lets populate the employee details into the list of Purchase_Detail 
                    b1.Pd_id = Convert.ToInt32(row["Pd_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Pm_id = Convert.ToInt32(row["Pm_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Qty = Convert.ToInt32(row["Qty"]);
                    b1.Rate = Convert.ToDecimal(row["Rate"]);
                    b1.Amount = Convert.ToDecimal(row["Amount"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Purchase_Detail> GetPurchase_DetailList()
        { 
            string Sql = "select * from [VPurchase_Detail]"; 
            List<Purchase_Detail> listPurchase_Detail = null;
  
            //Lets get the list of all Purchase_Detail in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Purchase_Detail 
                    listPurchase_Detail = new List<Purchase_Detail>();
   
                    //Now lets populate the Purchase_Detail details into the list of Purchase_Detail 
                    foreach (DataRow row in table.Rows)
                    {
                    Purchase_Detail b1 = new Purchase_Detail();
                    b1.Pd_id = Convert.ToInt32(row["Pd_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Pm_id = Convert.ToInt32(row["Pm_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Qty = Convert.ToInt32(row["Qty"]);
                    b1.Rate = Convert.ToDecimal(row["Rate"]);
                    b1.Amount = Convert.ToDecimal(row["Amount"]);
    
                        listPurchase_Detail.Add(b1);
                    }
                }
            }
    
            return listPurchase_Detail;
        }        
        public List<Purchase_Detail> GetPurchase_DetailList(string Sql)
        { 
            List<Purchase_Detail> listPurchase_Detail = null;
  
            //Lets get the list of all Purchase_Detail in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Purchase_Detail 
                    listPurchase_Detail = new List<Purchase_Detail>();
   
                    //Now lets populate the Purchase_Detail details into the list of Purchase_Detail 
                    foreach (DataRow row in table.Rows)
                    {
                    Purchase_Detail b1 = new Purchase_Detail();
                    b1.Pd_id = Convert.ToInt32(row["Pd_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Pm_id = Convert.ToInt32(row["Pm_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Qty = Convert.ToInt32(row["Qty"]);
                    b1.Rate = Convert.ToDecimal(row["Rate"]);
                    b1.Amount = Convert.ToDecimal(row["Amount"]);
    
                        listPurchase_Detail.Add(b1);
                    }
                }
            }
    
            return listPurchase_Detail;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [Purchase_Detail]"; 
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
            string Sql = "select max(Pd_id) from [Purchase_Detail]";
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

