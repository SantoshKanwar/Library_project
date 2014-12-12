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
  public class FineHandler
  {
 
        // Handle to the Fine DBAccess class
        FineDBAccess fineDb = null;
 
        public FineHandler()
        {
            fineDb = new FineDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of fines, we can put some logic here if needed
        public List<Fine> GetFineList()
        {
            return fineDb.GetFineList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of fines, we can put some logic here if needed
        public List<Fine> GetFineList(string sql)
        {
            return fineDb.GetFineList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of fines, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from Vfine";
            return fineDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of fines, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return fineDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of fines, we can put some logic here if needed
        public bool UpdateFine(Fine b1)
        {
            return fineDb.UpdateFine(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of fines, we can put some logic here if needed
        public Fine GetFineDetails(int ID)
        {
            return fineDb.GetFineDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of fines, we can put some logic here if needed
        public bool DeleteFine(Fine b1)
        {
            return fineDb.DeleteFine(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of fines, we can put some logic here if needed
        public bool AddNewFine(Fine b1)
        {
            return fineDb.AddNewFine(b1);
        }
    }
}

