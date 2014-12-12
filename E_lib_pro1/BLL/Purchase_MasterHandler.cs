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
  public class Purchase_MasterHandler
  {
 
        // Handle to the Purchase_Master DBAccess class
        Purchase_MasterDBAccess purchase_masterDb = null;
 
        public Purchase_MasterHandler()
        {
            purchase_masterDb = new Purchase_MasterDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_masters, we can put some logic here if needed
        public List<Purchase_Master> GetPurchase_MasterList()
        {
            return purchase_masterDb.GetPurchase_MasterList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_masters, we can put some logic here if needed
        public List<Purchase_Master> GetPurchase_MasterList(string sql)
        {
            return purchase_masterDb.GetPurchase_MasterList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_masters, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from VPurchase_Master";
            return purchase_masterDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_masters, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return purchase_masterDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_masters, we can put some logic here if needed
        public bool UpdatePurchase_Master(Purchase_Master b1)
        {
            return purchase_masterDb.UpdatePurchase_Master(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_masters, we can put some logic here if needed
        public Purchase_Master GetPurchase_MasterDetails(int ID)
        {
            return purchase_masterDb.GetPurchase_MasterDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_masters, we can put some logic here if needed
        public bool DeletePurchase_Master(Purchase_Master b1)
        {
            return purchase_masterDb.DeletePurchase_Master(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of purchase_masters, we can put some logic here if needed
        public bool AddNewPurchase_Master(Purchase_Master b1)
        {
            return purchase_masterDb.AddNewPurchase_Master(b1);
        }
    }
}

