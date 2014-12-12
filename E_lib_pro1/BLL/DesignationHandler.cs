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
  public class DesignationHandler
  {
 
        // Handle to the Designation DBAccess class
        DesignationDBAccess designationDb = null;
 
        public DesignationHandler()
        {
            designationDb = new DesignationDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of designations, we can put some logic here if needed
        public List<Designation> GetDesignationList()
        {
            return designationDb.GetDesignationList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of designations, we can put some logic here if needed
        public List<Designation> GetDesignationList(string sql)
        {
            return designationDb.GetDesignationList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of designations, we can put some logic here if needed
        public DataTable GetList()
        {
            return designationDb.GetList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of designations, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return designationDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of designations, we can put some logic here if needed
        public bool UpdateDesignation(Designation b1)
        {
            return designationDb.UpdateDesignation(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of designations, we can put some logic here if needed
        public Designation GetDesignationDetails(int ID)
        {
            return designationDb.GetDesignationDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of designations, we can put some logic here if needed
        public bool DeleteDesignation(Designation b1)
        {
            return designationDb.DeleteDesignation(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of designations, we can put some logic here if needed
        public bool AddNewDesignation(Designation b1)
        {
            return designationDb.AddNewDesignation(b1);
        }
    }
}

