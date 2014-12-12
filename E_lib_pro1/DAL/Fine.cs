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
  public class Fine
  {
 
////[ VARIABLES ]///////////////////
     private Int32 fine_id = 0;
     private Int32 reg_id = 0;
     private Int32 rec_no = 0;
     private DateTime fine_date = DateTime.Now;
     private Int32 mem_id = 0;
     private Decimal fine_amt = 0;
     private Decimal rec_amt = 0;
     private String detail = " ";
     private Int32 rec_by = 0;
 
////[ Get - Set ]///////////////////

   public Int32 Fine_id 
   {
         get
         {
             return fine_id; 
         }
         set
         {
             fine_id = value; 
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

   public Int32 Rec_no 
   {
         get
         {
             return rec_no; 
         }
         set
         {
             rec_no = value; 
         }
   }

   public DateTime Fine_date 
   {
         get
         {
             return fine_date; 
         }
         set
         {
             fine_date = value; 
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

   public Decimal Rec_amt 
   {
         get
         {
             return rec_amt; 
         }
         set
         {
             rec_amt = value; 
         }
   }

   public String Detail 
   {
         get
         {
             return detail; 
         }
         set
         {
             detail = value; 
         }
   }

   public Int32 Rec_by 
   {
         get
         {
             return rec_by; 
         }
         set
         {
             rec_by = value; 
         }
   }
  }
}

