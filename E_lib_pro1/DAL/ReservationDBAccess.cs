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
  public class ReservationDBAccess
  {
     public bool AddNewReservation(Reservation b1)
     {   
             
      b1.Res_id = GetNewTBLID();       
      string sql = "insert into [Reservation] ([Res_id],[Reg_id],[Res_date],[Book_title],[Book_author],[Book_publisher],[Mem_id],[Status]) values(" + b1.Res_id+ ", " + b1.Reg_id+ ", '" + b1.Res_date+ "', '" + b1.Book_title+ "', '" + b1.Book_author+ "', '" + b1.Book_publisher+ "', " + b1.Mem_id+ ", " + b1.Status+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateReservation(Reservation b1)
     {   
             
      string sql = "update [Reservation] set [Reg_id]=" + b1.Reg_id+ " ,[Res_date]='" + b1.Res_date+ "',[Book_title]='" + b1.Book_title+ "',[Book_author]='" + b1.Book_author+ "',[Book_publisher]='" + b1.Book_publisher+ "',[Mem_id]=" + b1.Mem_id+ " ,[Status]=" + b1.Status+ "   where [Res_id] =" + b1.Res_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteReservation(Reservation x1)
     {   
             
      string Sql = "delete from [Reservation]  where [Res_id] =" + x1.Res_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Reservation GetReservationDetails(int x1)
        { 
          
            string Sql = "select * from [Reservation]   where [Res_id] =" + x1 +" ";
            
            
            Reservation b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Reservation 
                    b1 = new Reservation();
    
                    //Now lets populate the employee details into the list of Reservation 
                    b1.Res_id = Convert.ToInt32(row["Res_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Res_date = Convert.ToDateTime(row["Res_date"]);
                    b1.Book_title = row["Book_title"].ToString();
                    b1.Book_author = row["Book_author"].ToString();
                    b1.Book_publisher = row["Book_publisher"].ToString();
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Status = Convert.ToInt32(row["Status"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Reservation> GetReservationList()
        { 
            string Sql = "select * from [Reservation]"; 
            List<Reservation> listReservation = null;
  
            //Lets get the list of all Reservation in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Reservation 
                    listReservation = new List<Reservation>();
   
                    //Now lets populate the Reservation details into the list of Reservation 
                    foreach (DataRow row in table.Rows)
                    {
                    Reservation b1 = new Reservation();
                    b1.Res_id = Convert.ToInt32(row["Res_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Res_date = Convert.ToDateTime(row["Res_date"]);
                    b1.Book_title = row["Book_title"].ToString();
                    b1.Book_author = row["Book_author"].ToString();
                    b1.Book_publisher = row["Book_publisher"].ToString();
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listReservation.Add(b1);
                    }
                }
            }
    
            return listReservation;
        }        
        public List<Reservation> GetReservationList(string Sql)
        { 
            List<Reservation> listReservation = null;
  
            //Lets get the list of all Reservation in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Reservation 
                    listReservation = new List<Reservation>();
   
                    //Now lets populate the Reservation details into the list of Reservation 
                    foreach (DataRow row in table.Rows)
                    {
                    Reservation b1 = new Reservation();
                    b1.Res_id = Convert.ToInt32(row["Res_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Res_date = Convert.ToDateTime(row["Res_date"]);
                    b1.Book_title = row["Book_title"].ToString();
                    b1.Book_author = row["Book_author"].ToString();
                    b1.Book_publisher = row["Book_publisher"].ToString();
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listReservation.Add(b1);
                    }
                }
            }
    
            return listReservation;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VReservation]"; 
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
            string Sql = "select max(Res_id) from [Reservation]";
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

