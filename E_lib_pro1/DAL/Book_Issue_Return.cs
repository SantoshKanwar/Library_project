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
  public class Book_Issue_Return
  {
 
////[ VARIABLES ]///////////////////
     private Int32 bir_id = 0;
     private Int32 reg_id = 0;
     private Int32 mem_id = 0;
     private Int32 acc_id = 0;
     private DateTime issue_dt = DateTime.Now;
     private Int32 issue_days = 0;
     private DateTime due_dt = DateTime.Now;
     private DateTime return_dt = DateTime.Now;
     private Int32 due_day = 0;
     private Boolean is_return = false;
     private Boolean is_fine = false;
     private Decimal fine_rate = 0;
     private Decimal fine_amt = 0;
 
////[ Get - Set ]///////////////////

   public Int32 Bir_id 
   {
         get
         {
             return bir_id; 
         }
         set
         {
             bir_id = value; 
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

   public Int32 Acc_id 
   {
         get
         {
             return acc_id; 
         }
         set
         {
             acc_id = value; 
         }
   }

   public DateTime Issue_dt 
   {
         get
         {
             return issue_dt; 
         }
         set
         {
             issue_dt = value; 
         }
   }

   public Int32 Issue_days 
   {
         get
         {
             return issue_days; 
         }
         set
         {
             issue_days = value; 
         }
   }

   public DateTime Due_dt 
   {
         get
         {
             return due_dt; 
         }
         set
         {
             due_dt = value; 
         }
   }

   public DateTime Return_dt 
   {
         get
         {
             return return_dt; 
         }
         set
         {
             return_dt = value; 
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

   public Boolean Is_return 
   {
         get
         {
             return is_return; 
         }
         set
         {
             is_return = value; 
         }
   }

   public Boolean Is_fine 
   {
         get
         {
             return is_fine; 
         }
         set
         {
             is_fine = value; 
         }
   }

   public Decimal Fine_rate 
   {
         get
         {
             return fine_rate; 
         }
         set
         {
             fine_rate = value; 
         }
   }

   public Decimal Fine_amt 
   {
         get
         {
             return fine_amt; 
         }
         set
         {
             fine_amt = value; 
         }
   }
  }
}

