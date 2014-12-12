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
  public class Purchase_DetailHandler
  {
 
        // Handle to the Purchase_Detail DBAccess class
        Purchase_DetailDBAccess purchase_detailDb = null;
 
        public Purchase_DetailHandler()
        {
            purchase_detailDb = new Purchase_DetailDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_details, we can put some logic here if needed
        public List<Purchase_Detail> GetPurchase_DetailList()
        {
            return purchase_detailDb.GetPurchase_DetailList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_details, we can put some logic here if needed
        public List<Purchase_Detail> GetPurchase_DetailList(string sql)
        {
            return purchase_detailDb.GetPurchase_DetailList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_details, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "Select *from VPurchase_Detail";
            return purchase_detailDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_details, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return purchase_detailDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_details, we can put some logic here if needed
        public bool UpdatePurchase_Detail(Purchase_Detail b1)
        {
            return purchase_detailDb.UpdatePurchase_Detail(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_details, we can put some logic here if needed
        public Purchase_Detail GetPurchase_DetailDetails(int ID)
        {
            return purchase_detailDb.GetPurchase_DetailDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_details, we can put some logic here if needed
        public bool DeletePurchase_Detail(Purchase_Detail b1)
        {
            return purchase_detailDb.DeletePurchase_Detail(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_details, we can put some logic here if needed
        public bool AddNewPurchase_Detail(Purchase_Detail b1)
        {
            return purchase_detailDb.AddNewPurchase_Detail(b1);
        }
    }
}

