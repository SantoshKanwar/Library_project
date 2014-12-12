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
  public class Book_Master
  {
 
////[ VARIABLES ]///////////////////
     private Int32 book_id = 0;
     private Int32 reg_id = 0;
     private DateTime pdate = DateTime.Now;
     private String author = " ";
     private String title = " ";
     private String subject = " ";
     private String book_type = " ";
     private String edition = " ";
     private String publisher_place = " ";
     private String publisher = " ";
     private Int32 year = 0;
     private Int32 pages = 0;
     private String volume = " ";
     private String source = " ";
     private Decimal cost = 0;
     private Int32 bill_no = 0;
     private Int32 book_no = 0;
     private String more_info = " ";
     private String photo = " ";
 
////[ Get - Set ]///////////////////

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

   public DateTime Pdate 
   {
         get
         {
             return pdate; 
         }
         set
         {
             pdate = value; 
         }
   }

   public String Author 
   {
         get
         {
             return author; 
         }
         set
         {
             author = value; 
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

   public String Subject 
   {
         get
         {
             return subject; 
         }
         set
         {
             subject = value; 
         }
   }

   public String Book_type 
   {
         get
         {
             return book_type; 
         }
         set
         {
             book_type = value; 
         }
   }

   public String Edition 
   {
         get
         {
             return edition; 
         }
         set
         {
             edition = value; 
         }
   }

   public String Publisher_place 
   {
         get
         {
             return publisher_place; 
         }
         set
         {
             publisher_place = value; 
         }
   }

   public String Publisher 
   {
         get
         {
             return publisher; 
         }
         set
         {
             publisher = value; 
         }
   }

   public Int32 Year 
   {
         get
         {
             return year; 
         }
         set
         {
             year = value; 
         }
   }

   public Int32 Pages 
   {
         get
         {
             return pages; 
         }
         set
         {
             pages = value; 
         }
   }

   public String Volume 
   {
         get
         {
             return volume; 
         }
         set
         {
             volume = value; 
         }
   }

   public String Source 
   {
         get
         {
             return source; 
         }
         set
         {
             source = value; 
         }
   }

   public Decimal Cost 
   {
         get
         {
             return cost; 
         }
         set
         {
             cost = value; 
         }
   }

   public Int32 Bill_no 
   {
         get
         {
             return bill_no; 
         }
         set
         {
             bill_no = value; 
         }
   }

   public Int32 Book_no 
   {
         get
         {
             return book_no; 
         }
         set
         {
             book_no = value; 
         }
   }

   public String More_info 
   {
         get
         {
             return more_info; 
         }
         set
         {
             more_info = value; 
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
  }
}

