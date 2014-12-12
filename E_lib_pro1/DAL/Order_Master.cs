using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;using System.Web.UI;using System.Web.UI.WebControls;
using System.Data.SqlClient;


using AURO.BLL;
 
namespace AURO.DAL
{
  public class Order_Master
  {
 
////[ VARIABLES ]///////////////////
     private Int32 om_id = 0;
     private Int32 reg_id = 0;
     private Int32 mem_id = 0;
     private Int32 om_number = 0;
     private DateTime om_date = DateTime.Now;
     private Int32 order_bill_no = 0;
     private DateTime ord_date = DateTime.Now;
     private String sup_name = " ";
     private String sup_address = " ";
     private String sup_city = " ";
     private Decimal sup_mobile = 0;
     private String sup_email = " ";
     private Decimal gross_amt = 0;
     private Decimal dis_amt = 0;
     private Decimal net_amt = 0;
     private String is_paid = " ";
     private String user1 = " ";
     private Int32 status = 0;
 
////[ Get - Set ]///////////////////

   public Int32 Om_id 
   {
         get
         {
             return om_id; 
         }
         set
         {
             om_id = value; 
         }
   }

   public Int32 Reg_id 
   {
         get
         {
             return reg_id; 
         }
         set
         {
             reg_id = value; 
         }
   }

   public Int32 Mem_id 
   {
         get
         {
             return mem_id; 
         }
         set
         {
             mem_id = value; 
         }
   }

   public Int32 Om_number 
   {
         get
         {
             return om_number; 
         }
         set
         {
             om_number = value; 
         }
   }

   public DateTime Om_date 
   {
         get
         {
             return om_date; 
         }
         set
         {
             om_date = value; 
         }
   }

   public Int32 Order_bill_no 
   {
         get
         {
             return order_bill_no; 
         }
         set
         {
             order_bill_no = value; 
         }
   }

   public DateTime Ord_date 
   {
         get
         {
             return ord_date; 
         }
         set
         {
             ord_date = value; 
         }
   }

   public String Sup_name 
   {
         get
         {
             return sup_name; 
         }
         set
         {
             sup_name = value; 
         }
   }

   public String Sup_address 
   {
         get
         {
             return sup_address; 
         }
         set
         {
             sup_address = value; 
         }
   }

   public String Sup_city 
   {
         get
         {
             return sup_city; 
         }
         set
         {
             sup_city = value; 
         }
   }

   public Decimal Sup_mobile 
   {
         get
         {
             return sup_mobile; 
         }
         set
         {
             sup_mobile = value; 
         }
   }

   public String Sup_email 
   {
         get
         {
             return sup_email; 
         }
         set
         {
             sup_email = value; 
         }
   }

   public Decimal Gross_amt 
   {
         get
         {
             return gross_amt; 
         }
         set
         {
             gross_amt = value; 
         }
   }

   public Decimal Dis_amt 
   {
         get
         {
             return dis_amt; 
         }
         set
         {
             dis_amt = value; 
         }
   }

   public Decimal Net_amt 
   {
         get
         {
             return net_amt; 
         }
         set
         {
             net_amt = value; 
         }
   }

   public String Is_paid 
   {
         get
         {
             return is_paid; 
         }
         set
         {
             is_paid = value; 
         }
   }

   public String User1 
   {
         get
         {
             return user1; 
         }
         set
         {
             user1 = value; 
         }
   }

   public Int32 Status 
   {
         get
         {
             return status; 
         }
         set
         {
             status = value; 
         }
   }
  }
}

