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
  public class Reservation
  {
 
////[ VARIABLES ]///////////////////
     private Int32 res_id = 0;
     private Int32 reg_id = 0;
     private DateTime res_date = DateTime.Now;
     private String book_title = " ";
     private String book_author = " ";
     private String book_publisher = " ";
     private Int32 mem_id = 0;
     private Int32 status = 0;
 
////[ Get - Set ]///////////////////

   public Int32 Res_id 
   {
         get
         {
             return res_id; 
         }
         set
         {
             res_id = value; 
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

   public DateTime Res_date 
   {
         get
         {
             return res_date; 
         }
         set
         {
             res_date = value; 
         }
   }

   public String Book_title 
   {
         get
         {
             return book_title; 
         }
         set
         {
             book_title = value; 
         }
   }

   public String Book_author 
   {
         get
         {
             return book_author; 
         }
         set
         {
             book_author = value; 
         }
   }

   public String Book_publisher 
   {
         get
         {
             return book_publisher; 
         }
         set
         {
             book_publisher = value; 
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

