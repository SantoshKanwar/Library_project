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
  public class Composite1_Desig
  {
 
////[ VARIABLES ]///////////////////
     private Int32 comp1_id = 0;
     private Int32 des_id = 0;
     private Int32 college_id = 0;
 
////[ Get - Set ]///////////////////

   public Int32 Comp1_id 
   {
         get
         {
             return comp1_id; 
         }
         set
         {
             comp1_id = value; 
         }
   }

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
  }
}

