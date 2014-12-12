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
  public class Member
  {
 
////[ VARIABLES ]///////////////////
     private Int32 mem_id = 0;
     private Int32 reg_id = 0;
     private String username = " ";
     private String password = " ";
     private String f_name = " ";
     private String l_name = " ";
     private String gender = " ";
     private DateTime dob = DateTime.Now;
     private String address = " ";
     private String city = " ";
     private String phone = " ";
     private String role = " ";
     private Decimal mobile = 0;
     private String email = " ";
     private String photo = " ";
     private Int32 des_id = 0;
     private Int32 dep_id = 0;
     private Int32 college_id = 0;
     private String member_code = " ";
     private Int32 status = 0;
 
////[ Get - Set ]///////////////////

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

   public String Gender 
   {
         get
         {
             return gender; 
         }
         set
         {
             gender = value; 
         }
   }

   public DateTime Dob 
   {
         get
         {
             return dob; 
         }
         set
         {
             dob = value; 
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

   public String Role 
   {
         get
         {
             return role; 
         }
         set
         {
             role = value; 
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

   public Int32 Des_id 
   {
         get
         {
             return des_id; 
         }
         set
         {
             des_id = value; 
         }
   }

   public Int32 Dep_id 
   {
         get
         {
             return dep_id; 
         }
         set
         {
             dep_id = value; 
         }
   }

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

   public String Member_code 
   {
         get
         {
             return member_code; 
         }
         set
         {
             member_code = value; 
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

