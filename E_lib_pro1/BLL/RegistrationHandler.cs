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
  public class RegistrationHandler
  {
 
        // Handle to the Registration DBAccess class
        RegistrationDBAccess registrationDb = null;
 
        public RegistrationHandler()
        {
            registrationDb = new RegistrationDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of registrations, we can put some logic here if needed
        public List<Registration> GetRegistrationList()
        {
            return registrationDb.GetRegistrationList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of registrations, we can put some logic here if needed
        public List<Registration> GetRegistrationList(string sql)
        {
            return registrationDb.GetRegistrationList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of registrations, we can put some logic here if needed
        public DataTable GetList()
        {
            return registrationDb.GetList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of registrations, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return registrationDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of registrations, we can put some logic here if needed
        public bool UpdateRegistration(Registration b1)
        {
            return registrationDb.UpdateRegistration(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of registrations, we can put some logic here if needed
        public Registration GetRegistrationDetails(int ID)
        {
            return registrationDb.GetRegistrationDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of registrations, we can put some logic here if needed
        public bool DeleteRegistration(Registration b1)
        {
            return registrationDb.DeleteRegistration(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of registrations, we can put some logic here if needed
        public bool AddNewRegistration(Registration b1)
        {
            return registrationDb.AddNewRegistration(b1);
        }
    }
}

