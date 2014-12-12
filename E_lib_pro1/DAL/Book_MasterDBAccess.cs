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
  public class Book_MasterDBAccess
  {
     public bool AddNewBook_Master(Book_Master b1)
     {   
             
      b1.Book_id = GetNewTBLID();       
      string sql = "insert into [Book_Master] ([Book_id],[Reg_id],[Pdate],[Author],[Title],[Subject],[Book_type],[Edition],[Publisher_place],[Publisher],[Year],[Pages],[Volume],[Source],[Cost],[Bill_no],[Book_no],[More_info],[Photo]) values(" + b1.Book_id+ ", " + b1.Reg_id+ ", '" + b1.Pdate+ "', '" + b1.Author+ "', '" + b1.Title+ "', '" + b1.Subject+ "', '" + b1.Book_type+ "', '" + b1.Edition+ "', '" + b1.Publisher_place+ "', '" + b1.Publisher+ "', " + b1.Year+ ", " + b1.Pages+ ", '" + b1.Volume+ "', '" + b1.Source+ "', " + b1.Cost+ ", " + b1.Bill_no+ ", " + b1.Book_no+ ", '" + b1.More_info+ "', '" + b1.Photo+ "' )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateBook_Master(Book_Master b1)
     {   
             
      string sql = "update [Book_Master] set [Reg_id]=" + b1.Reg_id+ " ,[Pdate]='" + b1.Pdate+ "',[Author]='" + b1.Author+ "',[Title]='" + b1.Title+ "',[Subject]='" + b1.Subject+ "',[Book_type]='" + b1.Book_type+ "',[Edition]='" + b1.Edition+ "',[Publisher_place]='" + b1.Publisher_place+ "',[Publisher]='" + b1.Publisher+ "',[Year]=" + b1.Year+ " ,[Pages]=" + b1.Pages+ " ,[Volume]='" + b1.Volume+ "',[Source]='" + b1.Source+ "',[Cost]=" + b1.Cost+ " ,[Bill_no]=" + b1.Bill_no+ " ,[Book_no]=" + b1.Book_no+ " ,[More_info]='" + b1.More_info+ "',[Photo]='" + b1.Photo+ "'  where [Book_id] =" + b1.Book_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteBook_Master(Book_Master x1)
     {   
             
      string Sql = "delete from [Book_Master]  where [Book_id] =" + x1.Book_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Book_Master GetBook_MasterDetails(int x1)
        { 
          
            string Sql = "select * from [Book_Master]   where [Book_id] =" + x1 +" ";
            
            
            Book_Master b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Book_Master 
                    b1 = new Book_Master();
    
                    //Now lets populate the employee details into the list of Book_Master 
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Pdate = Convert.ToDateTime(row["Pdate"]);
                    b1.Author = row["Author"].ToString();
                    b1.Title = row["Title"].ToString();
                    b1.Subject = row["Subject"].ToString();
                    b1.Book_type = row["Book_type"].ToString();
                    b1.Edition = row["Edition"].ToString();
                    b1.Publisher_place = row["Publisher_place"].ToString();
                    b1.Publisher = row["Publisher"].ToString();
                    b1.Year = Convert.ToInt32(row["Year"]);
                    b1.Pages = Convert.ToInt32(row["Pages"]);
                    b1.Volume = row["Volume"].ToString();
                    b1.Source = row["Source"].ToString();
                    b1.Cost = Convert.ToDecimal(row["Cost"]);
                    b1.Bill_no = Convert.ToInt32(row["Bill_no"]);
                    b1.Book_no = Convert.ToInt32(row["Book_no"]);
                    b1.More_info = row["More_info"].ToString();
                    b1.Photo = row["Photo"].ToString();
                }
            } 
 
            return b1; 
        }
 
        public List<Book_Master> GetBook_MasterList()
        { 
            string Sql = "select * from [Book_Master]"; 
            List<Book_Master> listBook_Master = null;
  
            //Lets get the list of all Book_Master in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Book_Master 
                    listBook_Master = new List<Book_Master>();
   
                    //Now lets populate the Book_Master details into the list of Book_Master 
                    foreach (DataRow row in table.Rows)
                    {
                    Book_Master b1 = new Book_Master();
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Pdate = Convert.ToDateTime(row["Pdate"]);
                    b1.Author = row["Author"].ToString();
                    b1.Title = row["Title"].ToString();
                    b1.Subject = row["Subject"].ToString();
                    b1.Book_type = row["Book_type"].ToString();
                    b1.Edition = row["Edition"].ToString();
                    b1.Publisher_place = row["Publisher_place"].ToString();
                    b1.Publisher = row["Publisher"].ToString();
                    b1.Year = Convert.ToInt32(row["Year"]);
                    b1.Pages = Convert.ToInt32(row["Pages"]);
                    b1.Volume = row["Volume"].ToString();
                    b1.Source = row["Source"].ToString();
                    b1.Cost = Convert.ToDecimal(row["Cost"]);
                    b1.Bill_no = Convert.ToInt32(row["Bill_no"]);
                    b1.Book_no = Convert.ToInt32(row["Book_no"]);
                    b1.More_info = row["More_info"].ToString();
                    b1.Photo = row["Photo"].ToString();
    
                        listBook_Master.Add(b1);
                    }
                }
            }
    
            return listBook_Master;
        }        
        public List<Book_Master> GetBook_MasterList(string Sql)
        { 
            List<Book_Master> listBook_Master = null;
  
            //Lets get the list of all Book_Master in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Book_Master 
                    listBook_Master = new List<Book_Master>();
   
                    //Now lets populate the Book_Master details into the list of Book_Master 
                    foreach (DataRow row in table.Rows)
                    {
                    Book_Master b1 = new Book_Master();
                    b1.Book_id = Convert.ToInt32(row["Book_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Pdate = Convert.ToDateTime(row["Pdate"]);
                    b1.Author = row["Author"].ToString();
                    b1.Title = row["Title"].ToString();
                    b1.Subject = row["Subject"].ToString();
                    b1.Book_type = row["Book_type"].ToString();
                    b1.Edition = row["Edition"].ToString();
                    b1.Publisher_place = row["Publisher_place"].ToString();
                    b1.Publisher = row["Publisher"].ToString();
                    b1.Year = Convert.ToInt32(row["Year"]);
                    b1.Pages = Convert.ToInt32(row["Pages"]);
                    b1.Volume = row["Volume"].ToString();
                    b1.Source = row["Source"].ToString();
                    b1.Cost = Convert.ToDecimal(row["Cost"]);
                    b1.Bill_no = Convert.ToInt32(row["Bill_no"]);
                    b1.Book_no = Convert.ToInt32(row["Book_no"]);
                    b1.More_info = row["More_info"].ToString();
                    b1.Photo = row["Photo"].ToString();
    
                        listBook_Master.Add(b1);
                    }
                }
            }
    
            return listBook_Master;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [Book_Master]"; 
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
            string Sql = "select max(Book_id) from [Book_Master]";
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

