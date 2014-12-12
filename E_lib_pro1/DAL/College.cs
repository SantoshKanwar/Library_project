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
  public class College
  {
 
////[ VARIABLES ]///////////////////
     private Int32 college_id = 0;
     private Int32 reg_id = 0;
     private String college_Name = " ";
     private String address = " ";
     private String city = " ";
     private String phone = " ";
     private Decimal mobile = 0;
     private String fax = " ";
     private String email = " ";
     private String website = " ";
     private String college_code = " ";
     private String prefix = " ";
     private Int32 status = 0;
 
////[ Get - Set ]///////////////////

   public Int32 College_id 
   {
         get
         {
             return college_id; 
         }
         set
         {
             college_id = value; 
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

   public String College_Name 
   {
         get
         {
             return college_Name; 
         }
         set
         {
             college_Name = value; 
         }
   }

   public String Address 
   {
         get
         {
             return address; 
         }
         set
         {
             address = value; 
         }
   }

   public String City 
   {
         get
         {
             return city; 
         }
         set
         {
             city = value; 
         }
   }

   public String Phone 
   {
         get
         {
             return phone; 
         }
         set
         {
             phone = value; 
         }
   }

   public Decimal Mobile 
   {
         get
         {
             return mobile; 
         }
         set
         {
             mobile = value; 
         }
   }

   public String Fax 
   {
         get
         {
             return fax; 
         }
         set
         {
             fax = value; 
         }
   }

   public String Email 
   {
         get
         {
             return email; 
         }
         set
         {
             email = value; 
         }
   }

   public String Website 
   {
         get
         {
             return website; 
         }
         set
         {
             website = value; 
         }
   }

   public String College_code 
   {
         get
         {
             return college_code; 
         }
         set
         {
             college_code = value; 
         }
   }

   public String Prefix 
   {
         get
         {
             return prefix; 
         }
         set
         {
             prefix = value; 
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

