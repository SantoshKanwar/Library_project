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
  public class MemberDBAccess
  {
     public bool AddNewMember(Member b1)
     {   
             
      b1.Mem_id = GetNewTBLID();       
      string sql = "insert into [Member] ([Mem_id],[Reg_id],[Username],[Password],[F_name],[L_name],[Gender],[Dob],[Address],[City],[Phone],[Role],[Mobile],[Email],[Photo],[Des_id],[Dep_id],[College_id],[Member_code],[Status]) values(" + b1.Mem_id+ ", " + b1.Reg_id+ ", '" + b1.Username+ "', '" + b1.Password+ "', '" + b1.F_name+ "', '" + b1.L_name+ "', '" + b1.Gender+ "', '" + b1.Dob+ "', '" + b1.Address+ "', '" + b1.City+ "', '" + b1.Phone+ "', '" + b1.Role+ "', " + b1.Mobile+ ", '" + b1.Email+ "', '" + b1.Photo+ "', " + b1.Des_id+ ", " + b1.Dep_id+ ", " + b1.College_id+ ", '" + b1.Member_code+ "', " + b1.Status+ " )";
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool UpdateMember(Member b1)
     {   
             
      string sql = "update [Member] set [Reg_id]=" + b1.Reg_id+ " ,[Username]='" + b1.Username+ "',[Password]='" + b1.Password+ "',[F_name]='" + b1.F_name+ "',[L_name]='" + b1.L_name+ "',[Gender]='" + b1.Gender+ "',[Dob]='" + b1.Dob+ "',[Address]='" + b1.Address+ "',[City]='" + b1.City+ "',[Phone]='" + b1.Phone+ "',[Role]='" + b1.Role+ "',[Mobile]=" + b1.Mobile+ " ,[Email]='" + b1.Email+ "',[Photo]='" + b1.Photo+ "',[Des_id]=" + b1.Des_id+ " ,[Dep_id]=" + b1.Dep_id+ " ,[College_id]=" + b1.College_id+ " ,[Member_code]='" + b1.Member_code+ "',[Status]=" + b1.Status+ "   where [Mem_id] =" + b1.Mem_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(sql);
     }
////////////////////////////
             
     public bool DeleteMember(Member x1)
     {   
             
      string Sql = "delete from [Member]  where [Mem_id] =" + x1.Mem_id+ " "  ;
 
     return SqlDBHelper.ExecuteNonQuery(Sql);
     }
////////////////////////////
             
        public Member GetMemberDetails(int x1)
        { 
          
            string Sql = "select * from [Member]   where [Mem_id] =" + x1 +" ";
            
            
            Member b1 = null; 
            //Lets get the list of all employees in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            { 
                //check if any record exist or not
                if (table.Rows.Count == 1)
                { 
                    DataRow row = table.Rows[0];
  
                    //Lets go ahead and create the list of Member 
                    b1 = new Member();
    
                    //Now lets populate the employee details into the list of Member 
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Username = row["Username"].ToString();
                    b1.Password = row["Password"].ToString();
                    b1.F_name = row["F_name"].ToString();
                    b1.L_name = row["L_name"].ToString();
                    b1.Gender = row["Gender"].ToString();
                    b1.Dob = Convert.ToDateTime(row["Dob"]);
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Role = row["Role"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Email = row["Email"].ToString();
                    b1.Photo = row["Photo"].ToString();
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Member_code = row["Member_code"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
                }
            } 
 
            return b1; 
        }
 
        public List<Member> GetMemberList()
        { 
            string Sql = "select * from [Member]"; 
            List<Member> listMember = null;
  
            //Lets get the list of all Member in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Member 
                    listMember = new List<Member>();
   
                    //Now lets populate the Member details into the list of Member 
                    foreach (DataRow row in table.Rows)
                    {
                    Member b1 = new Member();
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Username = row["Username"].ToString();
                    b1.Password = row["Password"].ToString();
                    b1.F_name = row["F_name"].ToString();
                    b1.L_name = row["L_name"].ToString();
                    b1.Gender = row["Gender"].ToString();
                    b1.Dob = Convert.ToDateTime(row["Dob"]);
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Role = row["Role"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Email = row["Email"].ToString();
                    b1.Photo = row["Photo"].ToString();
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Member_code = row["Member_code"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listMember.Add(b1);
                    }
                }
            }
    
            return listMember;
        }        
        public List<Member> GetMemberList(string Sql)
        { 
            List<Member> listMember = null;
  
            //Lets get the list of all Member in a datatable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand(Sql))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of Member 
                    listMember = new List<Member>();
   
                    //Now lets populate the Member details into the list of Member 
                    foreach (DataRow row in table.Rows)
                    {
                    Member b1 = new Member();
                    b1.Mem_id = Convert.ToInt32(row["Mem_id"]);
                    b1.Reg_id = Convert.ToInt32(row["Reg_id"]);
                    b1.Username = row["Username"].ToString();
                    b1.Password = row["Password"].ToString();
                    b1.F_name = row["F_name"].ToString();
                    b1.L_name = row["L_name"].ToString();
                    b1.Gender = row["Gender"].ToString();
                    b1.Dob = Convert.ToDateTime(row["Dob"]);
                    b1.Address = row["Address"].ToString();
                    b1.City = row["City"].ToString();
                    b1.Phone = row["Phone"].ToString();
                    b1.Role = row["Role"].ToString();
                    b1.Mobile = Convert.ToDecimal(row["Mobile"]);
                    b1.Email = row["Email"].ToString();
                    b1.Photo = row["Photo"].ToString();
                    b1.Des_id = Convert.ToInt32(row["Des_id"]);
                    b1.Dep_id = Convert.ToInt32(row["Dep_id"]);
                    b1.College_id = Convert.ToInt32(row["College_id"]);
                    b1.Member_code = row["Member_code"].ToString();
                    b1.Status = Convert.ToInt32(row["Status"]);
    
                        listMember.Add(b1);
                    }
                }
            }
    
            return listMember;
        }        
        public DataTable GetList()
        { 
            string Sql = "select * from [VMember]"; 
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
            string Sql = "select max(Mem_id) from [Member]";
            DataTable table = new DataTable();
            table = SqlDBHelper.ExecuteSelectCommand(Sql);
            if (table.Rows.Count > 0 && table.Rows[0][0].ToString()!="")
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

