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
  public class Composite_DepHandler
  {
 
        // Handle to the Composite_Dep DBAccess class
        Composite_DepDBAccess composite_depDb = null;
 
        public Composite_DepHandler()
        {
            composite_depDb = new Composite_DepDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite_deps, we can put some logic here if needed
        public List<Composite_Dep> GetComposite_DepList()
        {
            return composite_depDb.GetComposite_DepList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite_deps, we can put some logic here if needed
        public List<Composite_Dep> GetComposite_DepList(string sql)
        {
            return composite_depDb.GetComposite_DepList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite_deps, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select * from VComposite_Dep";
            return composite_depDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite_deps, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return composite_depDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite_deps, we can put some logic here if needed
        public bool UpdateComposite_Dep(Composite_Dep b1)
        {
            return composite_depDb.UpdateComposite_Dep(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of composite_deps, we can put some logic here if needed
        public Composite_Dep GetComposite_DepDetails(int ID)
        {
            return composite_depDb.GetComposite_DepDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of composite_deps, we can put some logic here if needed
        public bool DeleteComposite_Dep(Composite_Dep b1)
        {
            return composite_depDb.DeleteComposite_Dep(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of composite_deps, we can put some logic here if needed
        public bool AddNewComposite_Dep(Composite_Dep b1)
        {
            return composite_depDb.AddNewComposite_Dep(b1);
        }
    }
}

