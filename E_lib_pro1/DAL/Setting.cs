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
  public class Setting
  {
 
////[ VARIABLES ]///////////////////
     private Int32 set_id = 0;
     private Int32 reg_id = 0;
     private Int32 college_id = 0;
     private string  mem_role = " ";
     private Int32 due_day = 0;
     private Int32 total_book = 0;
     private Decimal fine_per_day = 0;
 
////[ Get - Set ]///////////////////

   public Int32 Set_id 
   {
         get
         {
             return set_id; 
         }
         set
         {
             set_id = value; 
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

   public string Mem_role 
   {
         get
         {
             return mem_role; 
         }
         set
         {
             mem_role = value; 
         }
   }

   public Int32 Due_day 
   {
         get
         {
             return due_day; 
         }
         set
         {
             due_day = value; 
         }
   }

   public Int32 Total_book 
   {
         get
         {
             return total_book; 
         }
         set
         {
             total_book = value; 
         }
   }

   public Decimal Fine_per_day 
   {
         get
         {
             return fine_per_day; 
         }
         set
         {
             fine_per_day = value; 
         }
   }
  }
}

