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
  public class Book_Issue_ReturnDBAccess
  {
     public bool AddNewBook_Issue_Return(Book_Issue_Return b1)
     {   
             
      b1.Bir_id = GetNewTBLID();
      string sql = "insert into [Book_Issue_Return] ([Bir_id],[Reg_id],[Mem_id],[Acc_id],[Issue_dt],[Issue_days],[Due_dt],[Return_dt],[Due_day],[Is_return],[Is_fine],[Fine_rate],[Fine_amt]) values(" + b1.Bir_id + ", " + b1.Reg_id + ", " + b1.Mem_id + ", " + b1.Acc_id + ", '" + b1.Issue_dt + "', " + b1.Issue_days + ", '" + b1.Due_dt + "', '" + b1.Return_dt + "', " + b1.Due_day + ",'"+ b1.Is_return +"','"+ b1.Is_fine + "', " + b1.Fine_rate + ", " + b1.Fine_amt + ")";
     
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateBook_Issue_Return(Book_Issue_Return b1)
     {   
             
      string sql = "update [Book_Issue_Return] set [Reg_id]=" + b1.Reg_id+ " ,[Mem_id]=" + b1.Mem_id+ " ,[Acc_id]=" + b1.Acc_id+ " ,[Issue_dt]='" + b1.Issue_dt+ "',[Issue_days]=" + b1.Issue_days+ " ,[Due_dt]='" + b1.Due_dt+ "',[Return_dt]='" + b1.Return_dt+ "',[Due_day]=" + b1.Due_day+ " ,[Is_return]='" + b1.Is_return+ "',[Is_fine]='" + b1.Is_fine + "' ,[Fine_rate]=" + b1.Fine_rate+ " ,[Fine_amt]=" + b1.Fine_amt+ "   where [Bir_id] =" + b1.Bir_id+ " "  ;
 
      return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteBook_Issue_Return(Book_Issue_Return x1)
     {   
             
      string Sql = "delete from [Book_Issue_Return]  where [Bir_id] =" + x1.Bir_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Book_Issue_Return GetBook_Issue_ReturnDetails(int x1)
        { 
          
            string Sql = "select * from [Book_Issue_Return]   where [Bir_id] =" + x1 +" ";
            
            
            Book_Issue_Return b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Book_Issue_Return 
                    b1 = new Book_Issue_Return();
    
                    //Now lets populate the employee details into the list of Book_Issue_Return 
                    b1.Bir_id = Convert.ToInt32(row["Bir_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Acc_id = Convert.ToInt32(row["Acc_id"]);
                    b1.Issue_dt = Convert.ToDateTime(row["Issue_dt"]);
                    b1.Issue_days = Convert.ToInt32(row["Issue_days"]);
                    b1.Due_dt = Convert.ToDateTime(row["Due_dt"]);
                    b1.Return_dt = Convert.ToDateTime(row["Return_dt"]);
                    b1.Due_day = Convert.ToInt32(row["Due_day"]);
                    b1.Is_return = Convert.ToBoolean(row["Is_return"]);
                    b1.Is_fine = Convert.ToBoolean(row["Is_fine"]);
                    b1.Fine_rate = Convert.ToDecimal(row["Fine_rate"]);
                    b1.Fine_amt = Convert.ToDecimal(row["Fine_amt"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Book_Issue_Return> GetBook_Issue_ReturnList()
        { 
            string Sql = "select * from [Book_Issue_Return]"; 
            List<Book_Issue_Return> listBook_Issue_Return = null;
  
            //Lets get the list of all Book_Issue_Return in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Book_Issue_Return 
                    listBook_Issue_Return = new List<Book_Issue_Return>();
   
                    //Now lets populate the Book_Issue_Return details into the list of Book_Issue_Return 
                    foreach (DataRow row in table.Rows)
                    {
                    Book_Issue_Return b1 = new Book_Issue_Return();
                    b1.Bir_id = Convert.ToInt32(row["Bir_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Acc_id = Convert.ToInt32(row["Acc_id"]);
                    b1.Issue_dt = Convert.ToDateTime(row["Issue_dt"]);
                    b1.Issue_days = Convert.ToInt32(row["Issue_days"]);
                    b1.Due_dt = Convert.ToDateTime(row["Due_dt"]);
                    b1.Return_dt = Convert.ToDateTime(row["Return_dt"]);
                    b1.Due_day = Convert.ToInt32(row["Due_day"]);
                    b1.Is_return = Convert.ToBoolean(row["Is_return"]);
                    b1.Is_fine = Convert.ToBoolean(row["Is_fine"]);
                    b1.Fine_rate = Convert.ToDecimal(row["Fine_rate"]);
                    b1.Fine_amt = Convert.ToDecimal(row["Fine_amt"]);
    
                        listBook_Issue_Return.Add(b1);
                    }
                }
            }
    
            return listBook_Issue_Return;
        }        
        public List<Book_Issue_Return> GetBook_Issue_ReturnList(string Sql)
        { 
            List<Book_Issue_Return> listBook_Issue_Return = null;
  
            //Lets get the list of all Book_Issue_Return in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Book_Issue_Return 
                    listBook_Issue_Return = new List<Book_Issue_Return>();
   
                    //Now lets populate the Book_Issue_Return details into the list of Book_Issue_Return 
                    foreach (DataRow row in table.Rows)
                    {
                    Book_Issue_Return b1 = new Book_Issue_Return();
                    b1.Bir_id = Convert.ToInt32(row["Bir_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Acc_id = Convert.ToInt32(row["Acc_id"]);
                    b1.Issue_dt = Convert.ToDateTime(row["Issue_dt"]);
                    b1.Issue_days = Convert.ToInt32(row["Issue_days"]);
                    b1.Due_dt = Convert.ToDateTime(row["Due_dt"]);
                    b1.Return_dt = Convert.ToDateTime(row["Return_dt"]);
                    b1.Due_day = Convert.ToInt32(row["Due_day"]);
                    b1.Is_return = Convert.ToBoolean(row["Is_return"]);
                    b1.Is_fine = Convert.ToBoolean(row["Is_fine"]);
                    b1.Fine_rate = Convert.ToDecimal(row["Fine_rate"]);
                    b1.Fine_amt = Convert.ToDecimal(row["Fine_amt"]);
    
                        listBook_Issue_Return.Add(b1);
                    }
                }
            }
    
            return listBook_Issue_Return;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VBook_Issue_Return]"; 
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
            string Sql = "select max(Bir_id) from [Book_Issue_Return]";
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

