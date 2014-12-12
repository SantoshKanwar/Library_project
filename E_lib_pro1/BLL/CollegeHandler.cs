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
  public class CollegeHandler
  {
 
        // Handle to the College DBAccess class
        CollegeDBAccess collegeDb = null;
 
        public CollegeHandler()
        {
            collegeDb = new CollegeDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of colleges, we can put some logic here if needed
        public List<College> GetCollegeList()
        {
            return collegeDb.GetCollegeList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of colleges, we can put some logic here if needed
        public List<College> GetCollegeList(string sql)
        {
            return collegeDb.GetCollegeList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of colleges, we can put some logic here if needed
        public DataTable GetList()
        {
            return collegeDb.GetList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of colleges, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return collegeDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of colleges, we can put some logic here if needed
        public bool UpdateCollege(College b1)
        {
            return collegeDb.UpdateCollege(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of colleges, we can put some logic here if needed
        public College GetCollegeDetails(int ID)
        {
            return collegeDb.GetCollegeDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of colleges, we can put some logic here if needed
        public bool DeleteCollege(College b1)
        {
            return collegeDb.DeleteCollege(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of colleges, we can put some logic here if needed
        public bool AddNewCollege(College b1)
        {
            return collegeDb.AddNewCollege(b1);
        }
    }
}

