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
  public class AccessionHandler
  {
 
        // Handle to the Accession DBAccess class
        AccessionDBAccess accessionDb = null;
 
        public AccessionHandler()
        {
            accessionDb = new AccessionDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of accessions, we can put some logic here if needed
        public List<Accession> GetAccessionList()
        {
            return accessionDb.GetAccessionList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of accessions, we can put some logic here if needed
        public List<Accession> GetAccessionList(string sql)
        {
            return accessionDb.GetAccessionList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of accessions, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select * from VAccession";
            return accessionDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of accessions, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return accessionDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of accessions, we can put some logic here if needed
        public bool UpdateAccession(Accession b1)
        {
            return accessionDb.UpdateAccession(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of accessions, we can put some logic here if needed
        public Accession GetAccessionDetails(int ID)
        {
            return accessionDb.GetAccessionDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of accessions, we can put some logic here if needed
        public bool DeleteAccession(Accession b1)
        {
            return accessionDb.DeleteAccession(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of accessions, we can put some logic here if needed
        public bool AddNewAccession(Accession b1)
        {
            return accessionDb.AddNewAccession(b1);
        }
    }
}

