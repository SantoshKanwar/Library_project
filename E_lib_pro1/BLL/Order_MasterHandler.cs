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
  public class Order_MasterHandler
  {
 
        // Handle to the Order_Master DBAccess class
        Order_MasterDBAccess order_masterDb = null;
 
        public Order_MasterHandler()
        {
            order_masterDb = new Order_MasterDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_masters, we can put some logic here if needed
        public List<Order_Master> GetOrder_MasterList()
        {
            return order_masterDb.GetOrder_MasterList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_masters, we can put some logic here if needed
        public List<Order_Master> GetOrder_MasterList(string sql)
        {
            return order_masterDb.GetOrder_MasterList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_masters, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from VOrder_Master";
            return order_masterDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_masters, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return order_masterDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_masters, we can put some logic here if needed
        public bool UpdateOrder_Master(Order_Master b1)
        {
            return order_masterDb.UpdateOrder_Master(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of order_masters, we can put some logic here if needed
        public Order_Master GetOrder_MasterDetails(int ID)
        {
            return order_masterDb.GetOrder_MasterDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of order_masters, we can put some logic here if needed
        public bool DeleteOrder_Master(Order_Master b1)
        {
            return order_masterDb.DeleteOrder_Master(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of order_masters, we can put some logic here if needed
        public bool AddNewOrder_Master(Order_Master b1)
        {
            return order_masterDb.AddNewOrder_Master(b1);
        }
    }
}

