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
  public class Order_MasterDBAccess
  {
     public bool AddNewOrder_Master(Order_Master b1)
     {   
             
      b1.Om_id = GetNewTBLID();       
      string sql = "insert into [Order_Master] ([Om_id],[Reg_id],[Mem_id],[Om_number],[Om_date],[Order_bill_no],[Ord_date],[Sup_name],[Sup_address],[Sup_city],[Sup_mobile],[Sup_email],[Gross_amt],[Dis_amt],[Net_amt],[Is_paid],[User1],[Status]) values(" + b1.Om_id+ ", " + b1.Reg_id+ ", " + b1.Mem_id+ ", " + b1.Om_number+ ", '" + b1.Om_date+ "', " + b1.Order_bill_no+ ", '" + b1.Ord_date+ "', '" + b1.Sup_name+ "', '" + b1.Sup_address+ "', '" + b1.Sup_city+ "', " + b1.Sup_mobile+ ", '" + b1.Sup_email+ "', " + b1.Gross_amt+ ", " + b1.Dis_amt+ ", " + b1.Net_amt+ ", '" + b1.Is_paid+ "', '" + b1.User1+ "', " + b1.Status+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateOrder_Master(Order_Master b1)
     {   
             
      string sql = "update [Order_Master] set [Reg_id]=" + b1.Reg_id+ " ,[Mem_id]=" + b1.Mem_id+ " ,[Om_number]=" + b1.Om_number+ " ,[Om_date]='" + b1.Om_date+ "',[Order_bill_no]=" + b1.Order_bill_no+ " ,[Ord_date]='" + b1.Ord_date+ "',[Sup_name]='" + b1.Sup_name+ "',[Sup_address]='" + b1.Sup_address+ "',[Sup_city]='" + b1.Sup_city+ "',[Sup_mobile]=" + b1.Sup_mobile+ " ,[Sup_email]='" + b1.Sup_email+ "',[Gross_amt]=" + b1.Gross_amt+ " ,[Dis_amt]=" + b1.Dis_amt+ " ,[Net_amt]=" + b1.Net_amt+ " ,[Is_paid]='" + b1.Is_paid+ "',[User1]='" + b1.User1+ "',[Status]=" + b1.Status+ "   where [Om_id] =" + b1.Om_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteOrder_Master(Order_Master x1)
     {   
             
      string Sql = "delete from [Order_Master]  where [Om_id] =" + x1.Om_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Order_Master GetOrder_MasterDetails(int x1)
        { 
          
            string Sql = "select * from [Order_Master]   where [Om_id] =" + x1 +" ";
            
            
            Order_Master b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Order_Master 
                    b1 = new Order_Master();
    
                    //Now lets populate the employee details into the list of Order_Master 
                    b1.Om_id = Convert.ToInt32(row["Om_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Om_number = Convert.ToInt32(row["Om_number"]);
                    b1.Om_date = Convert.ToDateTime(row["Om_date"]);
                    b1.Order_bill_no = Convert.ToInt32(row["Order_bill_no"]);
                    b1.Ord_date = Convert.ToDateTime(row["Ord_date"]);
                    b1.Sup_name = row["Sup_name"].ToString();
                    b1.Sup_address = row["Sup_address"].ToString();
                    b1.Sup_city = row["Sup_city"].ToString();
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
 
        public List<Order_Master> GetOrder_MasterList()
        { 
            string Sql = "select * from [Order_Master]"; 
            List<Order_Master> listOrder_Master = null;
  
            //Lets get the list of all Order_Master in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Order_Master 
                    listOrder_Master = new List<Order_Master>();
   
                    //Now lets populate the Order_Master details into the list of Order_Master 
                    foreach (DataRow row in table.Rows)
                    {
                    Order_Master b1 = new Order_Master();
                    b1.Om_id = Convert.ToInt32(row["Om_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Om_number = Convert.ToInt32(row["Om_number"]);
                    b1.Om_date = Convert.ToDateTime(row["Om_date"]);
                    b1.Order_bill_no = Convert.ToInt32(row["Order_bill_no"]);
                    b1.Ord_date = Convert.ToDateTime(row["Ord_date"]);
                    b1.Sup_name = row["Sup_name"].ToString();
                    b1.Sup_address = row["Sup_address"].ToString();
                    b1.Sup_city = row["Sup_city"].ToString();
                    b1.Sup_mobile = Convert.ToDecimal(row["Sup_mobile"]);
                    b1.Sup_email = row["Sup_email"].ToString();
                    b1.Gross_amt = Convert.ToDecimal(row["Gross_amt"]);
                    b1.Dis_amt = Convert.ToDecimal(row["Dis_amt"]);
                    b1.Net_amt = Convert.ToDecimal(row["Net_amt"]);
                    b1.Is_paid = row["Is_paid"].ToString();
                    b1.User1 = row["User1"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listOrder_Master.Add(b1);
                    }
                }
            }
    
            return listOrder_Master;
        }        
        public List<Order_Master> GetOrder_MasterList(string Sql)
        { 
            List<Order_Master> listOrder_Master = null;
  
            //Lets get the list of all Order_Master in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Order_Master 
                    listOrder_Master = new List<Order_Master>();
   
                    //Now lets populate the Order_Master details into the list of Order_Master 
                    foreach (DataRow row in table.Rows)
                    {
                    Order_Master b1 = new Order_Master();
                    b1.Om_id = Convert.ToInt32(row["Om_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Om_number = Convert.ToInt32(row["Om_number"]);
                    b1.Om_date = Convert.ToDateTime(row["Om_date"]);
                    b1.Order_bill_no = Convert.ToInt32(row["Order_bill_no"]);
                    b1.Ord_date = Convert.ToDateTime(row["Ord_date"]);
                    b1.Sup_name = row["Sup_name"].ToString();
                    b1.Sup_address = row["Sup_address"].ToString();
                    b1.Sup_city = row["Sup_city"].ToString();
                    b1.Sup_mobile = Convert.ToDecimal(row["Sup_mobile"]);
                    b1.Sup_email = row["Sup_email"].ToString();
                    b1.Gross_amt = Convert.ToDecimal(row["Gross_amt"]);
                    b1.Dis_amt = Convert.ToDecimal(row["Dis_amt"]);
                    b1.Net_amt = Convert.ToDecimal(row["Net_amt"]);
                    b1.Is_paid = row["Is_paid"].ToString();
                    b1.User1 = row["User1"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listOrder_Master.Add(b1);
                    }
                }
            }
    
            return listOrder_Master;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VOrder_Master]"; 
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
            string Sql = "select max(Om_id) from [Order_Master]";
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

