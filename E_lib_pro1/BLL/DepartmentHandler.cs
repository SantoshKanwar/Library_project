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
  public class DepartmentHandler
  {
 
        // Handle to the Department DBAccess class
        DepartmentDBAccess departmentDb = null;
 
        public DepartmentHandler()
        {
            departmentDb = new DepartmentDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of departments, we can put some logic here if needed
        public List<Department> GetDepartmentList()
        {
            return departmentDb.GetDepartmentList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of departments, we can put some logic here if needed
        public List<Department> GetDepartmentList(string sql)
        {
            return departmentDb.GetDepartmentList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of departments, we can put some logic here if needed
        public DataTable GetList()
        {
            return departmentDb.GetList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of departments, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return departmentDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of departments, we can put some logic here if needed
        public bool UpdateDepartment(Department b1)
        {
            return departmentDb.UpdateDepartment(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of departments, we can put some logic here if needed
        public Department GetDepartmentDetails(int ID)
        {
            return departmentDb.GetDepartmentDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of departments, we can put some logic here if needed
        public bool DeleteDepartment(Department b1)
        {
            return departmentDb.DeleteDepartment(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of departments, we can put some logic here if needed
        public bool AddNewDepartment(Department b1)
        {
            return departmentDb.AddNewDepartment(b1);
        }
    }
}

