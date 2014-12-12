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
  public class RegistrationDBAccess
  {
     public bool AddNewRegistration(Registration b1)
     {   
             
      b1.Reg_id = GetNewTBLID();       
      string sql = "insert into [Registration] ([Reg_id],[Username],[Password],[F_name],[L_name],[Address],[City],[Phone],[Mobile],[Email],[Seq_que],[Answer],[Photo],[Status]) values(" + b1.Reg_id+ ", '" + b1.Username+ "', '" + b1.Password+ "', '" + b1.F_name+ "', '" + b1.L_name+ "', '" + b1.Address+ "', '" + b1.City+ "', '" + b1.Phone+ "', " + b1.Mobile+ ", '" + b1.Email+ "', '" + b1.Seq_que+ "', '" + b1.Answer+ "', '" + b1.Photo+ "', " + b1.Status+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateRegistration(Registration b1)
     {   
             
      string sql = "update [Registration] set [Username]='" + b1.Username+ "',[Password]='" + b1.Password+ "',[F_name]='" + b1.F_name+ "',[L_name]='" + b1.L_name+ "',[Address]='" + b1.Address+ "',[City]='" + b1.City+ "',[Phone]='" + b1.Phone+ "',[Mobile]=" + b1.Mobile+ " ,[Email]='" + b1.Email+ "',[Seq_que]='" + b1.Seq_que+ "',[Answer]='" + b1.Answer+ "',[Photo]='" + b1.Photo+ "',[Status]=" + b1.Status+ "   where [Reg_id] =" + b1.Reg_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteRegistration(Registration x1)
     {   
             
      string Sql = "delete from [Registration]  where [Reg_id] =" + x1.Reg_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Registration GetRegistrationDetails(int x1)
        { 
          
            string Sql = "select * from [Registration]   where [Reg_id] =" + x1 +" ";
            
            
            Registration b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Registration 
                    b1 = new Registration();
    
                    //Now lets populate the employee details into the list of Registration 
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Username = row["Username"].ToString();
                    b1.Password = row["Password"].ToString();
                    b1.F_name = row["F_name"].ToString();
                    b1.L_name = row["L_name"].ToString();
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Email = row["Email"].ToString();
                    b1.Seq_que = row["Seq_que"].ToString();
                    b1.Answer = row["Answer"].ToString();
                    b1.Photo = row["Photo"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Registration> GetRegistrationList()
        { 
            string Sql = "select * from [Registration]"; 
            List<Registration> listRegistration = null;
  
            //Lets get the list of all Registration in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Registration 
                    listRegistration = new List<Registration>();
   
                    //Now lets populate the Registration details into the list of Registration 
                    foreach (DataRow row in table.Rows)
                    {
                    Registration b1 = new Registration();
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Username = row["Username"].ToString();
                    b1.Password = row["Password"].ToString();
                    b1.F_name = row["F_name"].ToString();
                    b1.L_name = row["L_name"].ToString();
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Email = row["Email"].ToString();
                    b1.Seq_que = row["Seq_que"].ToString();
                    b1.Answer = row["Answer"].ToString();
                    b1.Photo = row["Photo"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listRegistration.Add(b1);
                    }
                }
            }
    
            return listRegistration;
        }        
        public List<Registration> GetRegistrationList(string Sql)
        { 
            List<Registration> listRegistration = null;
  
            //Lets get the list of all Registration in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Registration 
                    listRegistration = new List<Registration>();
   
                    //Now lets populate the Registration details into the list of Registration 
                    foreach (DataRow row in table.Rows)
                    {
                    Registration b1 = new Registration();
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Username = row["Username"].ToString();
                    b1.Password = row["Password"].ToString();
                    b1.F_name = row["F_name"].ToString();
                    b1.L_name = row["L_name"].ToString();
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Email = row["Email"].ToString();
                    b1.Seq_que = row["Seq_que"].ToString();
                    b1.Answer = row["Answer"].ToString();
                    b1.Photo = row["Photo"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listRegistration.Add(b1);
                    }
                }
            }
    
            return listRegistration;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [Registration]"; 
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            return table;
        }        
        public DataTable GetList(string Sql)
        { 
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            return table;
        }        
        public int GetNewTBLID()
        { 
            int i = 0;
            string Sql = "select max(Reg_id) from [Registration]";
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            if (table.Rows.Count > 0 && table.Rows[0][0].ToString() != "")
              {
                    i = Convert.ToInt32(table.Rows[0][0].ToString()) + 1;    
               }
               else
               {
                     i = 1;
               }
            return i;
        }        
    }   
 }   

