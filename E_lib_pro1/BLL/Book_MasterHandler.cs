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
  public class Book_MasterHandler
  {
 
        // Handle to the Book_Master DBAccess class
        Book_MasterDBAccess book_masterDb = null;
 
        public Book_MasterHandler()
        {
            book_masterDb = new Book_MasterDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_masters, we can put some logic here if needed
        public List<Book_Master> GetBook_MasterList()
        {
            return book_masterDb.GetBook_MasterList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_masters, we can put some logic here if needed
        public List<Book_Master> GetBook_MasterList(string sql)
        {
            return book_masterDb.GetBook_MasterList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_masters, we can put some logic here if needed
        public DataTable GetList()
        {
            return book_masterDb.GetList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_masters, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return book_masterDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_masters, we can put some logic here if needed
        public bool UpdateBook_Master(Book_Master b1)
        {
            return book_masterDb.UpdateBook_Master(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of book_masters, we can put some logic here if needed
        public Book_Master GetBook_MasterDetails(int ID)
        {
            return book_masterDb.GetBook_MasterDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of book_masters, we can put some logic here if needed
        public bool DeleteBook_Master(Book_Master b1)
        {
            return book_masterDb.DeleteBook_Master(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of book_masters, we can put some logic here if needed
        public bool AddNewBook_Master(Book_Master b1)
        {
            return book_masterDb.AddNewBook_Master(b1);
        }
    }
}

