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
  public class Order_DetailHandler
  {
 
        // Handle to the Order_Detail DBAccess class
        Order_DetailDBAccess order_detailDb = null;
 
        public Order_DetailHandler()
        {
            order_detailDb = new Order_DetailDBAccess();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_details, we can put some logic here if needed
        public List<Order_Detail> GetOrder_DetailList()
        {
            return order_detailDb.GetOrder_DetailList();
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_details, we can put some logic here if needed
        public List<Order_Detail> GetOrder_DetailList(string sql)
        {
            return order_detailDb.GetOrder_DetailList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_details, we can put some logic here if needed
        public DataTable GetList()
        {
            string sql = "select *from VOrder_Detail";
            return order_detailDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_details, we can put some logic here if needed
        public DataTable GetList(string sql)
        {
            return order_detailDb.GetList(sql);
        }
 
        // This fuction does not contain any business logic, it simply returns the 
        // list of order_details, we can put some logic here if needed
        public bool UpdateOrder_Detail(Order_Detail b1)
        {
            return order_detailDb.UpdateOrder_Detail(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of order_details, we can put some logic here if needed
        public Order_Detail GetOrder_DetailDetails(int ID)
        {
            return order_detailDb.GetOrder_DetailDetails(ID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of order_details, we can put some logic here if needed
        public bool DeleteOrder_Detail(Order_Detail b1)
        {
            return order_detailDb.DeleteOrder_Detail(b1);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of order_details, we can put some logic here if needed
        public bool AddNewOrder_Detail(Order_Detail b1)
        {
            return order_detailDb.AddNewOrder_Detail(b1);
        }
    }
}

