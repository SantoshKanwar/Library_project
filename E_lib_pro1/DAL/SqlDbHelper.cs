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
     class SqlDBHelper
     {
         const string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.MDF;Integrated Security=True;User Instance=True";
 
         // This function will be used to execute R(CRUD) operation of parameterless commands
         internal static DataTable ExecuteSelectCommand(string Sql)
         {
             DataTable table = null;
             using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
             {
                 using (SqlCommand cmd = con.CreateCommand())
                 {
                     cmd.CommandText = Sql;
 
                     try
                     {
                         if (con.State != ConnectionState.Open)
                         {
                             con.Open();
                         }
 
                         using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                         {
                             table = new DataTable();
                             da.Fill(table);
                         }
                     }
                     catch
                     {
                         throw;
                     }
                 }
             }
 
             return table;
         }
         // This function will be used to execute CUD(CRUD) operation 
         internal static bool ExecuteNonQuery(string Sql)
         {
             int result = 0;
 
             using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
             {
                 using (SqlCommand cmd = con.CreateCommand())
                 {
                     cmd.CommandText = Sql;
 
                     //try
                     //{
                         if (con.State != ConnectionState.Open)
                         {
                             con.Open();
                         }
        
                         result = cmd.ExecuteNonQuery();
                     //}
                     //catch
                     //{
                     //    throw;
                     //}
                 }
             }
       
             return (result > 0);
         }
     }
 }
             

