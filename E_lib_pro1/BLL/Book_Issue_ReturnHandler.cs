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
  public class Book_Issue_ReturnHandler
  {
 
        // Handle to the Book_Issue_Return DBAccess class
        Book_Issue_ReturnDBAccess book_issue_returnDb = null;
 
        public Book_Issue_ReturnHandler()
        {
            book_issue_returnDb = new Book_Issue_ReturnDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_issue_returns, we can put some logic here if needed
        public List<Book_Issue_Return> GetBook_Issue_ReturnList()
        {
            return book_issue_returnDb.GetBook_Issue_ReturnList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_issue_returns, we can put some logic here if needed
        public List<Book_Issue_Return> GetBook_Issue_ReturnList(string sql)
        {
            return book_issue_returnDb.GetBook_Issue_ReturnList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_issue_returns, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from VBook_Issue_Return";
            return book_issue_returnDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_issue_returns, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return book_issue_returnDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of book_issue_returns, we can put some logic here if needed
        public bool UpdateBook_Issue_Return(Book_Issue_Return b1)
        {
            return book_issue_returnDb.UpdateBook_Issue_Return(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of book_issue_returns, we can put some logic here if needed
        public Book_Issue_Return GetBook_Issue_ReturnDetails(int ID)
        {
            return book_issue_returnDb.GetBook_Issue_ReturnDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of book_issue_returns, we can put some logic here if needed
        public bool DeleteBook_Issue_Return(Book_Issue_Return b1)
        {
            return book_issue_returnDb.DeleteBook_Issue_Return(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of book_issue_returns, we can put some logic here if needed
        public bool AddNewBook_Issue_Return(Book_Issue_Return b1)
        {
            return book_issue_returnDb.AddNewBook_Issue_Return(b1);
        }
    }
}

