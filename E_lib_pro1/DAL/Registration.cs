using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;using System.Web.UI;using System.Web.UI.WebControls;
using System.Data.SqlClient;
//using Target_FAS.Class;

using AURO.BLL;
 
namespace AURO.DAL
{
  public class Registration
  {
 
////[ VARIABLES ]///////////////////
     private Int32 reg_id = 0;
     private String username = " ";
     private String password = " ";
     private String f_name = " ";
     private String l_name = " ";
     private String address = " ";
     private String city = " ";
     private String phone = " ";
     private Decimal mobile = 0;
     private String email = " ";
     private String seq_que = " ";
     private String answer = " ";
     private String photo = " ";
     private Int32 status = 0;
 
////[ Get - Set ]///////////////////

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

   public String Username 
   {
         get
         {
             return username; 
         }
         set
         {
             username = value; 
         }
   }

   public String Password 
   {
         get
         {
             return password; 
         }
         set
         {
             password = value; 
         }
   }

   public String F_name 
   {
         get
         {
             return f_name; 
         }
         set
         {
             f_name = value; 
         }
   }

   public String L_name 
   {
         get
         {
             return l_name; 
         }
         set
         {
             l_name = value; 
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

   public String Seq_que 
   {
         get
         {
             return seq_que; 
         }
         set
         {
             seq_que = value; 
         }
   }

   public String Answer 
   {
         get
         {
             return answer; 
         }
         set
         {
             answer = value; 
         }
   }

   public String Photo 
   {
         get
         {
             return photo; 
         }
         set
         {
             photo = value; 
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

