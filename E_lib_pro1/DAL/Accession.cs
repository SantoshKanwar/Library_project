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
  public class Accession
  {
 
////[ VARIABLES ]///////////////////
     private Int32 acc_id = 0;
     private Int32 reg_id = 0;
     private Int32 book_id = 0;
     private String acc_code = " ";
     private String location = " ";
     private Int32 college_id = 0;
     private Int32 is_issue = 0;
     private Int32 status = 0;
 
////[ Get - Set ]///////////////////

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

   public String Acc_code 
   {
         get
         {
             return acc_code; 
         }
         set
         {
             acc_code = value; 
         }
   }

   public String Location 
   {
         get
         {
             return location; 
         }
         set
         {
             location = value; 
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

   public Int32 Is_issue 
   {
         get
         {
             return is_issue; 
         }
         set
         {
             is_issue = value; 
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

