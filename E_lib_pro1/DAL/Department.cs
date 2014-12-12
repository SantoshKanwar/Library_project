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
  public class Department
  {
 
////[ VARIABLES ]///////////////////
     private Int32 dep_id = 0;
     private Int32 reg_id = 0;
     private String dep_name = " ";
     private String dep_code = " ";
 
////[ Get - Set ]///////////////////

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

   public String Dep_name 
   {
         get
         {
             return dep_name; 
         }
         set
         {
             dep_name = value; 
         }
   }

   public String Dep_code 
   {
         get
         {
             return dep_code; 
         }
         set
         {
             dep_code = value; 
         }
   }
  }
}

