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
  public class Order_DetailDBAccess
  {
     public bool AddNewOrder_Detail(Order_Detail b1)
     {   
             
      b1.Od_id = GetNewTBLID();       
      string sql = "insert into [Order_Detail] ([Od_id],[Reg_id],[Om_id],[Book_id],[Qty],[Rate],[Amount]) values(" + b1.Od_id+ ", " + b1.Reg_id+ ", " + b1.Om_id+ ", " + b1.Book_id+ ", " + b1.Qty+ ", " + b1.Rate+ ", " + b1.Amount+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateOrder_Detail(Order_Detail b1)
     {   
             
      string sql = "update [Order_Detail] set [Reg_id]=" + b1.Reg_id+ " ,[Om_id]=" + b1.Om_id+ " ,[Book_id]=" + b1.Book_id+ " ,[Qty]=" + b1.Qty+ " ,[Rate]=" + b1.Rate+ " ,[Amount]=" + b1.Amount+ "   where [Od_id] =" + b1.Od_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteOrder_Detail(Order_Detail x1)
     {   
             
      string Sql = "delete from [Order_Detail]  where [Od_id] =" + x1.Od_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Order_Detail GetOrder_DetailDetails(int x1)
        { 
          
            string Sql = "select * from [Order_Detail]   where [Od_id] =" + x1 +" ";
            
            
            Order_Detail b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Order_Detail 
                    b1 = new Order_Detail();
    
                    //Now lets populate the employee details into the list of Order_Detail 
                    b1.Od_id = Convert.ToInt32(row["Od_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Om_id = Convert.ToInt32(row["Om_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Qty = Convert.ToInt32(row["Qty"]);
                    b1.Rate = Convert.ToDecimal(row["Rate"]);
                    b1.Amount = Convert.ToDecimal(row["Amount"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Order_Detail> GetOrder_DetailList()
        { 
            string Sql = "select * from [Order_Detail]"; 
            List<Order_Detail> listOrder_Detail = null;
  
            //Lets get the list of all Order_Detail in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Order_Detail 
                    listOrder_Detail = new List<Order_Detail>();
   
                    //Now lets populate the Order_Detail details into the list of Order_Detail 
                    foreach (DataRow row in table.Rows)
                    {
                    Order_Detail b1 = new Order_Detail();
                    b1.Od_id = Convert.ToInt32(row["Od_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Om_id = Convert.ToInt32(row["Om_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Qty = Convert.ToInt32(row["Qty"]);
                    b1.Rate = Convert.ToDecimal(row["Rate"]);
                    b1.Amount = Convert.ToDecimal(row["Amount"]);
    
                        listOrder_Detail.Add(b1);
                    }
                }
            }
    
            return listOrder_Detail;
        }        
        public List<Order_Detail> GetOrder_DetailList(string Sql)
        { 
            List<Order_Detail> listOrder_Detail = null;
  
            //Lets get the list of all Order_Detail in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Order_Detail 
                    listOrder_Detail = new List<Order_Detail>();
   
                    //Now lets populate the Order_Detail details into the list of Order_Detail 
                    foreach (DataRow row in table.Rows)
                    {
                    Order_Detail b1 = new Order_Detail();
                    b1.Od_id = Convert.ToInt32(row["Od_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Om_id = Convert.ToInt32(row["Om_id"]);
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Qty = Convert.ToInt32(row["Qty"]);
                    b1.Rate = Convert.ToDecimal(row["Rate"]);
                    b1.Amount = Convert.ToDecimal(row["Amount"]);
    
                        listOrder_Detail.Add(b1);
                    }
                }
            }
    
            return listOrder_Detail;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VOrder_Detail]"; 
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
            string Sql = "select max(Od_id) from [Order_Detail]";
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

