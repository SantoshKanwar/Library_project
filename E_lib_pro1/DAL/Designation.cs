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
  public class Designation
  {
 
////[ VARIABLES ]///////////////////
     private Int32 des_id = 0;
     private Int32 reg_id = 0;
     private String des_name = " ";
     private Int32 des_code = 0;
     private Int32 isTeaching = 0;
 
////[ Get - Set ]///////////////////

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

   public String Des_name 
   {
         get
         {
             return des_name; 
         }
         set
         {
             des_name = value; 
         }
   }

   public Int32 Des_code 
   {
         get
         {
             return des_code; 
         }
         set
         {
             des_code = value; 
         }
   }

   public Int32 IsTeaching 
   {
         get
         {
             return isTeaching; 
         }
         set
         {
             isTeaching = value; 
         }
   }
  }
}

