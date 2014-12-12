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
  public class Composite1_DesigHandler
  {
 
        // Handle to the Composite1_Desig DBAccess class
        Composite1_DesigDBAccess composite1_desigDb = null;
 
        public Composite1_DesigHandler()
        {
            composite1_desigDb = new Composite1_DesigDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite1_desigs, we can put some logic here if needed
        public List<Composite1_Desig> GetComposite1_DesigList()
        {
            return composite1_desigDb.GetComposite1_DesigList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite1_desigs, we can put some logic here if needed
        public List<Composite1_Desig> GetComposite1_DesigList(string sql)
        {
            return composite1_desigDb.GetComposite1_DesigList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite1_desigs, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from VComposite1_Desig";
            return composite1_desigDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite1_desigs, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return composite1_desigDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of composite1_desigs, we can put some logic here if needed
        public bool UpdateComposite1_Desig(Composite1_Desig b1)
        {
            return composite1_desigDb.UpdateComposite1_Desig(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of composite1_desigs, we can put some logic here if needed
        public Composite1_Desig GetComposite1_DesigDetails(int ID)
        {
            return composite1_desigDb.GetComposite1_DesigDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of composite1_desigs, we can put some logic here if needed
        public bool DeleteComposite1_Desig(Composite1_Desig b1)
        {
            return composite1_desigDb.DeleteComposite1_Desig(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of composite1_desigs, we can put some logic here if needed
        public bool AddNewComposite1_Desig(Composite1_Desig b1)
        {
            return composite1_desigDb.AddNewComposite1_Desig(b1);
        }
    }
}

