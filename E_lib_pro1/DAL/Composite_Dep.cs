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
  public class Composite_Dep
  {
 
////[ VARIABLES ]///////////////////
     private Int32 comp_id = 0;
     private Int32 dep_id = 0;
     private Int32 college_id = 0;
 
////[ Get - Set ]///////////////////

   public Int32 Comp_id 
   {
         get
         {
             return comp_id; 
         }
         set
         {
             comp_id = value; 
         }
   }

   public Int32 Dep_id 
   {
         get
         {
             return dep_id; 
         }
         set
         {
             dep_id = value; 
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

