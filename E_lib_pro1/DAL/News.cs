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
  public class News
  {
 
////[ VARIABLES ]///////////////////
     private Int32 news_id = 0;
     private Int32 reg_id = 0;
     private DateTime news_date = DateTime.Now;
     private String title = " ";
     private String detail = " ";
     private Int32 status = 0;
 
////[ Get - Set ]///////////////////

   public Int32 News_id 
   {
         get
         {
             return news_id; 
         }
         set
         {
             news_id = value; 
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

   public DateTime News_date 
   {
         get
         {
             return news_date; 
         }
         set
         {
             news_date = value; 
         }
   }

   public String Title 
   {
         get
         {
             return title; 
         }
         set
         {
             title = value; 
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

