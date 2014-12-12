using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;using System.Web.UI;using System.Web.UI.WebControls;
using System.Data.SqlClient;


using AURO.DAL;        
 
namespace AURO.BLL
{
  public class NewsHandler
  {
 
        // Handle to the News DBAccess class
        NewsDBAccess newsDb = null;
 
        public NewsHandler()
        {
            newsDb = new NewsDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of newss, we can put some logic here if needed
        public List<News> GetNewsList()
        {
            return newsDb.GetNewsList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of newss, we can put some logic here if needed
        public List<News> GetNewsList(string sql)
        {
            return newsDb.GetNewsList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of newss, we can put some logic here if needed
        public DataTable GetList()
        {
            return newsDb.GetList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of newss, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return newsDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of newss, we can put some logic here if needed
        public bool UpdateNews(News b1)
        {
            return newsDb.UpdateNews(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of newss, we can put some logic here if needed
        public News GetNewsDetails(int ID)
        {
            return newsDb.GetNewsDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of newss, we can put some logic here if needed
        public bool DeleteNews(News b1)
        {
            return newsDb.DeleteNews(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of newss, we can put some logic here if needed
        public bool AddNewNews(News b1)
        {
            return newsDb.AddNewNews(b1);
        }
    }
}

