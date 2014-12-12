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
  public class NewsDBAccess
  {
     public bool AddNewNews(News b1)
     {   
             
      b1.News_id = GetNewTBLID();       
      string sql = "insert into [News] ([News_id],[Reg_id],[News_date],[Title],[Detail],[Status]) values(" + b1.News_id+ ", " + b1.Reg_id+ ", '" + b1.News_date+ "', '" + b1.Title+ "', '" + b1.Detail+ "', " + b1.Status+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateNews(News b1)
     {   
             
      string sql = "update [News] set [Reg_id]=" + b1.Reg_id+ " ,[News_date]='" + b1.News_date+ "',[Title]='" + b1.Title+ "',[Detail]='" + b1.Detail+ "',[Status]=" + b1.Status+ "   where [News_id] =" + b1.News_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteNews(News x1)
     {   
             
      string Sql = "delete from [News]  where [News_id] =" + x1.News_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public News GetNewsDetails(int x1)
        { 
          
            string Sql = "select * from [News]   where [News_id] =" + x1 +" ";
            
            
            News b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of News 
                    b1 = new News();
    
                    //Now lets populate the employee details into the list of News 
                    b1.News_id = Convert.ToInt32(row["News_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.News_date = Convert.ToDateTime(row["News_date"]);
                    b1.Title = row["Title"].ToString();
                    b1.Detail = row["Detail"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
                }
            } 
 
            return b1; 
        }
 
        public List<News> GetNewsList()
        { 
            string Sql = "select * from [News]"; 
            List<News> listNews = null;
  
            //Lets get the list of all News in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of News 
                    listNews = new List<News>();
   
                    //Now lets populate the News details into the list of News 
                    foreach (DataRow row in table.Rows)
                    {
                    News b1 = new News();
                    b1.News_id = Convert.ToInt32(row["News_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.News_date = Convert.ToDateTime(row["News_date"]);
                    b1.Title = row["Title"].ToString();
                    b1.Detail = row["Detail"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listNews.Add(b1);
                    }
                }
            }
    
            return listNews;
        }        
        public List<News> GetNewsList(string Sql)
        { 
            List<News> listNews = null;
  
            //Lets get the list of all News in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of News 
                    listNews = new List<News>();
   
                    //Now lets populate the News details into the list of News 
                    foreach (DataRow row in table.Rows)
                    {
                    News b1 = new News();
                    b1.News_id = Convert.ToInt32(row["News_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.News_date = Convert.ToDateTime(row["News_date"]);
                    b1.Title = row["Title"].ToString();
                    b1.Detail = row["Detail"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listNews.Add(b1);
                    }
                }
            }
    
            return listNews;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [News]"; 
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
            string Sql = "select max(News_id) from [News]";
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

