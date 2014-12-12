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
  public class Order_Detail
  {
 
////[ VARIABLES ]///////////////////
     private Int32 od_id = 0;
     private Int32 reg_id = 0;
     private Int32 om_id = 0;
     private Int32 book_id = 0;
     private Int32 qty = 0;
     private Decimal rate = 0;
     private Decimal amount = 0;
 
////[ Get - Set ]///////////////////

   public Int32 Od_id 
   {
         get
         {
             return od_id; 
         }
         set
         {
             od_id = value; 
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

   public Int32 Book_id 
   {
         get
         {
             return book_id; 
         }
         set
         {
             book_id = value; 
         }
   }

   public Int32 Qty 
   {
         get
         {
             return qty; 
         }
         set
         {
             qty = value; 
         }
   }

   public Decimal Rate 
   {
         get
         {
             return rate; 
         }
         set
         {
             rate = value; 
         }
   }

   public Decimal Amount 
   {
         get
         {
             return amount; 
         }
         set
         {
             amount = value; 
         }
   }
  }
}

