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
  public class Purchase_MasterDBAccess
  {
     public bool AddNewPurchase_Master(Purchase_Master b1)
     {   
             
      b1.Pm_id = GetNewTBLID();       
      string sql = "insert into [Purchase_Master] ([Pm_id],[Reg_id],[Mem_id],[Pm_Number],[Pm_Date],[Pur_bill_no],[Pur_date],[Sup_name],[Sup_address],[Sup_City],[Sup_mobile],[Sup_email],[Gross_amt],[Dis_amt],[Net_amt],[Is_paid],[User1],[Status]) values(" + b1.Pm_id+ ", " + b1.Reg_id+ ", " + b1.Mem_id+ ", " + b1.Pm_Number+ ", '" + b1.Pm_Date+ "', " + b1.Pur_bill_no+ ", '" + b1.Pur_date+ "', '" + b1.Sup_name+ "', '" + b1.Sup_address+ "', '" + b1.Sup_City+ "', " + b1.Sup_mobile+ ", '" + b1.Sup_email+ "', " + b1.Gross_amt+ ", " + b1.Dis_amt+ ", " + b1.Net_amt+ ", '" + b1.Is_paid+ "', '" + b1.User1+ "', " + b1.Status+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdatePurchase_Master(Purchase_Master b1)
     {   
             
      string sql = "update [Purchase_Master] set [Reg_id]=" + b1.Reg_id+ " ,[Mem_id]=" + b1.Mem_id+ " ,[Pm_Number]=" + b1.Pm_Number+ " ,[Pm_Date]='" + b1.Pm_Date+ "',[Pur_bill_no]=" + b1.Pur_bill_no+ " ,[Pur_date]='" + b1.Pur_date+ "',[Sup_name]='" + b1.Sup_name+ "',[Sup_address]='" + b1.Sup_address+ "',[Sup_City]='" + b1.Sup_City+ "',[Sup_mobile]=" + b1.Sup_mobile+ " ,[Sup_email]='" + b1.Sup_email+ "',[Gross_amt]=" + b1.Gross_amt+ " ,[Dis_amt]=" + b1.Dis_amt+ " ,[Net_amt]=" + b1.Net_amt+ " ,[Is_paid]='" + b1.Is_paid+ "',[User1]='" + b1.User1+ "',[Status]=" + b1.Status+ "   where [Pm_id] =" + b1.Pm_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeletePurchase_Master(Purchase_Master x1)
     {   
             
      string Sql = "delete from [Purchase_Master]  where [Pm_id] =" + x1.Pm_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Purchase_Master GetPurchase_MasterDetails(int x1)
        { 
          
            string Sql = "select * from [Purchase_Master]   where [Pm_id] =" + x1 +" ";
            
            
            Purchase_Master b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Purchase_Master 
                    b1 = new Purchase_Master();
    
                    //Now lets populate the employee details into the list of Purchase_Master 
                    b1.Pm_id = Convert.ToInt32(row["Pm_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Pm_Number = Convert.ToInt32(row["Pm_Number"]);
                    b1.Pm_Date = Convert.ToDateTime(row["Pm_Date"]);
                    b1.Pur_bill_no = Convert.ToInt32(row["Pur_bill_no"]);
                    b1.Pur_date = Convert.ToDateTime(row["Pur_date"]);
                    b1.Sup_name = row["Sup_name"].ToString();
                    b1.Sup_address = row["Sup_address"].ToString();
                    b1.Sup_City = row["Sup_City"].ToString();
                    b1.Sup_mobile = Convert.ToDecimal(row["Sup_mobile"]);
                    b1.Sup_email = row["Sup_email"].ToString();
                    b1.Gross_amt = Convert.ToDecimal(row["Gross_amt"]);
                    b1.Dis_amt = Convert.ToDecimal(row["Dis_amt"]);
                    b1.Net_amt = Convert.ToDecimal(row["Net_amt"]);
                    b1.Is_paid = row["Is_paid"].ToString();
                    b1.User1 = row["User1"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Purchase_Master> GetPurchase_MasterList()
        { 
            string Sql = "select * from [Purchase_Master]"; 
            List<Purchase_Master> listPurchase_Master = null;
  
            //Lets get the list of all Purchase_Master in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Purchase_Master 
                    listPurchase_Master = new List<Purchase_Master>();
   
                    //Now lets populate the Purchase_Master details into the list of Purchase_Master 
                    foreach (DataRow row in table.Rows)
                    {
                    Purchase_Master b1 = new Purchase_Master();
                    b1.Pm_id = Convert.ToInt32(row["Pm_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Pm_Number = Convert.ToInt32(row["Pm_Number"]);
                    b1.Pm_Date = Convert.ToDateTime(row["Pm_Date"]);
                    b1.Pur_bill_no = Convert.ToInt32(row["Pur_bill_no"]);
                    b1.Pur_date = Convert.ToDateTime(row["Pur_date"]);
                    b1.Sup_name = row["Sup_name"].ToString();
                    b1.Sup_address = row["Sup_address"].ToString();
                    b1.Sup_City = row["Sup_City"].ToString();
                    b1.Sup_mobile = Convert.ToDecimal(row["Sup_mobile"]);
                    b1.Sup_email = row["Sup_email"].ToString();
                    b1.Gross_amt = Convert.ToDecimal(row["Gross_amt"]);
                    b1.Dis_amt = Convert.ToDecimal(row["Dis_amt"]);
                    b1.Net_amt = Convert.ToDecimal(row["Net_amt"]);
                    b1.Is_paid = row["Is_paid"].ToString();
                    b1.User1 = row["User1"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listPurchase_Master.Add(b1);
                    }
                }
            }
    
            return listPurchase_Master;
        }        
        public List<Purchase_Master> GetPurchase_MasterList(string Sql)
        { 
            List<Purchase_Master> listPurchase_Master = null;
  
            //Lets get the list of all Purchase_Master in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Purchase_Master 
                    listPurchase_Master = new List<Purchase_Master>();
   
                    //Now lets populate the Purchase_Master details into the list of Purchase_Master 
                    foreach (DataRow row in table.Rows)
                    {
                    Purchase_Master b1 = new Purchase_Master();
                    b1.Pm_id = Convert.ToInt32(row["Pm_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Pm_Number = Convert.ToInt32(row["Pm_Number"]);
                    b1.Pm_Date = Convert.ToDateTime(row["Pm_Date"]);
                    b1.Pur_bill_no = Convert.ToInt32(row["Pur_bill_no"]);
                    b1.Pur_date = Convert.ToDateTime(row["Pur_date"]);
                    b1.Sup_name = row["Sup_name"].ToString();
                    b1.Sup_address = row["Sup_address"].ToString();
                    b1.Sup_City = row["Sup_City"].ToString();
                    b1.Sup_mobile = Convert.ToDecimal(row["Sup_mobile"]);
                    b1.Sup_email = row["Sup_email"].ToString();
                    b1.Gross_amt = Convert.ToDecimal(row["Gross_amt"]);
                    b1.Dis_amt = Convert.ToDecimal(row["Dis_amt"]);
                    b1.Net_amt = Convert.ToDecimal(row["Net_amt"]);
                    b1.Is_paid = row["Is_paid"].ToString();
                    b1.User1 = row["User1"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listPurchase_Master.Add(b1);
                    }
                }
            }
    
            return listPurchase_Master;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VPurchase_Master]"; 
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
            string Sql = "select max(Pm_id) from [Purchase_Master]";
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

